using CWA_Graph.Models;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

namespace CWA_Graph.Configurations
{
    public class ODataConfig
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            SetEntitySets(builder);

            var tnt = builder.EntityType<ODataResource>();
            SuppressTrinityRdf(tnt);

            return builder.GetEdmModel();
        }

        private static void SetEntitySets(ODataModelBuilder b)
        {
            b.EntitySet<User>("User");
        }

        private static void SuppressTrinityRdf<T>(EntityTypeConfiguration<T> entity) where T : ODataResource
        {
            entity.Ignore(v => v.IsDisposed);
            entity.Ignore(v => v.IsNew);
            entity.Ignore(v => v.IsSynchronized);
            entity.Ignore(v => v.Language);
            entity.Ignore(v => v.Model);
            entity.Ignore(v => v.Uri);
        }
    }
}
