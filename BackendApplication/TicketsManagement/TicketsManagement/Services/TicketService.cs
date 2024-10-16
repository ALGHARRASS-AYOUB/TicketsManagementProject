using Microsoft.EntityFrameworkCore;
using TicketsManagement.Data;
using TicketsManagement.Exceptions;
using TicketsManagement.Models;
using TicketsManagement.utils;

namespace TicketsManagement.Services
{
    public class TicketService : ITicketService
    {
        private readonly ApiDbContext _context;
        public TicketService(ApiDbContext context)
        {
            _context = context;
        }

        public async Task<PaginatedList<Ticket>> getTickets(int pageNumber, int pageSize)
        {
            var query = _context.Tickets.AsQueryable();
            return await PaginatedList<Ticket>.paginate(query, pageNumber, pageSize);
        }
        public async Task<Ticket> getTicketById(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                throw new TicketNotFoundException(id); 
            }
            return ticket;
        }

        public async Task<Ticket> createTicket(Ticket ticket)
        {
            ticket.Date = DateTime.UtcNow;
            _context.Tickets.Add(ticket);
            await _context.SaveChangesAsync();
            return ticket;
        }

        public async Task updateTicket(Ticket ticket)
        {
            if (!await _context.Tickets.AnyAsync(t => t.TicketId == ticket.TicketId))
            {
                throw new TicketNotFoundException(ticket.TicketId); 
            }
            _context.Tickets.Update(ticket);
            await _context.SaveChangesAsync();
        }

        public async Task deleteTicket(int id)
        {
            var ticket = await _context.Tickets.FindAsync(id);
            if (ticket == null)
            {
                throw new TicketNotFoundException(id); 
            }
            _context.Tickets.Remove(ticket);
            await _context.SaveChangesAsync();
        }
    }
}
