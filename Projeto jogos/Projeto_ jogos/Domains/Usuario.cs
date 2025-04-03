using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
namespace Projeto__jogos.Domains
{
    [Table("Usuario")]
    [Index(nameof(NickName), IsUnique = true)]
    public class Usuario
    {
        [Key]
         public Guid UsuarioID { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage = "O nome do usuario e obrigatorio!")]
        public string? Nome { get; set; }

        [Column(TypeName = "VARCHAR(50)")]
        [Required(ErrorMessage ="O NickName do usuario e obrigatorio!")]
        public string? NickName { get; set; }

        public Guid JogoFavorito { get; set; }

        [ForeignKey("JogoFavorito")]
        public Jogo? Jogo { get; set; }
        
    }
}
