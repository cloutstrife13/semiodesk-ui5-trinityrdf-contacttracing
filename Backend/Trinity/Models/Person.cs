using ContactTracingGraph.Supports;
using Newtonsoft.Json;
using Semiodesk.Trinity;
using System;
using System.Collections.Generic;

namespace ContactTracingGraph.Models
{
    [RdfClass(CRT.Person)]
    public class Person : ODataResource
    {
        [JsonConstructor]
        public Person(string ID) : base(ID, CRT.Person) {}

        public Person() : base(CRT.Person) {}

        public Person(Uri uri) : base(uri) {}

        [RdfProperty(CRT.covidHealthLevel)]
        public int CovidHealthLevel { get; set; }

        [RdfProperty(CRT.diagnosis)]
        public List<InfectiousDisease> Diagnosis { get; set; }
        
        [RdfProperty(CRT.encounter)]
        public List<Encounter> Encounter { get; set; }
    }
}
