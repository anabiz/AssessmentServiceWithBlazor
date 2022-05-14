using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Server.Migrations
{
    public partial class addQuestionIdToOption : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { new Guid("26681817-db85-4c5a-9fa9-27c99b5e19bb"), "Mesdix 992", 105.35m },
                    { new Guid("a78ef284-ea44-4d0a-a2f7-afb1cb820166"), "Lexus 122", 100.35m },
                    { new Guid("ac20cee3-76da-45d7-baa5-0d634f96f2ab"), "Toyota 330", 90.35m },
                    { new Guid("e8141a83-3a78-4ccf-b7c7-0b4bd9bb5871"), "Lexus 992", 105.35m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Options_QuestionId",
                table: "Options",
                column: "QuestionId");

            migrationBuilder.AddForeignKey(
                name: "FK_Options_Questions_QuestionId",
                table: "Options",
                column: "QuestionId",
                principalTable: "Questions",
                principalColumn: "Id",
                onDelete: ReferentialAction.NoAction);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Options_Questions_QuestionId",
                table: "Options");

            migrationBuilder.DropIndex(
                name: "IX_Options_QuestionId",
                table: "Options");

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

            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Options");

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
    }
}
