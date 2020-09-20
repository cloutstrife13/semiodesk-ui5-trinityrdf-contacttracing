using ContactTracingGraph.Models;
using ContactTracingGraph.Supports;
using Microsoft.AspNet.OData.Builder;
using Microsoft.OData.Edm;

namespace ContactTracingGraph.Configurations
{
    public class ODataConfig
    {
        public static IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder();
            SetEntitySets(builder);

            var tnt = builder.EntityType<ODataResource>();
            SuppressTrinityRdf(tnt);
            ActivateODataMethods(tnt);
            return builder.GetEdmModel();
        }

        private static void SetEntitySets(ODataModelBuilder b)
        {
            b.EntitySet<Person>("Person");
            b.EntitySet<Encounter>("Encounter");
            b.EntitySet<InfectiousDisease>("InfectiousDisease");
            b.EntitySet<Place>("Place");
        }

        private static void SuppressTrinityRdf<T>(EntityTypeConfiguration<T> entity) where T : ODataResource
        {
            entity.Ignore(v => v.IsDisposed);
            entity.Ignore(v => v.IsNew);
            entity.Ignore(v => v.IsBlank);
            entity.Ignore(v => v.IsSynchronized);
            entity.Ignore(v => v.Language);
            entity.Ignore(v => v.Model);
            entity.Ignore(v => v.Uri);
        }

        private static void ActivateODataMethods<T>(EntityTypeConfiguration<T> entity) where T : ODataResource
        {
            var aSubmitDiagnosis = entity.Collection.Action("SubmitDiagnosis");
            aSubmitDiagnosis.Parameter<string>("ID");
            aSubmitDiagnosis.ReturnsFromEntitySet<InfectiousDisease>("InfectiousDisease");

            var aReportEncounter = entity.Collection.Action("RecordEncounter");
            aReportEncounter.CollectionParameter<string>("UserIds");
            aReportEncounter.Parameter<string>("LocationId");
            aReportEncounter.ReturnsFromEntitySet<Encounter>("Encounter");
        }
    }
}
