using System;
using System.ComponentModel.DataAnnotations;

namespace GuniThises.web.ViewModels
{
    public class FacultyViewModel
    {
        [Key]
        [Display(Name = "Faculty User ID")]
        [Required]
        public Guid FacultyUserId { get; set; }


        [Display(Name = "Date of Birth")]
        [Required]
        public DateTime DateOfBirth { get; set; }

        [Display(Name = "Type of Faculty")]
        [Required(ErrorMessage = "{0} cannot be empty.")]
        [MinLength(3, ErrorMessage = "{0} should have more than {1} characters.")]
        [StringLength(25, ErrorMessage = "{0} cannot contain more than {1} characters.")]
        public string FacultyType { get; set; }

    }
}
