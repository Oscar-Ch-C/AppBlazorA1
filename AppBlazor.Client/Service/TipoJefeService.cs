using AppBlazor.Entities;
namespace AppBlazor.Client.Service
   
{
    public class TipoJefeService
    {
        private List<TipoJefeCLS> lista;
        public TipoJefeService()
        {
            lista = new List<TipoJefeCLS>();
            lista.Add(new TipoJefeCLS() { idtipojefe = 1, nombretipojefe = "Rodrigo" });
            lista.Add(new TipoJefeCLS() { idtipojefe = 2 , nombretipojefe = "Oscar" });
        }

        public List<TipoJefeCLS> listarTipoJefe()
        {
            return lista;
        }
        public int obtenerIdTipoJefe(string nombretipojefe)
        {
            var obj = lista.Where(p => p.nombretipojefe == nombretipojefe).FirstOrDefault();
            if (obj==null)
            {
                return 0;
            }
            else
            {
                return obj.idtipojefe;
            }
        }
        public string obtenerNombreTipoJefe(int idtipojefe)
        {
            var obj = lista.Where(p => p.idtipojefe == idtipojefe).FirstOrDefault();
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.nombretipojefe;
            }
        }
    }
}
