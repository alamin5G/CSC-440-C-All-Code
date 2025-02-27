using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using OnlineVotingAPI.Models; // Ensure this is your model namespace

namespace OnlineVotingApi
{
    [ApiController]
    [Route("api/[controller]")]
    public class ResultsController : ControllerBase
    {
        private readonly VotingDbContext _context;

        public ResultsController(VotingDbContext context)
        {
            _context = context;
        }

        // GET: api/Results
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Result>>> GetResults()
        {
            return await _context.Results.ToListAsync();
        }

        // GET: api/Results/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Result>> GetResult(int id)
        {
            var result = await _context.Results.FindAsync(id);

            if (result == null)
            {
                return NotFound();
            }

            return result;
        }

        // POST: api/Results

        // In your ResultsController
        [HttpPost]
        public async Task<ActionResult<Result>> PostResult(Result result)
        {
            // Set ElectionId for the Result and remove circular reference
            result.ElectionId = result.Election.Id;
            result.Election = null;

            // Set ElectionId for each Voter and remove circular reference
            foreach (var voter in result.Election.Voters)
            {
                voter.ElectionId = result.Election.Id;
                voter.Election = null;
            }

            // Remove circular reference from each Result within the Election
            foreach (var r in result.Election.Results)
            {
                r.Election = null;
            }

            _context.Results.Add(result);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetResult), new { id = result.Id }, result);
        }

        // PUT: api/Results/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutResult(int id, OnlineVotingAPI.Models.Result result)
        {
            // ... your existing code ...
            if (id != result.Id)
            {
                return BadRequest();
            }

            _context.Entry(result).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ResultExists(id))
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

        // DELETE: api/Results/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteResult(int id)
        {
            var result = await _context.Results.FindAsync(id);
            // ... your existing code ...
            if (result == null)
            {
                return NotFound();
            }

            _context.Results.Remove(result);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        private bool ResultExists(int id)
        {
            return _context.Results.Any(e => e.Id == id);
        }
    }
}