sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/core/UIComponent",
    "semiodesk/ui5/covidtracker/service/ODataHandler",
], function (Controller, JSONModel, UIComponent, ODataHandler) {
    "use strict";
   
    return Controller.extend("semiodesk.ui5.covidtracker.controller.FactoryController", {
        getClient: function () {
            return new ODataHandler();
        },
        getModel: function (sName) {
            let oModel = this.getOwnerComponent().getModel(sName);
            return (oModel != undefined) ? JSON.parse(oModel.getJSON()) : null;
        },
        setModel: function (oParams = {oModel, sModelAlias}) {
            if(oParams.oModel != null)
                oParams.oModel = new JSONModel(oParams.oModel);
                
            this.getOwnerComponent().setModel(oParams.oModel, oParams.sModelAlias);
        },
        read: function (oParams = {sEntityType, sModelAlias, oODataQuery: {}}) {
            // Trigger GET request
            let pRequest = this.getClient().Read(oParams.sEntityType, oParams.oODataQuery);

            // Resolve request
            pRequest.then((oData) => {
                this.setModel({
                    oModel: oData,
                    sModelAlias: oParams.sModelAlias
                });
            });
        },
        create: function (oParams = {sEntityType, sModelAlias, oPayload, oCallback, sODataAction: undefined}) {
            // Check if an OData action has been supplied
            if(oParams.sODataAction != undefined) oParams.sEntityType += `/${oParams.sODataAction}`;

            // Trigger POST request
            let pRequest = this.getClient().Create(oParams.sEntityType, oParams.oPayload);

            // Resolve request
            pRequest.then(() => {
                oParams.oCallback();
            });
        },
        setFetchConfigurationModel: function (oQueries = {
            Master: null,
            Detail: null,
            DetailDetail: null
        }) {
            this.setModel({
                oModel: oQueries,
                sModelAlias: "Queries"
            });
        },
        setViewModelFetchConfiguration: function (oParams = {sViewName, oQuery}) {
            let oQueries = this.getModel("Queries");
            oQueries[oParams.sViewName] = oParams.oQuery;
            this.setFetchConfigurationModel(oQueries);
        },
        getViewModel: function (sViewName) {
            this.read(this.getModel("Queries")[sViewName]);
        },
        refreshViewModel: function () {
            new Promise((resolve) => resolve()).then(() => {
                if(this.getModel("Queries")["Master"] != null)
                    this.getViewModel("Master");
            }).then(() => {
                if(this.getModel("Queries")["Detail"] != null)
                    this.getViewModel("Detail");
            }).then(() => {
                if(this.getModel("Queries")["DetailDetail"] != null)
                    this.getViewModel("DetailDetail");
            });
        },
        getRouter: function () {
            return UIComponent.getRouterFor(this);
        },
        getNextPage: function(state) {
            return this.getOwnerComponent().getHelper().getNextUIState(state);
        },
        getViewLayout: function (sColumn, sMode) {
            return this.getOwnerComponent().getModel().getProperty(`/actionButtonsInfo/${sColumn}/${sMode}`);
        },
        parseTimestamp: function (sTimestamp) {
			return new Date(sTimestamp).toLocaleString();
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