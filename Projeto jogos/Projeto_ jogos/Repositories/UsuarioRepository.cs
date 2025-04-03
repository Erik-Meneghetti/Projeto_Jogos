using Microsoft.EntityFrameworkCore;
using Projeto__jogos.Domains;
using Projeto__jogos.Interface;

namespace Projeto__jogos.Repositories
{
    public class UsuarioRepository : IjogoRepository
    {
        public void Atualizar(Guid idDoJogo, Jogo jogoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Usuario usuarioNovo)
        {
            try
            {
                novo Usuario.UsuarioID = Guid.NewGuid();
                _context..Add();

                _context.SaveChanges();
            }
            catch (Exception)
            {

                throw;
            }
        }
        public void Deletar(Guid idDoJogo)
        {
            throw new NotImplementedException();
        }

        public List<Jogo> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
