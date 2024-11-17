using lista7.Repository;
using lista7.Models;

namespace lista7.Service
{
    public class DisciplinaService : IDisciplinaService
    {
        private readonly DisciplinaRepository _repo;

        public DisciplinaService(DisciplinaRepository repo)
        {
            _repo = repo;
        }

        public void CriarDisciplina(Disciplina disciplina)
        {
            if (_repo.ObterTodas().Any(d => d.Nome == disciplina.Nome))
                throw new Exception("Já existe uma disciplina com este nome.");
            _repo.Adicionar(disciplina);
        }

        public IEnumerable<Disciplina> ObterTodas() => _repo.ObterTodas();
    }

}
