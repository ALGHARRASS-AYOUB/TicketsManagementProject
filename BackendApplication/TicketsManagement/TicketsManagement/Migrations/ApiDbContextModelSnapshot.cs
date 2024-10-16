﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TicketsManagement.Data;

#nullable disable

namespace TicketsManagement.Migrations
{
    [DbContext(typeof(ApiDbContext))]
    partial class ApiDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TicketsManagement.Models.Ticket", b =>
                {
                    b.Property<int>("TicketId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TicketId"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("TicketId");

                    b.ToTable("Tickets");

                    b.HasData(
                        new
                        {
                            TicketId = 1,
                            Date = new DateTime(2024, 10, 10, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6288),
                            Description = "desc 1 ",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 2,
                            Date = new DateTime(2024, 10, 12, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6297),
                            Description = "desc 2",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 3,
                            Date = new DateTime(2024, 10, 13, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6300),
                            Description = "desc 3",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 4,
                            Date = new DateTime(2024, 10, 14, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6302),
                            Description = "desc 4",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 5,
                            Date = new DateTime(2024, 10, 6, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6303),
                            Description = "desc 5 ",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 6,
                            Date = new DateTime(2024, 10, 12, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6305),
                            Description = "desc 6",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 7,
                            Date = new DateTime(2024, 10, 13, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6307),
                            Description = "desc 7",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 8,
                            Date = new DateTime(2024, 10, 14, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6309),
                            Description = "desc 8",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 9,
                            Date = new DateTime(2024, 10, 10, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6311),
                            Description = "desc 9 ",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 10,
                            Date = new DateTime(2024, 10, 12, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6312),
                            Description = "desc 10",
                            Status = 1
                        },
                        new
                        {
                            TicketId = 11,
                            Date = new DateTime(2024, 10, 13, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6314),
                            Description = "desc 11",
                            Status = 0
                        },
                        new
                        {
                            TicketId = 12,
                            Date = new DateTime(2024, 10, 14, 23, 54, 45, 81, DateTimeKind.Utc).AddTicks(6316),
                            Description = "desc 12",
                            Status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
