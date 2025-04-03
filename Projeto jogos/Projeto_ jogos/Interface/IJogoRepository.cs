using Projeto__jogos.Domains;

namespace Projeto__jogos.Interface
{
    public interface IjogoRepository
    {
        void Cadastrar(Jogo jogoNovo);
        List<Jogo> Listar();
        void Deletar(Guid idDoJogo);
        void Atualizar(Guid idDoJogo, Jogo jogoAtualizado );
    }
}
