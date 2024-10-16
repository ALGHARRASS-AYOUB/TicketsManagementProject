using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using TicketsManagement.Models;

namespace TicketsManagement.Data
{
    public class DbSeeder
    {
        private readonly ApiDbContext _context;
        private readonly ILogger<DbSeeder> _logger;

        public DbSeeder(ApiDbContext context, ILogger<DbSeeder> logger)
        {
            _context = context;
            _logger = logger;
        }

        public async Task SeedAsync()
        {
            await _context.Database.MigrateAsync();

            if (await _context.Tickets.AnyAsync())
            {
                _logger.LogInformation("Database already contains data. Skipping seeding.");
                return;
            }

            //seed data
            _context.Tickets.AddRange(
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


            await _context.SaveChangesAsync();
            _logger.LogInformation("db seeded successfully.");
        }

    }
}