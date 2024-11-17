using lista7.Models;

namespace lista7.Repository
{
    public class DisciplinaRepository : IDisciplinaRepository
    {
        private readonly List<Disciplina> _disciplinas = new List<Disciplina>();

        public void Adicionar(Disciplina disciplina)
        {
            if (_disciplinas.Any(d => d.Nome == disciplina.Nome))
                throw new Exception("Já existe uma disciplina com este nome.");
            _disciplinas.Add(disciplina);
        }

        public IEnumerable<Disciplina> ObterTodas() => _disciplinas;

        public Disciplina ObterPorId(int id)
        {
            return _disciplinas.FirstOrDefault(d => d.IdDisciplina == id);
        }
    }
}
