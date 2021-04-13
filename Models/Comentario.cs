using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models{
    [Table("comentario")]
    public class Comentario{

        // Banco de dados entregando dados a coluna de id
        [Key]
        [Display(Name = "id")]
        [Column("id")]
        public int id { get; set; }

        // Banco de dados entregando dados a coluna de nome
        [Required]
        [Display(Name = "nome")]
        [Column("nome")]
        public string nome{ get; set; }

        // Banco de dados entregando dados a coluna de comenta
        [Required]
        [Display(Name = "comenta")]
        [Column("comentarios")]
        public string comenta { get; set; }
    }
}