using lista7.Models;

namespace lista7.Repository
{
    public class NotaAlunoRepository : INotaAlunoRepository
    {
        private readonly List<NotaAluno> _notas = new List<NotaAluno>();

        public void Adicionar(NotaAluno nota, IDisciplinaRepository disciplinaRepo)
        {
            _notas.Add(nota);
        }

        public IEnumerable<NotaAluno> ObterTodas() => _notas;

        public IEnumerable<NotaAluno> ObterPorAluno(string raAluno)
        {
            return _notas.Where(n => n.RaAluno == raAluno);
        }
    }

}
