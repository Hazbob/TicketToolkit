namespace TicketToolkit.Exceptions;

public class TicketDoesNotExistException: Exception
{
    public TicketDoesNotExistException(string message): base(message)
    {
        
    }
}