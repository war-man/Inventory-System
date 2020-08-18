using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace netcore.Migrations
{
    public partial class MinQuantity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "QTY",
                table: "Product",
                newName: "Qty");

            migrationBuilder.AddColumn<float>(
                name: "minQuantity",
                table: "Product",
                nullable: false,
                defaultValue: 0f);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "minQuantity",
                table: "Product");

            migrationBuilder.RenameColumn(
                name: "Qty",
                table: "Product",
                newName: "QTY");
        }
    }
}
