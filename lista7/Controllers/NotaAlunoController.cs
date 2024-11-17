using lista7.Repository;
using lista7.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace lista7.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotaAlunoController : ControllerBase
    {
        private readonly INotaAlunoService _notaAlunoService;
        private readonly IDisciplinaRepository _disciplinaRepository;

        public NotaAlunoController(INotaAlunoService notaAlunoService, IDisciplinaRepository disciplinaRepository)
        {
            _notaAlunoService = notaAlunoService;
            _disciplinaRepository = disciplinaRepository;
        }
    }
}
