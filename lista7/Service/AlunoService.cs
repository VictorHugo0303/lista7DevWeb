using lista7.Models;
using lista7.Repository;
using lista7.Service;

public class AlunoService : IAlunoService
{
    private readonly IAlunoRepository _repo;

    public AlunoService(IAlunoRepository repo)
    {
        _repo = repo;
    }

    public void AdicionarAluno(Aluno aluno)
    {
        if (_repo.ObterTodos().Any(a => a.RA == aluno.RA))
            throw new Exception("Já existe um aluno com este RA.");
        _repo.Adicionar(aluno);
    }

    public IEnumerable<Aluno> ObterTodos() => _repo.ObterTodos();
}
