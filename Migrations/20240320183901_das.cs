using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class das : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(992), new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1003) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1005), new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1006) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1007), new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1008) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1009), new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1010) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1011), new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1012) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1013), new DateTime(2024, 3, 21, 1, 39, 1, 374, DateTimeKind.Local).AddTicks(1013) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8880), new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8890) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8892), new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8892) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8894), new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8894) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8895), new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8896) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8897), new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8898) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8899), new DateTime(2024, 3, 21, 1, 36, 55, 970, DateTimeKind.Local).AddTicks(8899) });
        }
    }
}
