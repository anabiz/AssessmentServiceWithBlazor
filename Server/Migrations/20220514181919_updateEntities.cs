using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class updateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Questions",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Options",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Options",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("4122dc03-ed83-4d07-985a-351068084891"), "Toyota 330", 90.35m },
                    { new Guid("990671d0-a352-4339-a766-5f8b4ae92a45"), "Mesdix 992", 105.35m },
                    { new Guid("b2aaa831-017d-4e90-bc18-0231087afc4a"), "Lexus 992", 105.35m },
                    { new Guid("f20bc8c6-f2c2-4f07-a622-aa8b19de1240"), "Lexus 122", 100.35m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("4122dc03-ed83-4d07-985a-351068084891"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("990671d0-a352-4339-a766-5f8b4ae92a45"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("b2aaa831-017d-4e90-bc18-0231087afc4a"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f20bc8c6-f2c2-4f07-a622-aa8b19de1240"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Questions");

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Options");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Options");

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
    }
}
