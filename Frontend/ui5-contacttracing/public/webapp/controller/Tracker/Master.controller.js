sap.ui.define([
	"../FactoryController",
	"sap/ui/model/Filter",
	"sap/ui/model/FilterOperator"
], (FactoryController, Filter, FilterOperator) => {
	"use strict";

	return FactoryController.extend("semiodesk.ui5.covidtracker.controller.Tracker.Master", {
		onInit: function () {
			this.oRouter = this.getRouter();

			this.setFetchConfigurationModel();
			this.setViewModelFetchConfiguration({
				sViewName: "Master",
				oQuery: {
					sEntityType: "Person",
					sModelAlias: "Users",
				}
			});

			this.getViewModel("Master");
			this.setCovidFilter();
		},
		setCovidFilter: function () {
			this.setModel({
				oModel: [
					{ID: 0, RiskLevel: "All"},
					{ID: 1, RiskLevel: "No risk"},
					{ID: 2, RiskLevel: "Potential risk"},
					{ID: 3, RiskLevel: "Infected"}
				],
				sModelAlias: "CovidFilter"
			});

			this.setModel({
				oModel: {
					BySearch: null,
					ByStatus: null
				},
				sModelAlias: "UserFilterModes"
			})
		},
		applyFilter: function (sFilterName, oFilterOption) {
			let oFilter = this.getModel("UserFilterModes");
			console.log(oFilter);
			oFilter[sFilterName] = oFilterOption;
			
			this.setModel({
				oModel: oFilter,
				sModelAlias: "UserFilterModes"
			});

			this.getView()
				.byId("userTable")
				.getBinding("items")
				.filter([oFilter["BySearch"], oFilter["ByStatus"]].filter((oElement) => oElement != null));
		},
		onSearch: function (oEvent) {
			this.applyFilter("BySearch", new Filter("ID", FilterOperator.Contains, oEvent.getSource().getValue()));
		},
		onFilterSelectionChange: function (iLevel) {
			this.applyFilter("ByStatus", new Filter("CovidHealthLevel", (iLevel > 0) ? "EQ" : "GT", iLevel));
		},
		onListItemPress: function (oEvent) {
			let oNextUIState = this.getNextPage(1),
				oUser = oEvent.getSource().getBindingContext("Users").getObject(),
				sUserId = oUser.ID;

			this.oRouter.navTo("User", {layout: oNextUIState.layout, user: sUserId});
		}
	});
});