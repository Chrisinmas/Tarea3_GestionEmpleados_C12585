using System.ComponentModel.DataAnnotations;

namespace Tarea3_GestionEmpleados_C12585.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(80, ErrorMessage = "El nombre no puede superar 80 caracteres.")]
        [Display(Name = "Nombre")]
        public string Nombre { get; set; } = string.Empty;

        [Required(ErrorMessage = "Los apellidos son obligatorios.")]
        [StringLength(100, ErrorMessage = "Los apellidos no pueden superar 100 caracteres.")]
        [Display(Name = "Apellidos")]
        public string Apellidos { get; set; } = string.Empty;

        [Required(ErrorMessage = "El departamento es obligatorio.")]
        [Display(Name = "Departamento")]
        public string Departamento { get; set; } = string.Empty;

        [Required(ErrorMessage = "El salario es obligatorio.")]
        [Range(400000, 10000000, ErrorMessage = "El salario debe estar entre ₡400,000 y ₡10,000,000.")]
        [Display(Name = "Salario")]
        public decimal Salario { get; set; }

        [Display(Name = "Fecha de Ingreso")]
        public DateTime FechaIngreso { get; set; }

        [Display(Name = "Activo")]
        public bool Activo { get; set; }

        public string NombreCompleto => $"{Nombre} {Apellidos}";
    }
}