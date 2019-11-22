using Microsoft.EntityFrameworkCore.Migrations;

namespace Collectors.Migrations
{
    public partial class collectors : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a772c8dd-0024-4650-bbfa-f4a4d91f8d7e", "AQAAAAEAACcQAAAAEBoDGc4+myvix0+ZbsARQR4o3M9zkpdJN55mPfQelIxO5j1Ej7a8Y3n6fSpQxkiMWQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "00000000-ffff-ffff-ffff-ffffffffffff",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f068fbd1-5111-4a88-bc23-a06fae4318e4", "AQAAAAEAACcQAAAAECzy525QcCgkO6PeIK9JpucnUY8/3xYHOMy/GjHLKFp87bmGT0ZVaCIpqLhP8wJgww==" });
        }
    }
}
