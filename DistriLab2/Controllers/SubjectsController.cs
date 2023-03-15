using DistriLab2.Models;
using DistriLab2.Models.DB;
using Microsoft.AspNetCore.Mvc;

namespace DistriLab2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectsController : ControllerBase
    {

        private readonly ILogger<SubjectsController> _logger;
        private readonly dblab2Context _context;


        public SubjectsController(ILogger<SubjectsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("getSubject")]
        public ActionResult<Subject> getSubject()
        {
            var client = _context.Subjects.ToList();
            return Ok(client);
        }

        [HttpGet]
        [Route("getSubjectById/{CodSubject}")]
        public ActionResult<Subject> getSubjectById(int CodSubject)
        {
            var client = _context.Subjects.FindAsync(CodSubject);
            return Ok(client);
        }

        [HttpPost]
        [Route("addSubject")]
        public async Task<IActionResult> AddSubject(Subject subject)
        {
            Subject subAux = new()
            {
               
                CodSubject = subject.CodSubject,
                NameSubject = subject.NameSubject,
                Quotas = subject.Quotas,
                StatusSubject = subject.StatusSubject

            };
            Subject add= _context.Subjects.Add(subAux).Entity;

            await _context.SaveChangesAsync();
            return Created($"/Student/{subAux.CodSubject}", subAux);
        }

        [HttpPut()]
        [Route("updateSubject")]
        public async Task<IActionResult> Put(Subject subject)
        {
            var update = await _context.Subjects.FindAsync(subject.CodSubject);

            if (update == null)
                return BadRequest();

            update.CodSubject = subject.CodSubject;
            update.NameSubject = subject.NameSubject;
            update.Quotas = subject.Quotas;
            update.StatusSubject = subject.StatusSubject;

            var aux = await _context.SaveChangesAsync() > 0;
            if (!aux)
            {
                return NoContent();
            }
            return Ok(update);
        }
    }
}