using Semiodesk.Trinity;
using System;
using System.ComponentModel.DataAnnotations;

namespace ContactTracingGraph.Configurations
{
    public class ODataResource : Resource
    {
        public ODataResource(Uri uri) : base(uri) { }

        [Key]
        public string ID
        {
            get
            {
                // Return the ID one space after the URI's fragment symbol
                return Uri.Fragment.Substring(1);
            }
            set { }
        }

        protected static Uri GenerateID(string id, string type)
        {
            return string.IsNullOrEmpty(id)
                      ? new Uri($"{type}_{DateTime.Now.ToString("HHmmssddMMyyyy")}")
                      : new Uri($"{CRT.Namespace}{id}");
        }
    }
}
