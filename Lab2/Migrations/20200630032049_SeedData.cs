using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2dcec8ef-7a32-4597-9125-00c3b500c3f5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a125c220-f8e4-479d-b10a-96430da4d454");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "609ab474-051f-443e-b2f1-86583bffb3aa", "cc9f7077-90e3-41a0-a948-4b0bb19b00ec", "Visitor", "VISITOR" },
                    { "83b15716-f64f-41a5-84e1-be37b75755d5", "3cd76cc8-30b6-4544-8fc9-db2c533aa9ec", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 48, 720, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 48, 721, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 48, 721, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 48, 721, DateTimeKind.Local).AddTicks(298));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "609ab474-051f-443e-b2f1-86583bffb3aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83b15716-f64f-41a5-84e1-be37b75755d5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2dcec8ef-7a32-4597-9125-00c3b500c3f5", "3d9e59f0-767c-4718-a2de-f93947afcd90", "Visitor", "VISITOR" },
                    { "a125c220-f8e4-479d-b10a-96430da4d454", "00203633-435b-4c36-8ce8-bb0f9ca9b8a2", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 10, 585, DateTimeKind.Local).AddTicks(9233));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 10, 586, DateTimeKind.Local).AddTicks(309));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 10, 586, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 20, 10, 586, DateTimeKind.Local).AddTicks(320));
        }
    }
}
