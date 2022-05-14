using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class updateAssessmentEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("26681817-db85-4c5a-9fa9-27c99b5e19bb"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a78ef284-ea44-4d0a-a2f7-afb1cb820166"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ac20cee3-76da-45d7-baa5-0d634f96f2ab"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("e8141a83-3a78-4ccf-b7c7-0b4bd9bb5871"));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "Assessments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Assessments",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("0ab99879-8e59-4cc5-87c1-bb911a4aff2d"), "Lexus 992", 105.35m },
                    { new Guid("94a78d3a-bd0c-4b78-88bd-bcbc73b62245"), "Lexus 122", 100.35m },
                    { new Guid("ad29688d-8f47-48c3-a2ba-c50f8f7bbb82"), "Toyota 330", 90.35m },
                    { new Guid("cedf3a67-3ed4-44da-af20-160c5dad8d53"), "Mesdix 992", 105.35m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("0ab99879-8e59-4cc5-87c1-bb911a4aff2d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("94a78d3a-bd0c-4b78-88bd-bcbc73b62245"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("ad29688d-8f47-48c3-a2ba-c50f8f7bbb82"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("cedf3a67-3ed4-44da-af20-160c5dad8d53"));

            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "Assessments");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Assessments");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("26681817-db85-4c5a-9fa9-27c99b5e19bb"), "Mesdix 992", 105.35m },
                    { new Guid("a78ef284-ea44-4d0a-a2f7-afb1cb820166"), "Lexus 122", 100.35m },
                    { new Guid("ac20cee3-76da-45d7-baa5-0d634f96f2ab"), "Toyota 330", 90.35m },
                    { new Guid("e8141a83-3a78-4ccf-b7c7-0b4bd9bb5871"), "Lexus 992", 105.35m }
                });
        }
    }
}
