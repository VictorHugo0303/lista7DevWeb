using lista7.Models;

namespace lista7.Repository
{
    public class AlunoRepository : IAlunoRepository
    {
        private readonly List<Aluno> _alunos = new List<Aluno>();

        public void Adicionar(Aluno aluno)
        {
            if (_alunos.Any(a => a.RA == aluno.RA))
                throw new Exception("Já existe um aluno com este RA.");
            _alunos.Add(aluno);
        }

        public IEnumerable<Aluno> ObterTodos() => _alunos;

        public Aluno ObterPorRA(string ra)
        {
            return _alunos.FirstOrDefault(a => a.RA == ra);
        }
    }

}
