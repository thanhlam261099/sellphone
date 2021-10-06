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
                keyValue: "24d09004-1db8-4f56-8cc5-3c07eaaee004");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ade24056-ac13-4295-8c7f-63b4d64f7dc4");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bee2b82d-ea7b-4678-a689-c57d9cef0060", "665bf8fe-5426-49e6-b581-1ab885f5263d", "Visitor", "VISITOR" },
                    { "83e05ae9-ba7a-4147-908f-6077bdbe13f9", "bfc41664-4dc1-4c96-8ff6-fb6954fc4488", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 58, 68, DateTimeKind.Local).AddTicks(9225));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 58, 69, DateTimeKind.Local).AddTicks(196));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 58, 69, DateTimeKind.Local).AddTicks(203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 58, 69, DateTimeKind.Local).AddTicks(205));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "83e05ae9-ba7a-4147-908f-6077bdbe13f9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bee2b82d-ea7b-4678-a689-c57d9cef0060");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ade24056-ac13-4295-8c7f-63b4d64f7dc4", "71da1907-032b-4b35-8393-3aee7680bb66", "Visitor", "VISITOR" },
                    { "24d09004-1db8-4f56-8cc5-3c07eaaee004", "5dd69102-3f69-47bd-a46c-e0298827dafb", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 45, 289, DateTimeKind.Local).AddTicks(5408));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 45, 289, DateTimeKind.Local).AddTicks(6632));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 45, 289, DateTimeKind.Local).AddTicks(6642));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2020, 7, 19, 8, 56, 45, 289, DateTimeKind.Local).AddTicks(6644));
        }
    }
}
