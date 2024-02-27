using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class clsRoles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6443e612-9ea8-4908-a185-7281153cd6d2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d26b567e-e605-48cf-a21e-8bb2f4fda59f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bd79c15b-d07a-4f8a-9c97-3698f16c535c", "7c5fa777-486a-4ce0-a557-4f3ad58136d4", "Admin", "admin" },
                    { "e3a183cb-f7fe-47be-9357-1034e493506f", "90c688a6-77d2-4dd1-844f-48d94638e332", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd79c15b-d07a-4f8a-9c97-3698f16c535c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e3a183cb-f7fe-47be-9357-1034e493506f");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6443e612-9ea8-4908-a185-7281153cd6d2", "7905bfab-a642-4931-b7d6-6e6bf8bb1d1f", "Admin", "admin" },
                    { "d26b567e-e605-48cf-a21e-8bb2f4fda59f", "6f906cab-ec2e-4721-b668-dd06971d2456", "User", "user" }
                });
        }
    }
}
