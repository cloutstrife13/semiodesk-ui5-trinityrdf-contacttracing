sap.ui.define(["sap/ui/base/Object"], (Object) => {
    "use strict";

    return Object.extend("semiodesk.ui5.covidtracker.service.QueryManager", {
        getQuery: function (oParams = {}) {
            return {
                "GetAllInstanceDetails": {},
                "GetTypesFromLayer": `/GetTypesFromLayer(ID='${oParams}')`,
                "AddNewDecompositionType": `/AddNewDecompositionType`
            }
        }
    })
})