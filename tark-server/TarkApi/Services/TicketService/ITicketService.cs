using TarkApi.Models;

namespace TarkApi.Services.TicketService;

public interface ITicketService
{
    Task<List<Ticket>?> GetAllTickets();
    Task<List<Ticket>?> AddTicket(Ticket req);
    Task<List<Ticket>?> UpdateTicket(int id, Ticket req);
    Task<List<Ticket>?> DeleteTicket(int id);
}