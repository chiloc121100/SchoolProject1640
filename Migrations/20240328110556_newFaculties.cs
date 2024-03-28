using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class newFaculties : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9764), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9776) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9778), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9778) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9779), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9780) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9781), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9782) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9783), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9783) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9784), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9785) });

            migrationBuilder.InsertData(
                table: "Faculty",
                columns: new[] { "Id", "CreatedAt", "Description", "Name", "UpdatedAt" },
                values: new object[,]
                {
                    { "7", new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9786), "Faculty of Admin", "Admin", new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9786) },
                    { "8", new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9787), "Faculty of Manager", "Manager", new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9788) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "8");

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
    }
}
