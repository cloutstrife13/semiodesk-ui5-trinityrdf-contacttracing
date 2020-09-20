sap.ui.define([
	"../FactoryController",
	"sap/m/MessageToast",
	"sap/ui/core/Fragment",
	"sap/ui/model/Filter",
	"sap/ui/model/FilterOperator"
], (FactoryController, MessageToast, Fragment, Filter, FilterOperator) => {
	"use strict";

	return FactoryController.extend("semiodesk.ui5.covidtracker.controller.Tracker.Detail", {
		onInit: function () {
			this.oRouter = this.getRouter();
			this.oRouter.getRoute("Users").attachPatternMatched(this._onInstanceMatched, this);
			this.oRouter.getRoute("User").attachPatternMatched(this._onInstanceMatched, this);
			this.oRouter.getRoute("Encounter").attachPatternMatched(this._onInstanceMatched, this);
		},
		handleFullScreen: function () {
			var sNextLayout = this.getViewLayout("midColumn", "fullScreen");
			this.oRouter.navTo("User", {layout: sNextLayout, user: this._user});
		},
		handleExitFullScreen: function () {
			var sNextLayout = this.getViewLayout("midColumn", "exitFullScreen");
			this.oRouter.navTo("User", {layout: sNextLayout, user: this._user});
		},
		handleClose: function () {
			var sNextLayout = this.getViewLayout("midColumn", "closeColumn");
			this.oRouter.navTo("Users", {layout: sNextLayout});
		},
		_onInstanceMatched: function (oEvent) {
			this._user = oEvent.getParameter("arguments").user || this._user || "0";
			
			this.setViewModelFetchConfiguration({
				sViewName: "Detail",
				oQuery: {
					sEntityType: `Person('${this._user}')`,
					sModelAlias: "User",
					oODataQuery: {
						$expand: "Encounter($expand=Place;$orderBy=DateEncountered desc),Diagnosis($orderBy=DateDiagnosed desc)",
					}
				}
			});

			this.getViewModel("Detail");
		},
		onCallingNextPage: function (oEvent) {
			let sModelAlias = "User",
				oNextUIState = this.getNextPage(2),
				oUser = this.getModel(sModelAlias),
				oEncounter = oEvent.getSource().getBindingContext(sModelAlias).getObject(),
				sUserId = oUser.ID,
				sEncounterId = oEncounter.ID;

			this.oRouter.navTo("Encounter", {layout: oNextUIState.layout, user: sUserId, encounter: sEncounterId});
		},
		onPressSubmitDiagnosis: function () {
			this.fireODataAction({
				oPayload: {ID: this._user},
				sODataAction: "SubmitDiagnosis",
				sFeedback: `User ${this._user} has been diagnosed with COVID-19.`
			});
		},
		onPressSubmitEncounter: function() {
			let oModel = this.getModel("NewEncounter");

			this.fireODataAction({
				oPayload: {
					LocationId: oModel["sLocation"],
					UserIds: oModel["aUsers"].concat([this._user])
				},
				sODataAction: "RecordEncounter",
				sFeedback: "A new Encounter has been recorded."
			});

			Fragment.byId("popoverNavCon", "encounterPopover")
					.destroy(true);
		},
		fireODataAction: function(oParams = {oPayload, sODataAction, sFeedback}) {
			let oCallback = () => {
				MessageToast.show(oParams.sFeedback);
				this.refreshViewModel();
			};

			console.log(oParams);

			this.create({
				sEntityType: `Person`,
				sModelAlias: "User",
				oPayload: oParams.oPayload,
				oCallback: oCallback,
				sODataAction: oParams.sODataAction
			});
		},
		getEncounterFilter: function() {
			return new Filter("ID", "NE", this._user);
		},
		loadFragmentData: function() {
			this.read({
				sEntityType: "Place",
				sModelAlias: "Locations",
			});

			Fragment.byId("popoverNavCon", "createEncounter")
					.getBinding("items")
					.filter([this.getEncounterFilter()]);
		},
		setEncounterData: function() {
			this.setModel({
				oModel: {
					aUsers: new Array(),
					sLocation: "",
					bIsValid: false
				},
				sModelAlias: "NewEncounter"
			});
		},
		onOpenPopover: function (oEvent) {		
			let oButton = oEvent.getSource();

			Fragment.load({
				id: "popoverNavCon",
				name: "semiodesk.ui5.covidtracker.view.Tracker.Fragments.Encounter.Encounter",
				controller: this
			}).then(function(oPopover){
				this._oPopover = oPopover;
				this.getView().addDependent(this._oPopover);
				this._oPopover.openBy(oButton);
			}.bind(this));
		},
		onSearch: function (oEvent) {
			Fragment.byId("popoverNavCon", "createEncounter")
					.getBinding("items")
					.filter([new Filter({
						filters: [
							this.getEncounterFilter(),
							new Filter("ID", FilterOperator.Contains, oEvent.getSource().getValue())
						],
						and: true
					})]);
		},
		onUsersSelectionChange: function (oEvent) {
			let oList = oEvent.getSource(),
				oLabel = Fragment.byId("popoverNavCon", "idFilterLabel"),
				oInfoToolbar = Fragment.byId("popoverNavCon", "idInfoToolbar"),
				oModel = this.getModel("NewEncounter");

			// With the 'getSelectedContexts' function you can access the context paths
			// of all list items that have been selected, regardless of any current
			// filter on the aggregation binding.
			let aContexts = oList.getSelectedContexts(true);
			
			// Retrieve and save every selected ID
			oModel["aUsers"] = aContexts.map(oElement => oElement.getProperty("ID"));
			oModel["bIsValid"] = (oModel["aUsers"].length > 0 && oModel["sLocation"].length > 0);

			this.setModel({
				oModel: oModel,
				sModelAlias: "NewEncounter"
			});
			
			// update UI
			let bSelected = (aContexts && aContexts.length > 0),
				sText = (bSelected) ? aContexts.length + " selected" : null;
			
			oInfoToolbar.setVisible(bSelected);
			oLabel.setText(sText);
		},
		onLocationSelectionChange: function(sLocation) {
			let oModel = this.getModel("NewEncounter");
			
			oModel["sLocation"] = sLocation;
			oModel["bIsValid"] = (oModel["aUsers"].length > 0 && oModel["sLocation"].length > 0);
			
			this.setModel({
				oModel: oModel,
				sModelAlias: "NewEncounter"
			});
		},
		onPopoverExit: function(oEvent) {
			console.log(oEvent.getSource());
			oEvent.getSource().destroy(true);
		}
	});
}, true);