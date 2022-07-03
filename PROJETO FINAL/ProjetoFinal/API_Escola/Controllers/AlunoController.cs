using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API_Escola.Context;
using API_Escola.Models;

namespace API_Escola.Controllers
{
    [Route("api/escola/[controller]")]
    [ApiController]
    public class AlunoController : ControllerBase
    {
        private readonly API_EscolaContext _context;

        public AlunoController(API_EscolaContext context)
        {
            _context = context;
        }

        // GET: api/escola/Aluno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Aluno>>> GetAluno()
        {
            List<Aluno> alunosCadastrados = _context.Aluno.ToList();
            List<Turma> turmasCadastradas = _context.Turma.ToList();

            if (_context.Aluno == null)
           {
                return NotFound();
           }
                       
           List<Aluno> alunosAtivos = new List<Aluno>();
           
           foreach (Aluno alunoCadastrado in alunosCadastrados)
           {
                Turma? turmaDoAluno = turmasCadastradas.Find(x => x.Id == alunoCadastrado.TurmaId);
               
                if (turmaDoAluno.Ativo == true)
                {
                    alunosAtivos.Add(alunoCadastrado);
                }
            }

            return alunosAtivos;
        }

        // GET: api/escola/Aluno/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Aluno>> GetAluno(int id)
        {
            List<Turma> turmasCadastradas = _context.Turma.ToList();

            if (_context.Aluno == null)
            {
              return NotFound();
            }

            var aluno = await _context.Aluno.FindAsync(id);

            if (aluno == null)
            {
                return NotFound();
            }

            Turma? turmaDoAluno = turmasCadastradas.Find(x => x.Id == aluno.TurmaId);

            if (turmaDoAluno.Ativo == true)
            {
                return aluno;
            }

            else 
            {
                return NotFound();
            }
        }

        // PUT: api/escola/Aluno/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<ActionResult<Turma>> PutAluno(int id, Aluno aluno)
        {
            List<Turma> turmasCadastradas = _context.Turma.ToList();

            if (id != aluno.Id)
            {
                return BadRequest();
            }

            _context.Entry(aluno).State = EntityState.Modified;

            Turma? turmaDoAluno = turmasCadastradas.Find(x => x.Id == aluno.TurmaId);
            
            if (turmaDoAluno.Ativo == false)
            {
                return BadRequest();
            }

            else 
            {
                try
                {
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!AlunoExists(id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
            }
            
            return NoContent();
        }

        // POST: api/escola/Aluno
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Aluno>> PostAluno(Aluno aluno)
        {
            if (_context.Aluno == null)
            {
                return Problem("Entity set 'API_EscolaContext.Aluno'  is null.");
            }
            _context.Aluno.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAluno", new { id = aluno.Id }, aluno);
        }

        // DELETE: api/escola/Aluno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAluno(int id)
        {
            if (_context.Aluno == null)
            {
                return NotFound();
            }
            var aluno = await _context.Aluno.FindAsync(id);
            if (aluno == null)
            {
                return NotFound();
            }

            _context.Aluno.Remove(aluno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AlunoExists(int id)
        {
            return (_context.Aluno?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
