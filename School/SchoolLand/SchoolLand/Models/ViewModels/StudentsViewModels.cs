using System.ComponentModel.DataAnnotations;

namespace SchoolLand.Models.ViewModels
{
    public class StudentsViewModels
    {
        [Required]
        [Display(Name = "id")]
        public int StudentId { get; set; }
        [Required]
        [Display(Name = "Nombre")]
        public string NameStudent { get; set; }
        [Required]
        [Display(Name = "Apellido")]
        public string Lastname { get; set; }
        [Required]
        [Display(Name = "Carnet")]
        public string Carnet { get; set; }
        [Required]
        [Display(Name = "Correo")]
        public string Correo { get; set; }
        [Required]
        [Display(Name = "Pass")]
        public string Pass { get; set; }
    }
}
