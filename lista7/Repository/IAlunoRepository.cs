using lista7.Models;

namespace lista7.Repository
{
    public interface IAlunoRepository
    {
        void Adicionar(Aluno aluno);
        IEnumerable<Aluno> ObterTodos();
        Aluno ObterPorRA(string ra);
    }

}
