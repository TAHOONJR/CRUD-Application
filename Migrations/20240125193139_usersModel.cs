using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class usersModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0ef01fbd-da3f-4c7e-ac24-ac6959529465", "84d94017-9e33-4664-9e12-bd81b1c09007", "Admin", "admin" },
                    { "5bd1811b-6fc4-4f80-967d-cd91746feca5", "e8408299-0993-47b0-8749-880a4e9ffbb1", "User", null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0ef01fbd-da3f-4c7e-ac24-ac6959529465");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5bd1811b-6fc4-4f80-967d-cd91746feca5");
        }
    }
}
