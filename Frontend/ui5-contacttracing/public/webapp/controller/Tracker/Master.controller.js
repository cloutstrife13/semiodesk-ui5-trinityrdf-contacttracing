sap.ui.define([
	"../ODataController"
], (ODataController) => {
	"use strict";

	return ODataController.extend("semiodesk.ui5.covidtracker.controller.Tracker.Master", {
		onInit: function () {
			this.oRouter = this.getRouter();

			this.read({
				sEntityType: "Person",
				sModelAlias: "Users"
			});
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