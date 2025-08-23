using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBlazor.Entities
{
    public class EmpleadoListCLS
    {
        public int Num_empleado { get; set; }
        public int edad { get; set; }
        public string Nombre { get; set; } = null!;
        public string Cargo { get; set; } = null!;
        public DateTime fechaEmpleado { get; set; }
        public int Cuota { get; set; }
        public int Ventas { get; set; }

    }
}
