using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class EmpleadoFormCLS
    {
        //Num_Empleado
        [Required(ErrorMessage ="El Numero de Empleado es requerido")]
        public int Num_Empleado { get; set; }
        //Nombre
        [Required(ErrorMessage ="El Nombre es requerido")]
        [MaxLength]
        public string Nombre { get; set; } = null!;
        //Edad
        [Range(18,int.MaxValue,ErrorMessage ="El valor deber ser mayor o igual a 18")]
        public int Edad { get; set; }
        //Cargo
        [Required(ErrorMessage ="El Cargo es requerido")]
        public string Cargo { get; set; }=null!;
        //Fecha_de_Contrato
        [Required(ErrorMessage ="La Fecha es requerida")]
        
        public DateTime Fecha_de_Contrato { get; set; }
        //Cuota
        [Required(ErrorMessage ="La Cuota es requerido")]
        public int Cuota { get; set; }
        //Ventas
        [Required(ErrorMessage ="Las Ventas son requeridas")]
        public int Ventas { get; set; }
    }
}
