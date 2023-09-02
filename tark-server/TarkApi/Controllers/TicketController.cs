using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using TarkApi.Models;
using TarkApi.Services.TicketService;

namespace TarkApi.Controllers;

[ApiController]
[Route("[controller]")]
public class TicketController : ControllerBase
{
    private readonly ITicketService _ticketService;
    
    public TicketController(ITicketService ticketService)
    {
        _ticketService = ticketService;
    }
    
    [HttpGet(Name = "GetAllTickets")]
    public async Task<ActionResult<List<Ticket>>> GetTickets()
    {
        var result = await _ticketService.GetAllTickets();

        return Ok(result);
    }

    [HttpPost]
    public async Task<ActionResult<List<Ticket>>> AddTicket(Ticket req)
    {
        var result = await _ticketService.AddTicket(req);
        
        return result;
    }

    [HttpPut("{id}")]
    public async Task<ActionResult<List<Ticket>>> UpdateTicket(int id, Ticket req)
    {
        var result = await _ticketService.UpdateTicket(id, req);
        if (result is null) return NotFound("Id not found.");

        return Ok(result);
    }
    
    [HttpDelete("{id}")]
    public async Task<ActionResult<List<Ticket>>> DeleteTicket(int id)
    {
        var result = await _ticketService.DeleteTicket(id);
        if (result is null) return NotFound("Id not found.");

        return Ok(result);
    }
}