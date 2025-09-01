using AppBlazor.Entities;


namespace AppBlazor.Client.Service
{
    public class EmpleadoService
    {
        private List<EmpleadoListCLS> lista;
        public EmpleadoService()
        {
            lista = new List<EmpleadoListCLS>();
            lista.Add(new EmpleadoListCLS{
                Num_empleado = 1,
                Nombre = "Juan",
                edad = 25,
                Cargo = "Desarrollador",
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
                return new EmpleadoFormCLS { Num_Empleado = obj.Num_empleado, Nombre = obj.Nombre, Edad=obj.edad, Cargo=obj.Cargo, Fecha_de_Contrato=obj.fechaEmpleado, Cuota=obj.Cuota,Ventas=obj.Ventas};
            }
            else
            {
                return new EmpleadoFormCLS();
            }
        }
        public void guardarEmpleado(EmpleadoFormCLS oEmpleadoFormCLS)
        {
            lista.Add(new EmpleadoListCLS { Num_empleado = oEmpleadoFormCLS.Num_Empleado, Nombre=oEmpleadoFormCLS.Nombre });
        }


    }
}
