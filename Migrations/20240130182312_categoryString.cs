using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class categoryString : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd79c15b-d07a-4f8a-9c97-3698f16c535c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3a183cb-f7fe-47be-9357-1034e493506f");

            migrationBuilder.AlterColumn<string>(
                name: "CategoryId",
                table: "Items",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "33dadd1a-b3b2-4fd7-b422-63b2cfdec8bc", "2ab6fb13-27bd-46bf-8103-3897d93b2ae5", "User", "user" },
                    { "c418f275-ac75-490f-822a-ab877ae53fd1", "589ff24f-3ca2-47fa-95b5-34692feddea2", "Admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "33dadd1a-b3b2-4fd7-b422-63b2cfdec8bc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c418f275-ac75-490f-822a-ab877ae53fd1");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryId",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd79c15b-d07a-4f8a-9c97-3698f16c535c", "7c5fa777-486a-4ce0-a557-4f3ad58136d4", "Admin", "admin" },
                    { "e3a183cb-f7fe-47be-9357-1034e493506f", "90c688a6-77d2-4dd1-844f-48d94638e332", "User", "user" }
                });
        }
    }
}
