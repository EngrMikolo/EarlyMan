using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace Telefin.Migrations
{
    public partial class Initial_V2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Prints",
                table: "Prints");

            migrationBuilder.RenameTable(
                name: "Prints",
                newName: "Print");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Print",
                table: "Print",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Print",
                table: "Print");

            migrationBuilder.RenameTable(
                name: "Print",
                newName: "Prints");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prints",
                table: "Prints",
                column: "Id");
        }
    }
}
