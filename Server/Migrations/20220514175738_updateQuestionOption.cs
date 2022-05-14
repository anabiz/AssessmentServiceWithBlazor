using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class updateQuestionOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("186d7d2a-8ffd-49b0-9735-4db83eb5f46a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("51a452b0-99f3-4ed1-858f-332279160d0d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("d2dfb0b6-b949-453f-b0a1-d697c2b9ad28"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f2ab740c-7c4c-4424-8a15-2348a6360baa"));

            migrationBuilder.AddColumn<Guid>(
                name: "QuestionId",
                table: "Options",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("20566019-fb95-4d16-8cd4-e3539fbdcb5f"), "Toyota 330", 90.35m },
                    { new Guid("783de6ab-47f8-4b9c-8762-a5057dea0624"), "Lexus 122", 100.35m },
                    { new Guid("8798d777-6eae-4bf9-ab39-db965f329f47"), "Lexus 992", 105.35m },
                    { new Guid("ac0f371b-1383-49d3-8da0-171bcaa43362"), "Mesdix 992", 105.35m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("20566019-fb95-4d16-8cd4-e3539fbdcb5f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("783de6ab-47f8-4b9c-8762-a5057dea0624"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("8798d777-6eae-4bf9-ab39-db965f329f47"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac0f371b-1383-49d3-8da0-171bcaa43362"));

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Options");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("186d7d2a-8ffd-49b0-9735-4db83eb5f46a"), "Mesdix 992", 105.35m },
                    { new Guid("51a452b0-99f3-4ed1-858f-332279160d0d"), "Lexus 122", 100.35m },
                    { new Guid("d2dfb0b6-b949-453f-b0a1-d697c2b9ad28"), "Lexus 992", 105.35m },
                    { new Guid("f2ab740c-7c4c-4424-8a15-2348a6360baa"), "Toyota 330", 90.35m }
                });
        }
    }
}
