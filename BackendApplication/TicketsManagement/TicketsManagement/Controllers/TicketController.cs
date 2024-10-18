using Microsoft.AspNetCore.Mvc;
using TicketsManagement.Models;
using TicketsManagement.Services;
using TicketsManagement.utils;

namespace TicketsManagement.Controllers
{
    [Route("api/v1/tickets")]
    [ApiController]
    public class TicketController:ControllerBase
    {
        private readonly ITicketService _ticketService;
        public TicketController(ITicketService ticketService)
        {
            _ticketService = ticketService;
        }

        //api/v1/tickets?pageNumber=1&pageSize=10
        [HttpGet]
        public async Task<ActionResult<PaginatedList<Ticket>>> getTickets(int pageNumber = 1, int pageSize = 10)
        {
            var tickets = await _ticketService.getTickets(pageNumber, pageSize);
          
            var response = new
            {
                Tickets = tickets,          
                pageNumber = pageNumber,     
                totalPages = tickets.totalPages,  
                pageSize = pageSize,         
                totalCount = tickets.Count   
            };
            return Ok(response);
        }


        //api/v1/opentickets?pageNumber=1&pageSize=10
        [HttpGet]
        [Route("open")]
        public async Task<ActionResult<PaginatedList<Ticket>>> getOpenTickets(int pageNumber = 1, int pageSize = 10)
        {
            var tickets = await _ticketService.getOpenTickets(pageNumber, pageSize);
            var response = new
            {
                Tickets = tickets,
                pageNumber = pageNumber,
                totalPages = tickets.totalPages,
                pageSize = pageSize,
                totalCount = tickets.Count
            };
            return Ok(response);
        }

        //api/v1/closedtickets?pageNumber=1&pageSize=10
        [HttpGet]
        [Route("closed")]
        public async Task<ActionResult<PaginatedList<Ticket>>> getClosedTickets(int pageNumber = 1, int pageSize = 10)
        {
            var tickets = await _ticketService.getClosedTickets(pageNumber, pageSize);
            var response = new
            {
                Tickets = tickets,
                pageNumber = pageNumber,
                totalPages = tickets.totalPages,
                pageSize = pageSize,
                totalCount = tickets.Count
            };
            return Ok(response);
        }

        //api/v1/tickets/{id}
        [HttpGet("{id}")]
        public async Task<ActionResult<Ticket>> getTicket(int id)
        {
            var ticket = await _ticketService.getTicketById(id);
            return Ok(ticket);
        }

        //api/v1/tickets
        [HttpPost]
        public async Task<ActionResult<Ticket>> createTicket([FromBody] Ticket ticket)
        {
            var createdTicket = await _ticketService.createTicket(ticket);
            return CreatedAtAction(nameof(getTicket), new { id = createdTicket.TicketId }, createdTicket);
        }

        // api/v1/tickets/{id}
        [HttpPut("{id}")]
        public async Task<IActionResult> updateTicket(int id, [FromBody] Ticket ticket)
        {
            if (id != ticket.TicketId) return BadRequest();

            await _ticketService.updateTicket(ticket);
            return NoContent();
        }

        // DELETE: api/v1/tickets/{id}
        [HttpDelete("{id}")]
        public async Task<IActionResult> deleteTicket(int id)
        {
            await _ticketService.deleteTicket(id);
            return NoContent();
        }
    }
}
