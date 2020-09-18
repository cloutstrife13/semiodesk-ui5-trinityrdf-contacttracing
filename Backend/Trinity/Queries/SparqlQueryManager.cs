using Semiodesk.Trinity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactTracingGraph.Queries
{
    public class SparqlQueryManager
    {
        public SparqlQueryManager() {}

        public SparqlQuery GetPersonQuery(string parameter = "") => new SparqlQuery(
        "SELECT ?s ?p ?o WHERE {{ SELECT ?s ?p ?o WHERE { VALUES ?p" +
        "{ crt:diagnosis crt:encounter } ?s a crt:Person ; ?p ?o. }}" +
        "UNION { SELECT ?s ?p ?o WHERE { VALUES ?p { crt:covidHealthLevel }" +
        "?s a crt:Person. {SELECT ?s (MAX(?potential) AS ?riskPotential) WHERE" +
        "{ ?s a crt:Person ; crt:encounter / crt:person ?other. FILTER(?other != ?s)" +
        "BIND(EXISTS { ?other crt:diagnosis ?diagnosis. } AS ?potential)}} BIND(EXISTS" +
        "{?s crt:diagnosis ?diagnosis.} AS ?hasDiagnosis) BIND(IF(?riskPotential > 0, 2, 1)" +
        "AS ?potential) BIND(IF(?hasDiagnosis, 3, ?potential) AS ?o)}} " + parameter + " }");

        public SparqlQuery GetPersonByIdQuery(string key) => GetPersonQuery($"FILTER(?s = crt:{key})");
    }
}
