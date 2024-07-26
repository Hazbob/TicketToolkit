using TicketToolkit.Models;

namespace TicketToolkit.Interfaces.RepositoryInterfaces;

public interface ITicketRepository
{
    public Task<Ticket?> GetTicket(Guid ticketId, Guid userId);
}