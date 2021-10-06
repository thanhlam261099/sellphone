using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class InsertedRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "65933ab3-6571-4805-80b0-ec2700091023");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff3bf2ee-9769-4a37-8505-431c765530a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "51847987-577f-4c6b-9c9b-4e4231f2e63d", "f97ddb25-0a20-49d6-9687-4a044ee2fed3", "Visitor", "VISITOR" },
                    { "8a98a807-3e05-4e84-b1d5-da247d37f378", "6c5bf405-e734-41ab-b367-d0ba6187fc33", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 14, 918, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 14, 918, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 14, 918, DateTimeKind.Local).AddTicks(4291));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 14, 918, DateTimeKind.Local).AddTicks(4293));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "51847987-577f-4c6b-9c9b-4e4231f2e63d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8a98a807-3e05-4e84-b1d5-da247d37f378");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ff3bf2ee-9769-4a37-8505-431c765530a6", "20946ef6-2fee-4bf5-a236-5d14b9934af1", "Visitor", "VISITOR" },
                    { "65933ab3-6571-4805-80b0-ec2700091023", "edac26f4-cda5-4d32-9d82-8288c878ab3b", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 1, 576, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 1, 576, DateTimeKind.Local).AddTicks(2465));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 1, 576, DateTimeKind.Local).AddTicks(2472));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 6, 30, 10, 21, 1, 576, DateTimeKind.Local).AddTicks(2474));
        }
    }
}
