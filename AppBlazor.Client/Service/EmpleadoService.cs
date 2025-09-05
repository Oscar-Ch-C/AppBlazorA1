using AppBlazor.Client.Service;
using AppBlazor.Entities;


namespace AppBlazor.Client.Service
{
    public class EmpleadoService
    {
        private List<EmpleadoListCLS> lista;
        private TipoCiudadService tipoCiudadService;
        private TipoJefeService tipoJefeService;
        
        public EmpleadoService(TipoCiudadService _tipociudadservice, TipoJefeService _tipojefeservice)
        {
            tipoCiudadService= _tipociudadservice;
            tipoJefeService= _tipojefeservice;
               
            lista = new List<EmpleadoListCLS>();
            lista.Add(new EmpleadoListCLS{
                Num_empleado = 1,
                Nombre = "Juan",
                edad = 25,
                Cargo = "Desarrollador",
                nombretipociudad="La Paz",
                nombretipojefe="Rodrigo",
                fechaEmpleado = DateTime.Now,
                Cuota = 1000,
                Ventas = 2000,
            });
        }
        public List<EmpleadoListCLS> listarEmpleados()
        {
            return lista;
        }

        public void eliminarEmpleado(int Num_empleado)
        {
            var listaQueda = lista.Where(p=> p.Num_empleado != Num_empleado).ToList();
            lista=listaQueda;
            
        }


        public EmpleadoFormCLS recuperarEmpleadoPorId(int Num_empleado)
        {
            var obj = lista.Where(p => p.Num_empleado == Num_empleado).FirstOrDefault();
            if (obj != null)
            {
                return new EmpleadoFormCLS { Num_Empleado = obj.Num_empleado, Nombre = obj.Nombre, Edad=obj.edad, Cargo=obj.Cargo, idtipociudad=tipoCiudadService.obtenerIdTipoCiudad(obj.nombretipociudad),
                    idtipojefe=tipoJefeService.obtenerIdTipoJefe(obj.nombretipojefe),Fecha_de_Contrato=obj.fechaEmpleado, Cuota=obj.Cuota,Ventas=obj.Ventas};
            }
            else
            {
                return new EmpleadoFormCLS();
            }
        }
        public void guardarEmpleado(EmpleadoFormCLS oEmpleadoFormCLS)
        {
            int Num_empleado = lista.Select(p => p.Num_empleado).Max() + 1;
            lista.Add(new EmpleadoListCLS { Num_empleado = Num_empleado, Nombre=oEmpleadoFormCLS.Nombre, edad=oEmpleadoFormCLS.Edad, Cargo=oEmpleadoFormCLS.Cargo,
                nombretipojefe=tipoJefeService.obtenerNombreTipoJefe(oEmpleadoFormCLS.idtipojefe),
                nombretipociudad = tipoCiudadService.obtenerNombreTipoCiudad(oEmpleadoFormCLS.idtipociudad),
                fechaEmpleado = (DateTime)oEmpleadoFormCLS.Fecha_de_Contrato,
                Cuota = (int)oEmpleadoFormCLS.Cuota,
                Ventas = (int)oEmpleadoFormCLS.Ventas
            });
        }


    }
}
