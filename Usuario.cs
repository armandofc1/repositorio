using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RepositoryPattern
{
    [Table("Usuario")]
    public class Usuario : Entidade
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column("CD_USUARIO")]
        public int id {get;set;}

        [Required(ErrorMessage = "Nome é obrigatório")]
        [Column("NOME")]
        public string Nome { get; set; }

        [Column("SOBRENOME")]
        public string Sobrenome { get; set; }

        [Column("APELIDO")]
        public string Apelido { get; set; }

        [Column("EMAIL")]
        public string Email { get; set; }

        [Column("DT_INCLUSAO")]
        public DateTime DataInclusao { get; set; }
    }
}