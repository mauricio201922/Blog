using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models
{
    [Table("login")]
    public class Login
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Required]
        [Display(Name = "nome")]
        [Column("nome")]
        public string nome { get; set; }

        [Required]
        [Display(Name = "senha")]
        [Column("senha")]
        public string senha { get; set; }
    }
}