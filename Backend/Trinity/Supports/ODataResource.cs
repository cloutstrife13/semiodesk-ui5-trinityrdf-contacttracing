using Semiodesk.Trinity;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContactTracingGraph.Supports
{
    public class ODataResource : Resource
    {
        public ODataResource(Uri uri) : base(uri) { }

        public ODataResource(string id, string classUri) : base(GenerateID(id, classUri)) { }

        [Key]
        public string ID { 
            get => Uri.Fragment.Substring(1);
            set {}
        }

        private static Uri GenerateID(string id, string type) => string.IsNullOrEmpty(id) ? new Uri($"{type}_{DateTime.Now.ToString("HHmmssddMMyyyy")}") : new Uri($"{CRT.Namespace}{id}");
    }
}
