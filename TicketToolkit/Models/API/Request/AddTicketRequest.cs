namespace TicketToolkit.Models.API.Request;

public class AddTicketRequest
{
    public string EventName { get; set; } = "No event name";
    public DateTime EventDate { get; set; }
    public DateTime PurchaseDate { get; set; }
    public double PurchasePrice { get; set; }
    public int Quantity { get; set; }
    public Guid UserId { get; set; }
}