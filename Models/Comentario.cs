

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Teste.Models{
    [Table("comentario")]
    public class Comentario{

        // Banco de dados entregando dados a coluna de id
        [Display(Name = "id")]
        [Column("id")]
        public int id { get; set; }

        // Banco de dados entregando dados a coluna de nome
        [Display(Name = "nome")]
        [Column("nome")]
        public string nome{ get; set; }

        // Banco de dados entregando dados a coluna de comenta
        [Display(Name = "comenta")]
        [Column("comenta")]
        public string comenta { get; set; }
    }
}