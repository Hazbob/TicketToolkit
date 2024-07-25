using Microsoft.AspNetCore.Mvc;
using TicketToolkit.Interfaces;
using TicketToolkit.Models;
using TicketToolkit.Models.API.Request;

namespace TicketToolkit.Services;

public class TicketService: ITicketService
{
    public Task<IEnumerable<Ticket>> GetAllTickets(Guid userId)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> GetTicket(Guid userId, Guid ticketId)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> AddTicket(AddTicketRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<IActionResult> RemoveTicket(RemoveTicketRequest request)
    {
        throw new NotImplementedException();
    }

    public Task<Ticket> EditTicket(EditTicketRequest request)
    {
        throw new NotImplementedException();
    }
}