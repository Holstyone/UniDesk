using UniDesk.Web.Models;

namespace UniDesk.Web.Services;

public class InMemoryTicketService : ITicketService
{
    private static List<Ticket> _tickets = new();

    public IEnumerable<Ticket> GetAll()
    {
        return _tickets;
    }

    public Ticket? GetById(int id)
    {
        return _tickets.FirstOrDefault(t => t.Id == id);
    }

    public void Add(Ticket ticket)
    {
        ticket.Id = _tickets.Count + 1;
        ticket.Status = TicketStatus.Open;
        ticket.CreatedAt = DateTime.Now;

        _tickets.Add(ticket);
    }
}