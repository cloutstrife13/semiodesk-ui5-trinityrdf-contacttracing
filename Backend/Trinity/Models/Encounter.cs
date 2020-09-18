using ContactTracingGraph.Supports;
using Newtonsoft.Json;
using Semiodesk.Trinity;
using System;
using System.Collections.Generic;

namespace ContactTracingGraph.Models
{
    [RdfClass(CRT.Encounter)]
    public class Encounter : ODataResource
    {
        [JsonConstructor]
        public Encounter(string ID) : base(ID, CRT.Encounter) { }

        public Encounter(Uri uri) : base(uri) { }

        [RdfProperty(CRT.person)]
        public List<Person> Person { get; set; }

        [RdfProperty(CRT.place)]
        public Place Place { get; set; }

        [RdfProperty(CRT.dateEncountered)]
        public DateTime DateEncountered { get; set; }

    }
}
