using Microsoft.EntityFrameworkCore.Migrations;

namespace Sow.Data.Migrations
{
    public partial class afa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AppUserID",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "AppUserID",
                table: "Events",
                newName: "AppUserId");

            migrationBuilder.RenameIndex(
                name: "IX_Events_AppUserID",
                table: "Events",
                newName: "IX_Events_AppUserId");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Events",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "AppUserEventID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AppUserId",
                table: "Events",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AppUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AppUserEventID",
                table: "Events");

            migrationBuilder.RenameColumn(
                name: "AppUserId",
                table: "Events",
                newName: "AppUserID");

            migrationBuilder.RenameIndex(
                name: "IX_Events_AppUserId",
                table: "Events",
                newName: "IX_Events_AppUserID");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserID",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AppUserID",
                table: "Events",
                column: "AppUserID",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
