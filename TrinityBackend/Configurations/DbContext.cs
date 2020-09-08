using Semiodesk.Trinity;
using Semiodesk.Trinity.Store.Virtuoso;
using System;
using System.IO;
using System.Reflection;

namespace ContactTracingGraph.Configurations
{
    public class DbContext
    {
        private string connectionString = "provider=virtuoso;host=localhost;port=1111;uid=dba;pw=dba;rule=urn:example/ruleset";
        private Uri defaultModelUri = CRT.Namespace;
        public IStore Store { get { return StoreFactory.CreateStore(connectionString); } }

        public IModel DefaultModel
        {
            get
            {
                //Store.Log = (query) => Console.WriteLine(query);
                return Store.GetModel(defaultModelUri);
            }
        }

        public void Initialise()
        {
            StoreFactory.LoadProvider<VirtuosoStoreProvider>();

            // UNCOMMENT THE FOLLOWING LINE FOR PREVENTING THE ONTOLOGY TO BE OVERWRITTEN BY ITS DEFAULT VERSION
            //if (Store.GetModel(defaultModelUri).IsEmpty)
                Store.InitializeFromConfiguration(Path.Combine(Environment.CurrentDirectory, "ontologies.config"));

            OntologyDiscovery.AddAssembly(Assembly.GetExecutingAssembly());
            MappingDiscovery.RegisterCallingAssembly();
        }
    }
}
