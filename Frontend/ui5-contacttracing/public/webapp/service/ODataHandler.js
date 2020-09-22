sap.ui.define([
    "sap/ui/base/Object",
    "semiodesk/ui5/covidtracker/service/ODataGateway"
], (Object, ODataGateway) => {
    "use strict";
    const client = new ODataGateway();

    return Object.extend("semiodesk.ui5.covidtracker.service.ODataHandler", {
        Create: (entityType, entityBody) => {
            return client.IssueRequestToClient({
                "requestType": "POST",
                "entityType": entityType,
                "entityBody": entityBody
            });
        },
        Read: (entityType, query = {}) => {
            return client.IssueRequestToClient({
                "requestType": "GET",
                "entityType": entityType,
                "query": query
            });
        },
        Update: (entityType, entityBody, entityID) => {
            return client.IssueRequestToClient({
                "requestType": "PUT",
                "entityType": entityType,
                "entityBody": entityBody,
                "entityID": entityID
            });
        },
        Delete: (entityType, entityID) => {
            return client.IssueRequestToClient({
                "requestType": "DELETE",
                "entityType": entityType,
                "entityID": entityID
            });
        }
    })
})