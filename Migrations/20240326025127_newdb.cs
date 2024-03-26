using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class newdb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6889), new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6899) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6901), new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6902) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6903), new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6904) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6905), new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6905) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6907), new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6907) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6908), new DateTime(2024, 3, 26, 9, 51, 27, 112, DateTimeKind.Local).AddTicks(6909) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3060), new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3070) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3072), new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3072) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3074), new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3074) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3076), new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3076) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3078), new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3078) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3079), new DateTime(2024, 3, 26, 9, 48, 57, 590, DateTimeKind.Local).AddTicks(3080) });
        }
    }
}
