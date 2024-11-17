using lista7.Models;
using lista7.Repository;

namespace lista7.Service
{
    public interface INotaAlunoService
    {
        void InserirNota(NotaAluno nota, DisciplinaRepository disciplinaRepo);
        IEnumerable<NotaAluno> ListarAlunosAprovados();
        IEnumerable<NotaAluno> ListarAlunosReprovados();
    }

}
