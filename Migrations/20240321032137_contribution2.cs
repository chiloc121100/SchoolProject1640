using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class contribution2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6104), new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6118) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6121), new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6122) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6123), new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6124) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6126), new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6127) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6128), new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6129) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6131), new DateTime(2024, 3, 21, 10, 21, 37, 659, DateTimeKind.Local).AddTicks(6131) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3675), new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3685) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3687), new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3687) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3689), new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3689) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3691), new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3691) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3692), new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3693) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3694), new DateTime(2024, 3, 21, 9, 56, 42, 179, DateTimeKind.Local).AddTicks(3695) });
        }
    }
}
