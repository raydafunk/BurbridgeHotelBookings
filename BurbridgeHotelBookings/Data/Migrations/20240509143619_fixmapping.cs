using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BurbridgeHotelBookings.Migrations
{
    /// <inheritdoc />
    public partial class fixmapping : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Rooms_RoomCatagoryId",
                table: "Rooms",
                column: "RoomCatagoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Rooms_RoomCatagories_RoomCatagoryId",
                table: "Rooms",
                column: "RoomCatagoryId",
                principalTable: "RoomCatagories",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Rooms_RoomCatagories_RoomCatagoryId",
                table: "Rooms");

            migrationBuilder.DropIndex(
                name: "IX_Rooms_RoomCatagoryId",
                table: "Rooms");
        }
    }
}
