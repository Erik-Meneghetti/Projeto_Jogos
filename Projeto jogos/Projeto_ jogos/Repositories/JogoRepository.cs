using Projeto__jogos.Context;
using Projeto__jogos.Domains;
using Projeto__jogos.Interface;

namespace Projeto__jogos.Repositories
{
    public class JogoRepository : IjogoRepository
    {
        //Herdar da Interface
        //Implementar os metodos da Interface
        //Criar a variavel que puxa informações do Context
        private readonly ProjetoJogoContext _context;

        public JogoRepository(ProjetoJogoContext context)
        {
            _context = context;
        }

        public void Atualizar(Guid idDoJogo, Jogo jogoAtualizado)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Jogo jogoNovo)
        {
            try
            {
                jogoNovo.JogoID = Guid.NewGuid();


                _context.Jogo.Add(jogoNovo);

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





