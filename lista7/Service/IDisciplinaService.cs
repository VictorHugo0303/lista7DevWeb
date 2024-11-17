using lista7.Models;

namespace lista7.Service
{
    public interface IDisciplinaService
    {
        void CriarDisciplina(Disciplina disciplina);
        IEnumerable<Disciplina> ObterTodas();
    }
}
