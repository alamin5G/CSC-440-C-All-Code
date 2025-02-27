using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OnlineVotingAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

[ApiController]
[Route("api/[controller]")]
public class ElectionsController : ControllerBase
{
    private readonly VotingDbContext _context;

    public ElectionsController(VotingDbContext context)
    {
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<Election>>> GetElections()
    {
        return await _context.Elections.ToListAsync();
    }

    // Implement other CRUD operations (GetElection, PostElection, PutElection, DeleteElection)
}