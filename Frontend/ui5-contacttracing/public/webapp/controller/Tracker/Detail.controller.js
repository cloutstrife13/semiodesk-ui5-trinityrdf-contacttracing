sap.ui.define([
	"../ODataController",
	"sap/m/MessageToast"
], (ODataController, MessageToast) => {
	"use strict";

	return ODataController.extend("semiodesk.ui5.covidtracker.controller.Tracker.Detail", {
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
			this.getUser();
		},
		getUser: function () {
			this.read({
				sEntityType: `Person('${this._user}')`,
				sModelAlias: "User",
				oODataQuery: {
					"$expand": "Encounter($expand=Place),Diagnosis",
				}
			});
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
		onPressSubmit: function () {
			let oCallback = () => {
				MessageToast.show(`User ${this._user} has been diagnosed with COVID-19.`);

				let pChain = new Promise((resolve) => {
					this.read({
						sEntityType: "Person",
						sModelAlias: "Users"
					});

					resolve();
				});
				
				pChain.then(() => this.getUser());
			};

			this.create({
				sEntityType: `Person`,
				sModelAlias: "User",
				oPayload: {"ID": this._user},
				oCallback: oCallback,
				sODataAction: "SubmitDiagnosis"
			});
		},
		determineStatusTextByLevel: function (iLevel) {
			return {
				"1": "No risk",
				"2": "Potential risk",
				"3": "Infected"
			}[iLevel];
		},
		determineStatusStateByLevel: function (iLevel) {
			return {
				"1": "Success",
				"2": "Warning",
				"3": "Error"
			}[iLevel];
		},
		timestampToUtcString: function (sTimestamp) {
			return new Date(sTimestamp).toUTCString();
		}
	});
}, true);