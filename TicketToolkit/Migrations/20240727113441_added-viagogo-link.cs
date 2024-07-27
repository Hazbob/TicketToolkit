using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TicketToolkit.Migrations
{
    /// <inheritdoc />
    public partial class addedviagogolink : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ViagogoLink",
                table: "Tickets",
                type: "text",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ViagogoLink",
                table: "Tickets");
        }
    }
}
