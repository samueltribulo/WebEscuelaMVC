using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using WebEscuelaMVC.Validations;
namespace WebEscuelaMVC.Models
{
    [Table("Aula")]
    public class Aula
    {
        public int Id { get; set; }
        [Required]
        [MayorACienValidation]
        public int Numero { get; set; }
        [Required(ErrorMessage = "El estado debe contener entre 1 y 50 caracteres")]
        [Column(TypeName = "varchar(50)")]
        public string Estado { get; set; }

    }
}
