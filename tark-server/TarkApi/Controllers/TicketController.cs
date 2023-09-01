using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarkApi.DAL;
using TarkApi.Models;

namespace TarkApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketController
{
    private readonly TarkDbContext _context;
    
    public TicketController(TarkDbContext context)
    {
        _context = context;
    }
    
    [HttpGet(Name = "GetAllTickets")]
    public async Task<ActionResult<List<Ticket>>> GetTickets()
    {
        var ticket = new Ticket()
        {
            ProjectId = 1,
            Title = "Test test",
            Description = "testsjdhkfdsgh dfgsfgkejkeja",
            CreatedByUserId = 1,
        };

        _context.Add(ticket);
        await _context.SaveChangesAsync();

        var allTickets = await _context.Tickets.ToListAsync();

        return Ok(allTickets);
    }
}