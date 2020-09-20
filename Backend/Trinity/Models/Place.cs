using ContactTracingGraph.Supports;
using Newtonsoft.Json;
using Semiodesk.Trinity;
using System;

namespace ContactTracingGraph.Models
{
    [RdfClass(CRT.Place)]
    public class Place : ODataResource
    {
        [JsonConstructor]
        public Place(string ID) : base(ID, CRT.Place) {}

        public Place() : base(CRT.Place) {}

        public Place(Uri uri) : base(uri) {}

        [RdfProperty(CRT.name)]
        public string Name { get; set; }
    }
}
