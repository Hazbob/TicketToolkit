using Microsoft.AspNetCore.Mvc;

namespace TicketToolkit.Handlers;

public static class AsyncRequestHandler
{
    public static async Task<IActionResult> HandleRequest(Func<Task<IActionResult>> asyncRequest)
    {
        try
        {
            return await asyncRequest();
        }
        catch (Exception e)
        {
            Console.WriteLine(e);
            throw;
        }
    }
}