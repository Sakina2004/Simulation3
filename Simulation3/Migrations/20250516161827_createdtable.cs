using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Simulation3.Migrations
{
    /// <inheritdoc />
    public partial class createdtable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateTime",
                table: "Products");

            migrationBuilder.AddColumn<DateTime>(
                name: "Time",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Time",
                table: "Products");

            migrationBuilder.AddColumn<string>(
                name: "DateTime",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
