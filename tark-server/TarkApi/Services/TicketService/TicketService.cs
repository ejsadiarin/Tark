using Microsoft.EntityFrameworkCore;
using TarkApi.DAL;
using TarkApi.Models;

namespace TarkApi.Services.TicketService;

public class TicketService : ITicketService
{
    private readonly TarkDbContext _context;

    public TicketService(TarkDbContext context)
    {
        _context = context;
    }
    
    public async Task<List<Ticket>?> GetAllTickets()
    {
        var tickets = await _context.Tickets.ToListAsync();

        return tickets;
    }

    public async Task<List<Ticket>?> AddTicket(Ticket req)
    {
        _context.Tickets.Add(req);
        await _context.SaveChangesAsync();

        var tickets = await GetAllTickets();

        return tickets;
    }

    public async Task<List<Ticket>?> UpdateTicket(int id, Ticket req)
    {
        var ticket = await _context.Tickets.FindAsync(id);
        if (ticket is null) return null;

        ticket.Title = req.Title;
        ticket.Description = req.Description;
        ticket.CreatedByUserId = req.CreatedByUserId;
        ticket.Status = req.Status;

        await _context.SaveChangesAsync();

        return await GetAllTickets();
    }

    public async Task<List<Ticket>?> DeleteTicket(int id)
    {
        var ticketId = await _context.Tickets.FindAsync(id);
        if (ticketId is null) return null;

        _context.Tickets.Remove(ticketId);
        await _context.SaveChangesAsync();

        var newTickets = await GetAllTickets();
        return newTickets;
    }
}