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
                keyValue: "c678621f-dfe9-44aa-8e1f-2eae70e30619");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "edcaeb4c-5ef8-4720-98dc-92b7bfcf49e0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1c3c9dd4-5e8a-4e4f-ad55-a2381132f132", "cdb02262-0508-4d75-ac8b-6662d634f323", "Visitor", "VISITOR" },
                    { "7bf2b1ca-120b-4724-80b0-d14cefcbd569", "72776ff3-8e83-4f1f-a2f1-ea18a7f573f8", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 28, 391, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 28, 392, DateTimeKind.Local).AddTicks(836));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 28, 392, DateTimeKind.Local).AddTicks(843));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 28, 392, DateTimeKind.Local).AddTicks(845));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c3c9dd4-5e8a-4e4f-ad55-a2381132f132");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7bf2b1ca-120b-4724-80b0-d14cefcbd569");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c678621f-dfe9-44aa-8e1f-2eae70e30619", "94bd9da8-ea18-457c-8c1e-cca682f7792d", "Visitor", "VISITOR" },
                    { "edcaeb4c-5ef8-4720-98dc-92b7bfcf49e0", "c7602941-3fe6-42cc-bd3b-475214e97478", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 55, 49, 260, DateTimeKind.Local).AddTicks(2847));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 55, 49, 260, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 55, 49, 260, DateTimeKind.Local).AddTicks(4526));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 55, 49, 260, DateTimeKind.Local).AddTicks(4529));
        }
    }
}
