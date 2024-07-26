using Microsoft.AspNetCore.Mvc;
using TicketToolkit.Exceptions;
using TicketToolkit.Handlers;
using TicketToolkit.Interfaces;
using TicketToolkit.Models;

namespace TicketToolkit.Controllers;

public class TicketController : Controller
{
    private readonly ITicketService _ticketService;
    private readonly AsyncRequestHandler _requestHandler;
    public TicketController(ITicketService ticketService, AsyncRequestHandler requestHandler)
    {
        _ticketService = ticketService;
        _requestHandler = requestHandler;
    }
    
    [HttpGet("/ticket/{ticketId}")]
    public async Task<IActionResult> GetTicket([FromRoute] Guid ticketId, Guid userId )
    {
        return await _requestHandler.HandleRequest(async () =>
        {
            var ticket = await _ticketService.GetTicket(userId, ticketId);
            if (ticket is null)
            {
                throw new TicketDoesNotExistException("No Ticket Exists");
            }
            return Ok(ticket);
        });

    }
}