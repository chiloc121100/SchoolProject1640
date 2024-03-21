using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class contribution : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5637), new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5677) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5679), new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5679) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5681), new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5681) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5683), new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5684) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5685), new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5686) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5687), new DateTime(2024, 3, 21, 9, 37, 19, 726, DateTimeKind.Local).AddTicks(5688) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
