namespace TicketToolkit.Models.API.Request;

public class RemoveTicketRequest
{
    public Guid UserId { get; set; }
    public Guid TicketId { get; set; }
}