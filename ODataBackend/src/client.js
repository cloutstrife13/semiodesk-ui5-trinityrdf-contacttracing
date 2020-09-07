import { o } from 'odata'

const endpoint = 'http://localhost:5001/odata/'
process.env.NODE_TLS_REJECT_UNAUTHORIZED = "0";

export default class ODataClient {
    constructor() {
        let ProduceResponseBody = (response) => {
            return {
                body: response,  
                headers: {
                    "Content-Type": "application/json"
                }
            };
        }

        let Read = async (entityType, query = {}) => {
            var res = await o(endpoint)
                            .get(entityType)
                            .query(query);
            
            return ProduceResponseBody(res);
        }
        let Create = async (entityType, entityBody) => {
            var res = await o(endpoint)
                            .post(entityType, entityBody)
                            .query();
    
            return ProduceResponseBody(res);
        }
        let Update = async (entityType, entityID, entityBody) => {
            var res = await o(endpoint)
                            .patch(`${entityType}('${entityID}')`, entityBody)
                            .query();

            console.log(res)
            return ProduceResponseBody(res);
        }
        let Delete = async (entityType, entityID) => {
            var res = await o(endpoint)
                            .delete(`${entityType}('${entityID}')`)
                            .query();
    
            return ProduceResponseBody(res);
        }
        
        this.IssueODataRequest = async (req) => {
            var context = new Object();
            switch(req.requestType) {
                case "GET":
                    context.res = await Read(req.entityType,
                                             req.query);
                    break;
                case "POST":
                    context.res = await Create(req.entityType,
                                               req.entityBody);
                    break;
                case "PUT":
                    context.res = await Update(req.entityType,
                                               req.entityID,
                                               req.entityBody);
                    break;
                case "PATCH":
                    context.res = await Update(req.entityType,
                                               req.entityID,
                                               req.entityBody);
                    break;
                case "DELETE":    
                    context.res = await Delete(req.entityType,
                                               req.entityID);
                    break;
                default:
                    context.res = {
                        status: 400,
                        body: "Invalid protocol. Issue a request with either GET, POST, PUT, or DELETE."
                    };
                    break;
            }
            //console.log(context.res.body);
            return context.res.body;
        }
    }
}