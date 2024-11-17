using lista7.Models;

namespace lista7.Repository
{
    public interface IDisciplinaRepository
    {
        void Adicionar(Disciplina disciplina);
        IEnumerable<Disciplina> ObterTodas();
        Disciplina ObterPorId(int id);
    }

}
