using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Lab2.Migrations
{
    public partial class CreatingIdentity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
