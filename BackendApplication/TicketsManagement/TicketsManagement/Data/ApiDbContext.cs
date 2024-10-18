using System.Collections.Generic;
using System.Net.Sockets;
using System.Reflection.Emit;
using System;
using TicketsManagement.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Moq;
using TicketsManagement.Controllers;
using TicketsManagement.Services;
using TicketsManagement.utils;
using Xunit;

namespace TicketsManagement.Data
{
    public class ApiDbContext : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }


        public ApiDbContext(DbContextOptions<ApiDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ticket>().HasKey(t => t.TicketId);
            modelBuilder.Entity<Ticket>().Property(t => t.Status).IsRequired();

            modelBuilder.Entity<Ticket>().HasData(
                  new Ticket
                  {
                      TicketId = 1,
                      Description = "desc 1 ",
                      Status = TicketStatus.Open,
                      Date = DateTime.UtcNow.AddDays(-5)
                  },
                new Ticket
                {
                    TicketId = 2,
                    Description = "desc 2",
                    Status = TicketStatus.Closed,
                    Date = DateTime.UtcNow.AddDays(-3)
                },
                new Ticket
                {
                    TicketId = 3,
                    Description = "desc 3",
                    Status = TicketStatus.Open,
                    Date = DateTime.UtcNow.AddDays(-2)
                },
                new Ticket
                {
                    TicketId = 4,
                    Description = "desc 4",
                    Status = TicketStatus.Open,
                    Date = DateTime.UtcNow.AddDays(-1)
                },
                                new Ticket
                                {
                                    TicketId = 5,
                                    Description = "desc 5 ",
                                    Status = TicketStatus.Open,
                                    Date = DateTime.UtcNow.AddDays(-9)
                                },
                new Ticket
                {
                    TicketId = 6,
                    Description = "desc 6",
                    Status = TicketStatus.Closed,
                    Date = DateTime.UtcNow.AddDays(-3)
                },
                new Ticket
                {
                    TicketId = 7,
                    Description = "desc 7",
                    Status = TicketStatus.Open,
                    Date = DateTime.UtcNow.AddDays(-2)
                },
                new Ticket
                {
                    TicketId = 8,
                    Description = "desc 8",
                    Status = TicketStatus.Open,
                    Date = DateTime.UtcNow.AddDays(-1)
                },
                  new Ticket
                  {
                      TicketId = 9,
                      Description = "desc 9 ",
                      Status = TicketStatus.Open,
                      Date = DateTime.UtcNow.AddDays(-5)
                  },
                new Ticket
                {
                    TicketId = 10,
                    Description = "desc 10",
                    Status = TicketStatus.Closed,
                    Date = DateTime.UtcNow.AddDays(-3)
                },
                new Ticket
                {
                    TicketId = 11,
                    Description = "desc 11",
                    Status = TicketStatus.Open,
                    Date = DateTime.UtcNow.AddDays(-2)
                },
                new Ticket
                {
                    TicketId = 12,
                    Description = "desc 12",
                    Status = TicketStatus.Open,
                    Date = DateTime.UtcNow.AddDays(-1)
                }
                );
        }
    }
}
