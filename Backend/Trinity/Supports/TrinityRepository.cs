using Semiodesk.Trinity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ContactTracingGraph.Supports
{
    public class TrinityRepository<T> where T : ODataResource
    {
        private readonly IModel vts;

        public TrinityRepository(IModel virtuoso)
        {
            vts = virtuoso;
        }

        public List<T> Read() => vts.GetResources<T>(true).ToList();

        public List<X> Read<X>() where X : ODataResource => vts.GetResources<X>(true).ToList();

        public List<T> Read(SparqlQuery q) => vts.GetResources<T>(q, true).ToList();

        public List<X> Read<X>(SparqlQuery q) where X : ODataResource => vts.GetResources<X>(q, true).ToList();

        public T Read(string id)
        {
            Uri uri = new Uri($"{CRT.Namespace}{id}");
            return (!vts.ContainsResource(uri)) ? null : vts.GetResource<T>(uri);
        }

        public X Read<X>(string id) where X : ODataResource
        {
            Uri uri = new Uri($"{CRT.Namespace}{id}");
            return (!vts.ContainsResource(uri)) ? null : vts.GetResource<X>(uri);
        }

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

        public bool Delete(Uri ObjUri)
        {
            if (vts.ContainsResource(ObjUri))
            {
                vts.DeleteResource(ObjUri);
                return true;
            }

            return false;
        }
    }
}
