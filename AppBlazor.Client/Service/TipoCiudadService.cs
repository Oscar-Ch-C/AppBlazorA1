using AppBlazor.Entities;
namespace AppBlazor.Client.Service
{
    public class TipoCiudadService
    {
        private List<TipoCiudadCLS> lista;
        public TipoCiudadService()
        {
            lista = new List<TipoCiudadCLS>();
            lista.Add(new TipoCiudadCLS() { idtipociudad=1, nombretipociudad="La Paz" });
            lista.Add(new TipoCiudadCLS() { idtipociudad=2, nombretipociudad="Cochabamba" });
            lista.Add(new TipoCiudadCLS() { idtipociudad=2, nombretipociudad="Santa Cruz" });
        }

        public List<TipoCiudadCLS> listarTipoCiudad()
        {
            return lista;
        }

        public int obtenerIdTipoCiudad(string nombretipociudad)
        {
            var obj = lista.Where(p => p.nombretipociudad == nombretipociudad).FirstOrDefault();
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return obj.idtipociudad;
            }
        }

        public string obtenerNombreTipoCiudad(int idtipociudad)
        {
            var obj = lista.Where(p => p.idtipociudad == idtipociudad).FirstOrDefault();
            if (obj == null)
            {
                return "";
            }
            else
            {
                return obj.nombretipociudad;
            }
        }
    }
}
