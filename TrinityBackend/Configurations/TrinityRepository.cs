using Semiodesk.Trinity;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CWA_Graph.Configurations
{
    public class TrinityRepository<T> where T : ODataResource
    {
        private readonly IModel vts;

        public TrinityRepository(IModel virtuoso)
        {
            vts = virtuoso;
        }

        public List<T> Read()
        {
            return vts.GetResources<T>(true)
                      .ToList();
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
