using CWA_Graph.Configurations;
using Newtonsoft.Json;
using Semiodesk.Trinity;
using System;
using System.Collections.Generic;

namespace CWA_Graph.Models
{
    [RdfClass(CWA.User)]
    public class User : ODataResource
    {
        [JsonConstructor]
        public User(string ID) : base(GenerateID(ID, CWA.User)) { }

        public User(Uri uri) : base(uri) { }

        [RdfProperty(CWA.code)]
        public string Code { get; set; }

        [RdfProperty(CWA.isInfected)]
        public bool IsInfected { get; set; }

        [RdfProperty(CWA.hasEncountered)]
        public List<User> HasEncountered { get; set; }
    }
}
