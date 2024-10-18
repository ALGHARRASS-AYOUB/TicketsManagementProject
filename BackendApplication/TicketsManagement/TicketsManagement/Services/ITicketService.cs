using TicketsManagement.Models;
using TicketsManagement.utils;

namespace TicketsManagement.Services
{
    public interface ITicketService
    {
        Task<PaginatedList<Ticket>> getTickets(int pageNumber, int pageSize);
        Task<PaginatedList<Ticket>> getOpenTickets(int pageNumber, int pageSize);
        Task<PaginatedList<Ticket>> getClosedTickets(int pageNumber, int pageSize);
        Task<Ticket> getTicketById(int id);
        Task<Ticket> createTicket(Ticket ticket);  
        Task updateTicket(Ticket ticket);  
        Task deleteTicket(int id); 
    }
}
