using Semiodesk.Trinity;
using Semiodesk.Trinity.Store.Virtuoso;
using System;
using System.IO;
using System.Reflection;

namespace CWA_Graph.Configurations
{
    public class DbContext
    {
        private string connectionString = "provider=virtuoso;host=localhost;port=1111;uid=dba;pw=dba;rule=urn:example/ruleset";
        private Uri defaultModelUri = CWA.Namespace;
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

            if (Store.GetModel(defaultModelUri).IsEmpty)
                Store.InitializeFromConfiguration(Path.Combine(Environment.CurrentDirectory, "ontologies.config"));

            OntologyDiscovery.AddAssembly(Assembly.GetExecutingAssembly());
            MappingDiscovery.RegisterCallingAssembly();
        }
    }
}
