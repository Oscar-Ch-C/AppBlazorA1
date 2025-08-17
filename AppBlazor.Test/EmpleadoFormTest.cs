using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using AppBlazor.Entities;
using Xunit;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AppBlazor.Test

{
    public class EmpleadoFormTest
    {
        private List<ValidationResult> ValidarModelo(object modelo)
        {
            var resultados = new List<ValidationResult>();
            var contexto = new ValidationContext(modelo,null,null);
            Validator.TryValidateObject(modelo, contexto, resultados, true);
            return resultados;
        }
        [Fact]
        public void ValidarCamposVacios()
        {
            var empleado = new EmpleadoFormCLS();
            var errores = ValidarModelo(empleado);

            //Numero de empleado
            Assert.Contains(errores,e=> e.ErrorMessage!.Contains("El número de empleado es requerido")|| 
            e.ErrorMessage!.Contains("El número de empleado debe ser positivo"));


            //Nombre
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El nombre es requerido"));

         

            //Cargo
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("El cargo es requerido"));

            //Fecha_de_Contrato
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La fecha de contrato es requerida"));

            //Cuota
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("La cuota es requerida"));

            //Ventas
            Assert.Contains(errores, e => e.ErrorMessage!.Contains("Las ventas son requeridas"));

            
        }
        [Fact]
        public void ValidacionConDatosCorrectos()
        {
            var empleado = new EmpleadoFormCLS
            {
                Num_Empleado = 1,
                Nombre = "Juan",
                Edad = 25,
                Cargo = "Desarrollador",
                Fecha_de_Contrato = DateTime.Now,
                Cuota = 1000,
                Ventas = 2000,

            };
            var errores = ValidarModelo(empleado);
            Assert.Empty(errores);

        }
    }
}