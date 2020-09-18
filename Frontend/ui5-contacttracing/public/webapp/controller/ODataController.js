sap.ui.define([
    "sap/ui/core/mvc/Controller",
    "sap/ui/model/json/JSONModel",
    "sap/ui/core/UIComponent",
    "semiodesk/ui5/covidtracker/service/ODataModel",
    "semiodesk/ui5/covidtracker/service/QueryManager"
], function (Controller, JSONModel, UIComponent, ODataModel, QueryManager) {
    "use strict";
   
    return Controller.extend("semiodesk.ui5.covidtracker.controller.ODataController", {
        getClient: function () {
            return new ODataModel();
        },

        read: function (oParams = {sEntityType, sModelAlias, oODataQuery: {}}) {
            // Trigger GET request
            let pRequest = this.getClient().Read(oParams.sEntityType, oParams.oODataQuery);

            // Resolve request
            pRequest.then((oData) => {
                this.setModel(oData, oParams.sModelAlias);
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
        
        getRouter: function () {
            return UIComponent.getRouterFor(this);
        },

        getNextPage: function(state) {
            return this.getOwnerComponent().getHelper().getNextUIState(state);
        },

        getViewLayout: function (sColumn, sMode) {
            return this.getBaseView().getModel().getProperty(`/actionButtonsInfo/${sColumn}/${sMode}`);
        },

        getBaseView: function() {
            return this.getOwnerComponent();
        },
 
        getModel: function (sName) {
            let oModel = this.getBaseView().getModel(sName);
            return (oModel != undefined) ? JSON.parse(oModel.getJSON()) : null;
        },
    
        setModel: function (oModel, sName) {
            if(oModel != null) oModel = new JSONModel(oModel);
            this.getBaseView().setModel(oModel, sName);
        }
    });   
});