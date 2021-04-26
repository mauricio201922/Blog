using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models
{
    [Table("contato")]
    public class Contato
    {
        [Key]
        [Column("id")]
        public int id { get; set; }

        [Column("nome")]
        public string nome { get; set; }

        [Column("email")]
        public string email { get; set; }

        [Column("tel")]
        public string telelefone { get; set; }
        
    }
}