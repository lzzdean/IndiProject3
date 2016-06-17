using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace IndiProject.Data.Migrations
{
    public partial class morestuff : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rating",
                table: "Albums",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Year",
                table: "Albums",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rating",
                table: "Albums");

            migrationBuilder.DropColumn(
                name: "Year",
                table: "Albums");
        }
    }
}
