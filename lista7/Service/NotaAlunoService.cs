using lista7.Models;
using lista7.Repository;
using lista7.Service;

public class NotaAlunoService : INotaAlunoService
{
    private readonly NotaAlunoRepository _repo;

    public NotaAlunoService(NotaAlunoRepository repo)
    {
        _repo = repo;
    }

    public void InserirNota(NotaAluno nota, DisciplinaRepository disciplinaRepo)
    {
        if (!_repo.ObterTodas().Any(n => n.RaAluno == nota.RaAluno && n.IdDisciplina == nota.IdDisciplina))
        {
            var disciplinaExiste = disciplinaRepo.ObterTodas().Any(d => d.IdDisciplina == nota.IdDisciplina);
            if (!disciplinaExiste)
                throw new Exception("A disciplina não existe.");
            _repo.Adicionar(nota, disciplinaRepo);
        }
        else
        {
            throw new Exception("Já existe uma nota para este aluno nesta disciplina.");
        }
    }

    public IEnumerable<NotaAluno> ListarAlunosAprovados()
    {
        return _repo.ObterTodas().Where(n => n.Nota >= 7 && n.Frequencia >= 75);
    }

    public IEnumerable<NotaAluno> ListarAlunosReprovados()
    {
        return _repo.ObterTodas().Where(n => n.Nota < 7 || n.Frequencia < 75);
    }
}
