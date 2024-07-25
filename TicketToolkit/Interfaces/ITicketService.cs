using Microsoft.AspNetCore.Mvc;
using TicketToolkit.Models;
using TicketToolkit.Models.API.Request;

namespace TicketToolkit.Interfaces;

public interface ITicketService
{
    public Task<IEnumerable<Ticket>> GetAllTickets(Guid userId);
    public Task<Ticket> GetTicket(Guid userId, Guid ticketId);
    public Task<IActionResult> AddTicket(AddTicketRequest request);
    public Task<IActionResult> RemoveTicket(RemoveTicketRequest request);
    public Task<Ticket> EditTicket(EditTicketRequest request);
}