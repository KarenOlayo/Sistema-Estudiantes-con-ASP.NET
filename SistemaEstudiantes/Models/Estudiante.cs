using System.ComponentModel.DataAnnotations;

namespace SistemaEstudiantes.Models
{
    public class Estudiante
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        [Display(Name = "Nombre")]
        [StringLength(100)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "El apellido es obligatorio")]
        [Display(Name = "Apellido")]
        [StringLength(100)]
        public string Apellido { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress(ErrorMessage = "Ingrese un correo válido")]
        public string Correo { get; set; }

        [Required(ErrorMessage = "El programa es obligatorio")]
        [Display(Name = "Programa Académico")]
        public string Programa { get; set; }

        [Required(ErrorMessage = "El semestre es obligatorio")]
        [Display(Name = "Semestre")]
        [Range(1, 10, ErrorMessage = "El semestre debe estar entre 1 y 10")]
        public int Semestre { get; set; }

        [Display(Name = "Fecha de Matrícula")]
        [DataType(DataType.Date)]
        public DateTime FechaMatricula { get; set; }
    }
}