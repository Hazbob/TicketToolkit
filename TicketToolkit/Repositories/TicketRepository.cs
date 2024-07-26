using Microsoft.EntityFrameworkCore;
using TicketToolkit.Data;
using TicketToolkit.Interfaces.RepositoryInterfaces;
using TicketToolkit.Models;

namespace TicketToolkit.Repositories;

public class TicketRepository: ITicketRepository
{
    private readonly TicketContext _ticketDb;
    
    public TicketRepository(TicketContext ticketDb)
    {
        _ticketDb = ticketDb;
    }
    public async Task<Ticket?> GetTicket(Guid ticketId, Guid userId)
    {
        return await _ticketDb.Tickets.FirstOrDefaultAsync(t => t != null && t.TicketId == ticketId && t.UserId == userId);
    }
}