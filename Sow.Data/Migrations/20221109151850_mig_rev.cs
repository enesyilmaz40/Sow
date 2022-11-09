using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Sow.Data.Migrations
{
    public partial class mig_rev : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AppUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "AppUserEventID",
                table: "Events");

            migrationBuilder.AlterColumn<int>(
                name: "AppUserId",
                table: "Events",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "EventLastDate",
                table: "Events",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddForeignKey(
                name: "FK_Events_AspNetUsers_AppUserId",
                table: "Events",
                column: "AppUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Events_AspNetUsers_AppUserId",
                table: "Events");

            migrationBuilder.DropColumn(
                name: "EventLastDate",
                table: "Events");

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
    }
}
