using Semiodesk.Trinity;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContactTracingGraph.Supports
{
    public class ODataResource : Resource
    {
        public ODataResource(Uri uri) : base(uri) { }

        public ODataResource(string id, string classUri) : base(GenerateUri(id, classUri)) { }

        public ODataResource(string classUri) : base(GenerateUri(null, classUri)) { }

        [Key]
        public string ID { 
            get => Uri.Fragment.Substring(1);
            set {} // set must be given because of OData
        }

        // Generates the URI based on the ID and the class resource name
        private static Uri GenerateUri(string id, string type) => 
            string.IsNullOrEmpty(id) ? 
            new Uri($"{type}_{DateTime.Now.ToString("HHmmssddMMyyyy")}") : 
            new Uri($"{CRT.Namespace}{id}");
    }
}
