using Microsoft.AspNetCore.Mvc;
using TicketToolkit.Models;

namespace TicketToolkit.Controllers;

public class TicketController : Controller
{
    [HttpGet("/ticket/{ticketId}")]
    public async Task<IActionResult> GetTicket()
    {
        return Ok("test");
    }

}