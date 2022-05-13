using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("25b8a747-60ef-430e-991f-cd1e01305707"), "Lexus 992", 105.35m },
                    { new Guid("5f9fc15c-3387-4a70-82cf-2f3b44ccc874"), "Toyota 330", 90.35m },
                    { new Guid("612d01b8-b052-429e-9d80-de7bc9f5d382"), "Lexus 122", 100.35m },
                    { new Guid("9d5a2d32-2756-42ff-9cb3-8dcbbb87b83f"), "Mesdix 992", 105.35m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
