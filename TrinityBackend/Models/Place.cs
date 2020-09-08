using ContactTracingGraph.Configurations;
using Newtonsoft.Json;
using Semiodesk.Trinity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContactTracingGraph.Models
{
    [RdfClass(CRT.Place)]
    public class Place : ODataResource
    {
        [JsonConstructor]
        public Place(string ID) : base(GenerateID(ID, CRT.Place)) { }

        public Place(Uri uri) : base(uri) { }

        [RdfProperty(CRT.name)]
        public string Name { get; set; }
    }
}
