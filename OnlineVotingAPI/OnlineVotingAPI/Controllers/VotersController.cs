using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineVotingAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class VotersController : ControllerBase
{
    private readonly VotingDbContext _context;

    public VotersController(VotingDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Voter>>> GetVoters()
    {
        return await _context.Voters.ToListAsync();
    }

    // Implement other CRUD operations (GetVoter, PostVoter, PutVoter, DeleteVoter)
}