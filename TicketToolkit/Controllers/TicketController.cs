using Microsoft.AspNetCore.Mvc;
using TicketToolkit.Models;

namespace TicketToolkit.Controllers;

public class TicketController : Controller
{
    [HttpGet("/ticket/{ticketId}")]
    public IActionResult GetTicket([FromRoute] int ticketId)
    {
        try
        {
            var ticket = new Ticket()
            {
                EventName = "test",
                EventDate = new DateTime(),
                PurchasePrice = 10,
                PurchaseDate = new DateTime(),
                TicketId = new Guid("EC6435EE-E778-4A22-9A9A-B0E4C3030EE8"),
                Quantity = 4,
                UserId = new Guid("B382DB64-8826-42A6-BF13-505381162CCF")
            };
            return Ok(ticket);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            BadRequest(e.Message);
            throw;
        }
    }
}