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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
