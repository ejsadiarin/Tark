using TarkApi.Models;

namespace TarkApi.Services.TicketService;

public interface ITicketService
{
    Task<List<Ticket>?> GetAllTickets();
    Task<List<Ticket>> AddTicket();
    Task<List<Ticket>> UpdateTicket();
    Task<List<Ticket>> DeleteTicket();
}