﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HotelService.Migrations
{
    /// <inheritdoc />
    public partial class AddPeopleCountToReservations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PeopleCount",
                table: "Reservations",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PeopleCount",
                table: "Reservations");
        }
    }
}
