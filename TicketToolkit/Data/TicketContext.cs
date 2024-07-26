using Microsoft.EntityFrameworkCore;
using TicketToolkit.Models;

namespace TicketToolkit.Data;

public class TicketContext(DbContextOptions<TicketContext> options) : DbContext(options)
{
    public DbSet<Ticket?> Tickets { get; set; }
}