namespace TicketsManagement.Tests;

using Moq;
using Xunit;
using TicketsManagement.Controllers;
using TicketsManagement.Services;
using TicketsManagement.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;
using TicketsManagement.utils;

public class TicketControllerTest
{

    private readonly TicketController _controller;
    private readonly Mock<ITicketService> _mockTicketService;

    public TicketControllerTest()
    {

        _mockTicketService = new Mock<ITicketService>();
        _controller = new TicketController(_mockTicketService.Object);
    }

    [Fact]
    public async Task GetTickets_ReturnsOkResult()
    {
        var paginatedTickets = new utils.PaginatedList<Ticket>(new List<Ticket> { new Ticket { TicketId = 1, Description = "desc one", Status = TicketStatus.Open, Date = DateTime.Parse("2024-10-17T20:29:03.9698788Z") } }, 1, 1, 10);
        _mockTicketService.Setup(service => service.getTickets(1, 10))
            .ReturnsAsync(paginatedTickets);


        var result = await _controller.getTickets(1, 10);

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
    }
    [Fact]
    public async Task GetOpenTickets_ReturnsOkResult()
    {
        var paginatedTickets = new utils.PaginatedList<Ticket>(new List<Ticket> { new Ticket { TicketId = 1, Description = "desc one", Status = TicketStatus.Open, Date = DateTime.Parse("2024-10-17T20:29:03.9698788Z") } }, 1, 1, 10);
        _mockTicketService.Setup(service => service.getOpenTickets(1, 10))
            .ReturnsAsync(paginatedTickets);


        var result = await _controller.getOpenTickets(1, 10);

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
    }

    [Fact]
    public async Task GetClosedTickets_ReturnsOkResult()
    {
        var paginatedTickets = new utils.PaginatedList<Ticket>(new List<Ticket> { new Ticket { TicketId = 1, Description = "desc one", Status = TicketStatus.Open, Date = DateTime.Parse("2024-10-17T20:29:03.9698788Z") } }, 1, 1, 10);
        _mockTicketService.Setup(service => service.getClosedTickets(1, 10))
            .ReturnsAsync(paginatedTickets);


        var result = await _controller.getClosedTickets(1, 10);

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
    }

    [Fact]
    public async Task GetTicket_ReturnsOkResult()
    {
        var ticket = new Ticket { TicketId = 1, Description = "desc one", Status = TicketStatus.Open, Date = DateTime.Parse("2024-10-17T20:29:03.9698788Z") };
        _mockTicketService.Setup(service => service.getTicketById(1))
            .ReturnsAsync(ticket);

        var result = await _controller.getTicket(1);

        var okResult = Assert.IsType<OkObjectResult>(result.Result);
        var returnValue = Assert.IsType<Ticket>(okResult.Value);
        Assert.Equal(1, returnValue.TicketId);
        Assert.Equal("desc one", returnValue.Description);
        Assert.Equal(TicketStatus.Open, returnValue.Status);
        Assert.Equal(DateTime.Parse("2024-10-17T20:29:03.9698788Z"), returnValue.Date);
    }

    [Fact]
    public async Task CreateTicket_ReturnsCreatedAtAction()
    {
        var newTicket = new Ticket { TicketId = 1, Description = "desc one", Status = TicketStatus.Open, Date = DateTime.Parse("2024-10-17T20:29:03.9698788Z") }; ;
        _mockTicketService.Setup(service => service.createTicket(It.IsAny<Ticket>()))
            .ReturnsAsync(newTicket);

        var result = await _controller.createTicket(new Ticket());

        var createdResult = Assert.IsType<CreatedAtActionResult>(result.Result);
        var returnValue = Assert.IsType<Ticket>(createdResult.Value);
        Assert.Equal(1, returnValue.TicketId);
        Assert.Equal("desc one", returnValue.Description);
        Assert.Equal(TicketStatus.Open, returnValue.Status);
        Assert.Equal(DateTime.Parse("2024-10-17T20:29:03.9698788Z"), returnValue.Date);
    }


    [Fact]
    public async Task UpdateTicket_ReturnsNoContentResult()
    {
        var ticket = new Ticket { TicketId = 1, Description = "Updated Ticket" };
        _mockTicketService.Setup(service => service.updateTicket(It.IsAny<Ticket>()))
            .Returns(Task.CompletedTask);

        var result = await _controller.updateTicket(1, ticket);

        Assert.IsType<NoContentResult>(result);
    }

    [Fact]
    public async Task DeleteTicket_ReturnsNoContentResult()
    {
        _mockTicketService.Setup(service => service.deleteTicket(1))
            .Returns(Task.CompletedTask);

        var result = await _controller.deleteTicket(1);

        Assert.IsType<NoContentResult>(result);
    }


}