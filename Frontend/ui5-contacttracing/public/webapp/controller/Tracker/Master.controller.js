sap.ui.define([
	"../ODataController"
], (ODataController) => {
	"use strict";

	return ODataController.extend("semiodesk.ui5.covidtracker.controller.Tracker.Master", {
		onInit: function () {
			this.oRouter = this.getRouter();

			this.setCovidFilter();
			this.retrieveUsers();
		},
		setCovidFilter: function () {
			this.setModel({
				oModel: [
					{"ID": 0, "RiskLevel": "All"},
					{"ID": 1, "RiskLevel": "No risk"},
					{"ID": 2, "RiskLevel": "Potential risk"},
					{"ID": 3, "RiskLevel": "Infected"}
				],
				sModelAlias: "CovidFilter"
			});
		},
		retrieveUsers: function(oODataQuery = {}) {
			this.read({
				sEntityType: "Person",
				sModelAlias: "Users",
				oODataQuery: oODataQuery
			});
		},
		onFilterSelectionChange: function (iLevel) {
			this.retrieveUsers((iLevel > 0) ? {"$filter": `CovidHealthLevel eq ${iLevel}`} : {});
		},
		onListItemPress: function (oEvent) {
			let oNextUIState = this.getNextPage(1),
				oUser = oEvent.getSource().getBindingContext("Users").getObject(),
				sUserId = oUser.ID;

			this.oRouter.navTo("User", {layout: oNextUIState.layout, user: sUserId});
		},
		getUserCount: function(aUsers) {
			return aUsers.length;
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
		}
	});
});