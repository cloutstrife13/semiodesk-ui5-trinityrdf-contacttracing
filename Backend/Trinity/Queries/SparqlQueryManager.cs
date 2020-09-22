using Semiodesk.Trinity;
using System;
using System.Collections.Generic;

namespace ContactTracingGraph.Queries
{
    public class SparqlQueryManager
    {
        readonly Dictionary<string, Delegate> queryRouter;

        public SparqlQueryManager() {
            queryRouter = new Dictionary<string, Delegate>()
            {
                { "GetAllPeople", new Func<string, string>(GetPersonQuery) },
                { "GetPersonById", new Func<string, string>(GetPersonByIdQuery) }
            };
        }

        public SparqlQuery GetQuery(string queryAlias, string parameter = "")
        {
            return new SparqlQuery(queryRouter[queryAlias].DynamicInvoke(parameter).ToString());
        }

        private string GetPersonQuery(string parameter) =>
            "SELECT ?s ?p ?o WHERE {{ SELECT ?s ?p ?o WHERE { VALUES ?p " +
            "{ crt:diagnosis crt:encounter } ?s a crt:Person ; ?p ?o. }}" +
            "UNION { SELECT ?s ?p ?o WHERE { VALUES ?p { crt:covidHealthLevel }" +
            "?s a crt:Person. {SELECT ?s (MAX(?potential) AS ?riskPotential) WHERE" +
            "{ ?s a crt:Person ; crt:encounter / crt:person ?other. FILTER(?other != ?s)" +
            "BIND(EXISTS { ?other crt:diagnosis ?diagnosis. } AS ?potential)}} BIND(EXISTS" +
            "{?s crt:diagnosis ?diagnosis.} AS ?hasDiagnosis) BIND(IF(?riskPotential > 0, 2, 1)" +
            "AS ?potential) BIND(IF(?hasDiagnosis, 3, ?potential) AS ?o)}} " + parameter + " }";

        private string GetPersonByIdQuery(string key) => GetPersonQuery($"FILTER(?s = crt:{key})");
    }
}
