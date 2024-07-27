using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.JavaScript;

namespace TicketToolkit.Models;

public class Ticket
{
    public Guid TicketId { get; set; }
    public string EventName { get; set; } = "No event name";
    public DateTime EventDate { get; set; }
    public DateTime PurchaseDate { get; set; }
    public double PurchasePrice { get; set; }
    public int Quantity { get; set; }
    public Guid UserId { get; set; }
    public string? ViagogoLink { get; set; }
    public double PricePerTicket => PurchasePrice *= Quantity;
}