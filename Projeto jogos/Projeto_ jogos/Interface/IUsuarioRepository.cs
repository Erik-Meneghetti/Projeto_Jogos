using Projeto__jogos.Domains;

namespace Projeto__jogos.Interface
{
    public interface IUsuarioRepository
    {
        void Cadastrar(Usuario usuarioNovo);
        List<Usuario> Listar();
        void Deletar(Guid idDoUsuario);
        void Atualizar(Guid idDoUsuario, Usuario usuarioAtualizado);
        
    }
}
