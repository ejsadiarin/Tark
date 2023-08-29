using TarkApi.Models;

namespace TarkApi.Services.Interfaces;

public interface ITicketService
{
    Task<List<Ticket>?> GetAllTickets();
    Task<>
}