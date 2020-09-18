sap.ui.define(["sap/ui/base/Object"], (Object) => {
    "use strict";
    return Object.extend("semiodesk.ui5.covidtracker.service.ODataGateway", {
        IssueRequestToClient: (req) => {
            return fetch("http://localhost:7200/odata", {
                "method": "POST",
                "headers": {
                    "Content-type": "application/json"
                },
                "body": JSON.stringify(req)
            })
            .then((response) => {
                return response.json();
            })
            .catch((error) => {
                console.log("Request failed", error)
            });
        }
    });
});