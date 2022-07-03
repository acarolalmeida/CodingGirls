using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Escola.Context;
using API_Escola.Models;

namespace API_Escola.Controllers
{
    [Route("api/escola/[controller]")]
    [ApiController]
    public class TurmaController : ControllerBase
    {
        private readonly API_EscolaContext _context;

        public TurmaController(API_EscolaContext context)
        {
            _context = context;
        }

        // GET: api/escola/Turma
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Turma>>> GetTurma()
        {
            List<Turma> turmasCadastradas = _context.Turma.ToList();

            if (_context.Turma == null)
            {
              return NotFound();
            }

            List<Turma> turmasAtivas = new List<Turma>();

            foreach (Turma turmaCadastrada in turmasCadastradas)
            {
                if (turmaCadastrada.Ativo == true)
                {
                    turmasAtivas.Add(turmaCadastrada);
                }
            }

            return turmasAtivas;
        }

        // GET: api/escola/Turma/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Turma>> GetTurma(int id)
        {
            if (_context.Turma == null)
            {
              return NotFound();
            }

            var turma = await _context.Turma.FindAsync(id);

            if (turma == null)
            {
                return NotFound();
            }

            if (turma.Ativo == true)
            {
                return turma;
            }

            else
            {
                return NotFound();
            }
        }

        // PUT: api/escola/Turma/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurma(int id, Turma turma)
        {
            if (id != turma.Id)
            {
                return BadRequest();
            }

            _context.Entry(turma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurmaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/escola/Turma
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Turma>> PostTurma(Turma turma)
        {
          if (_context.Turma == null)
          {
              return Problem("Entity set 'API_EscolaContext.Turma'  is null.");
          }
            _context.Turma.Add(turma);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTurma", new { id = turma.Id }, turma);
        }

        // DELETE: api/escola/Turma/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurma(int id)
        {
            if (_context.Turma == null)
            {
                return NotFound();
            }
            var turma = await _context.Turma.FindAsync(id);
            if (turma == null)
            {
                return NotFound();
            }

            _context.Turma.Remove(turma);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TurmaExists(int id)
        {
            return (_context.Turma?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
