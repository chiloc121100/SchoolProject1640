using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class adfacultyintocontribusion : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Faculty",
                table: "Contribution",
                type: "nvarchar(max)",
                nullable: true);

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Faculty",
                table: "Contribution");

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1522), new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1533) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1535), new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1535) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1537), new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1538) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1539), new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1540) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1542), new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1542) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1544), new DateTime(2024, 3, 21, 9, 38, 46, 172, DateTimeKind.Local).AddTicks(1545) });
        }
    }
}
