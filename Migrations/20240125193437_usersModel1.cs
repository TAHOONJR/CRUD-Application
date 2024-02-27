using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class usersModel1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ef01fbd-da3f-4c7e-ac24-ac6959529465");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bd1811b-6fc4-4f80-967d-cd91746feca5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9d8e3fb7-ab6f-4ca5-98ea-3ccaeb2890b8", "8e57eb41-ca94-45b9-b65a-35ff40699545", "User", "user" },
                    { "b6a1bf8f-dc6d-4990-b390-a57ff79e2084", "4a3f007d-d455-4cc6-9209-212a590eb871", "Admin", "admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d8e3fb7-ab6f-4ca5-98ea-3ccaeb2890b8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6a1bf8f-dc6d-4990-b390-a57ff79e2084");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ef01fbd-da3f-4c7e-ac24-ac6959529465", "84d94017-9e33-4664-9e12-bd81b1c09007", "Admin", "admin" },
                    { "5bd1811b-6fc4-4f80-967d-cd91746feca5", "e8408299-0993-47b0-8749-880a4e9ffbb1", "User", null }
                });
        }
    }
}
