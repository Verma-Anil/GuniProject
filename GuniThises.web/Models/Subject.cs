using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GuniThises.web.Models
{
    public class Subject
    {
        [Display(Name = "Subject ID")]
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]

        public short SubjectId { get; set; }

        [Display(Name = "Name of the Subject")]

        [Required]
        public string SubjectName { get; set; }
    }
}
