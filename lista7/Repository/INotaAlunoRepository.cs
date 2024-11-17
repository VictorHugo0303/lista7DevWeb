using lista7.Models;

namespace lista7.Repository
{
    public interface INotaAlunoRepository
    {

        void Adicionar(NotaAluno nota, IDisciplinaRepository disciplinaRepo);
        IEnumerable<NotaAluno> ObterTodas();
        IEnumerable<NotaAluno> ObterPorAluno(string raAluno);
    }

}
