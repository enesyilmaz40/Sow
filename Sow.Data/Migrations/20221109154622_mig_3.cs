using Microsoft.EntityFrameworkCore.Migrations;

namespace Sow.Data.Migrations
{
    public partial class mig_3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AppUserId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_OtherEventId",
                table: "Events");

            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_OwnEventId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_OtherEventId",
                table: "Events");

            migrationBuilder.DropIndex(
                name: "IX_Events_OwnEventId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "OtherEventId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "OwnEventId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                name: "OtherEventId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "OwnEventId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Events_OtherEventId",
                table: "Events",
                column: "OtherEventId");

            migrationBuilder.CreateIndex(
                name: "IX_Events_OwnEventId",
                table: "Events",
                column: "OwnEventId");

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AppUserId",
                table: "Events",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_OtherEventId",
                table: "Events",
                column: "OtherEventId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_OwnEventId",
                table: "Events",
                column: "OwnEventId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
