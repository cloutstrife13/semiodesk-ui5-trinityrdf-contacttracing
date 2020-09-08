using ContactTracingGraph.Configurations;
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
        public Person(string ID) : base(GenerateID(ID, CRT.Person)) { }

        public Person(Uri uri) : base(uri) { }

        [RdfProperty(CRT.diagnosis)]
        public InfectiousDisease Diagnosis { get; set; }
        
        [RdfProperty(CRT.encounter)]
        public List<Encounter> Encounter { get; set; }
    }
}
