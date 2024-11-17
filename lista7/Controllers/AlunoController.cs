using lista7.Models;
using lista7.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lista7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly IAlunoService _alunoService;

        public AlunoController(IAlunoService alunoService)
        {
            _alunoService = alunoService;
        }

        public void CriarAluno(Aluno aluno)
        {
            try
            {
                _alunoService.AdicionarAluno(aluno);
                Console.WriteLine("Aluno adicionado com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        public void ListarAlunos()
        {
            var alunos = _alunoService.ObterTodos();
            foreach (var aluno in alunos)
            {
                Console.WriteLine($"RA: {aluno.RA}, Nome: {aluno.Nome}");
            }
        }
    }
}
