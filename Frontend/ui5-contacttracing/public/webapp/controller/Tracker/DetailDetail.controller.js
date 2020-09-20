sap.ui.define([
    "../FactoryController"
], (FactoryController) => {
	"use strict";

	return FactoryController.extend("semiodesk.ui5.covidtracker.controller.Tracker.DetailDetail", {
		onInit: function () {
            this.oRouter = this.getRouter();
			this.oRouter.getRoute("Encounter").attachPatternMatched(this._onInstanceMatched, this);
		},
		handleFullScreen: function () {
			var sNextLayout = this.getViewLayout("endColumn", "fullScreen");
			this.oRouter.navTo("Encounter", {layout: sNextLayout, user: this._user, encounter: this._encounter});
		},
		handleExitFullScreen: function () {
			var sNextLayout = this.getViewLayout("endColumn", "exitFullScreen");
			this.oRouter.navTo("Encounter", {layout: sNextLayout, user: this._user, encounter: this._encounter});
		},
		handleClose: function () {
			var sNextLayout = this.getViewLayout("endColumn", "closeColumn");
			this.oRouter.navTo("User", {layout: sNextLayout, user: this._user});
		},
		_onInstanceMatched: function (oEvent) {
            this._user = oEvent.getParameter("arguments").user || this._user || "0"
            this._encounter = oEvent.getParameter("arguments").encounter || this._encounter || "0";

			this.setViewModelFetchConfiguration({
				sViewName: "DetailDetail",
				oQuery: {
					sEntityType: `Encounter('${this._encounter}')`,
					sModelAlias: "Encounter",
					oODataQuery: {
						$expand: "Person,Place"
					}
				}
			});

			this.getViewModel("DetailDetail");
		},
		determineRiskTextByLevel: function (iLevel) {
			return {
				"1": "No risk",
				"2": "Low risk",
				"3": "High risk"
			}[iLevel];
		},
    });
}, true);
