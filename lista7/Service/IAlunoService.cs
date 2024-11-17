using lista7.Models;

namespace lista7.Service
{
    public interface IAlunoService
    {
        void AdicionarAluno(Aluno aluno);
        IEnumerable<Aluno> ObterTodos();
    }

}
