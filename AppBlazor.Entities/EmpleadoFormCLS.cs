using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class EmpleadoFormCLS
    {
        //Num_Empleado
        [Required(ErrorMessage ="El número de empleado es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El número de empleado debe ser positivo")]
        public int? Num_Empleado { get; set; }
        //Nombre
        [Required(ErrorMessage ="El nombre es requerido")]
        [MaxLength]
        public string Nombre { get; set; } = null!;
        //Edad
        [Range(18, int.MaxValue, ErrorMessage = "La edad debe ser mayor o igual a 18")]
        public int? Edad { get; set; }

        //Cargo
        [Required(ErrorMessage ="El cargo es requerido")]
        public string Cargo { get; set; }=null!;
        //Fecha_de_Contrato
        [Required(ErrorMessage ="La fecha de contrato es requerida")]
        public DateTime? Fecha_de_Contrato { get; set; }

        //Cuota
        [Required(ErrorMessage ="La cuota es requerida")]
        public int? Cuota { get; set; }

       
        //Ventas
        [Required(ErrorMessage ="Las ventas son requeridas")]
        public int? Ventas { get; set; }
    }
}
