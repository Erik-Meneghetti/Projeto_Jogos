//Caminho em que a classe Jogo esta
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Index = Microsoft.EntityFrameworkCore.Metadata.Internal.Index;

namespace Projeto__jogos.Domains
{
    [Table("Jogo")]
    //O Index faz com que o nome do jogo Nao se repita
    [Index(nameof(NomeDoJogo), IsUnique = true)]
    //Public class -> Cria uma classe publica
    public class Jogo
    {
        //Preencher os atributos
        [Key]
        public Guid JogoID { get; set; }

        [Column(TypeName = "VARCHAR (50)")]
        //O required faz com que seja obrigatorio preencher o campo NomeDoJogo
        [Required(ErrorMessage = "O nome do jogo e obrigatorio")]
        public string? NomeDoJogo { get; set; }

        [Column(TypeName = "VARCHAR (50)")]
        public string? Plataforma { get; set; }
    }
}
    
