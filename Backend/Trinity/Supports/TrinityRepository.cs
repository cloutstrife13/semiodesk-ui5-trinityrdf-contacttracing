using ContactTracingGraph.Queries;
using Semiodesk.Trinity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactTracingGraph.Supports
{
    public class TrinityRepository<T> where T : ODataResource
    {
        private readonly IModel vts;
        private readonly SparqlQueryManager sqm;

        public TrinityRepository(IModel virtuoso)
        {
            vts = virtuoso;
            sqm = new SparqlQueryManager();
        }

        #region Standard Read methods
        public List<T> Read() => vts.GetResources<T>(true).ToList();
        public List<X> Read<X>() where X : ODataResource => vts.GetResources<X>(true).ToList();
        public T Read(string id) => GetSingleInstance<T>(id);
        public X Read<X>(string id) where X : ODataResource => GetSingleInstance<X>(id);
        #endregion
        #region Enhanced Read methods with SPARQL queries
        public List<T> ReadQuery(string queryAlias) =>
            vts.GetResources<T>(sqm.GetQuery(queryAlias), true).ToList();
        public List<X> ReadQuery<X>(string queryAlias) where X : ODataResource =>
            vts.GetResources<X>(sqm.GetQuery(queryAlias), true).ToList();
        public T ReadQuery(string queryAlias, string id) =>
            vts.ContainsResource(GetUriById(id)) ?
            GetSingleInstanceFromQuery<T>(queryAlias, id) : null;
        public X ReadQuery<X>(string queryAlias, string id) where X : ODataResource =>
            vts.ContainsResource(GetUriById(id)) ?
            GetSingleInstanceFromQuery<X>(queryAlias, id) : null;
        #endregion
        public T Create(T Obj)
        {
            if (!vts.ContainsResource(Obj))
            {
                vts.AddResource(Obj);
                return vts.GetResource<T>(Obj.Uri);
            }

            return null;
        }
        public T Update(T Obj)
        {
            if (vts.ContainsResource(Obj))
            {
                Obj.IsNew = false;
                vts.UpdateResource(Obj);
                return vts.GetResource<T>(Obj.Uri);
            }

            return null;
        }
        public bool Delete(string id)
        {
            Uri uri = GetUriById(id);
            if (vts.ContainsResource(uri))
            {
                vts.DeleteResource(uri);
                return true;
            }

            return false;
        }
        private Uri GetUriById(string id)
        {
            return new Uri($"{CRT.Namespace}{id}");
        }
        private TX GetSingleInstance<TX>(string id) where TX : ODataResource
        {
            Uri uri = GetUriById(id);
            return (!vts.ContainsResource(uri)) ? null : vts.GetResource<TX>(uri);
        }
        private TX GetSingleInstanceFromQuery<TX>(string queryAlias, string id) where TX : ODataResource
        {
            List<TX> obj = vts.GetResources<TX>(sqm.GetQuery(queryAlias, id), true).ToList();
            return (obj.Count == 1) ? obj.First() : null;
        }
    }
}
