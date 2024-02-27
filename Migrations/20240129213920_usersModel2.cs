using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WebApplication1.Migrations
{
    /// <inheritdoc />
    public partial class usersModel2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "6443e612-9ea8-4908-a185-7281153cd6d2", "7905bfab-a642-4931-b7d6-6e6bf8bb1d1f", "Admin", "admin" },
                    { "d26b567e-e605-48cf-a21e-8bb2f4fda59f", "6f906cab-ec2e-4721-b668-dd06971d2456", "User", "user" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "9d8e3fb7-ab6f-4ca5-98ea-3ccaeb2890b8", "8e57eb41-ca94-45b9-b65a-35ff40699545", "User", "user" },
                    { "b6a1bf8f-dc6d-4990-b390-a57ff79e2084", "4a3f007d-d455-4cc6-9209-212a590eb871", "Admin", "admin" }
                });
        }
    }
}
