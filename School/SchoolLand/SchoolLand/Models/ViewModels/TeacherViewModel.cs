using System.ComponentModel.DataAnnotations;

namespace SchoolLand.Models.ViewModels
{
    public class TeacherViewModel
    {
        [Required]
        [Display (Name = "id")]
        public int IdTeacher { get; set; }
        [Required]
        [Display (Name = "Nombre Maestro ")]
        public string NameTeacher { get; set; } = null!;
        [Required]
        [Display (Name = "Edad")]
        public string Age { get; set; } = null!;
        [Required]
        [Display (Name = "Telefono")]
        public string Phone { get; set; } = null!;
        [Required]
        [Display (Name = "Carnet")]
        public string Carnet { get; set; } = null!;
        [Required]
        [Display (Name = "Años en la Escuela")]
        public string YearsSchool { get; set; } = null!;
    }
}
