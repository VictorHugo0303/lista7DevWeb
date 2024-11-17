using lista7.Models;
using lista7.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lista7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DisciplinaController : ControllerBase
    {
        private readonly IDisciplinaService _disciplinaService;

        public DisciplinaController(IDisciplinaService disciplinaService)
        {
            _disciplinaService = disciplinaService;
        }

        public void CriarDisciplina(Disciplina disciplina)
        {
            try
            {
                _disciplinaService.CriarDisciplina(disciplina);
                Console.WriteLine("Disciplina criada com sucesso.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro: {ex.Message}");
            }
        }

        public void ListarDisciplinas()
        {
            var disciplinas = _disciplinaService.ObterTodas();
            foreach (var disciplina in disciplinas)
            {
                Console.WriteLine($"ID: {disciplina.IdDisciplina}, Nome: {disciplina.Nome}, Curso: {disciplina.Curso}");
            }
        }
    }
}
