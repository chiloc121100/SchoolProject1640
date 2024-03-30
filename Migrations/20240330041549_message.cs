using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class message : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AccountID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ArtID = table.Column<int>(type: "int", nullable: true),
                    Mess = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "1",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2409), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2419) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "2",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2421), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2421) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "3",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2423), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2423) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "4",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2424), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2425) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "5",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2426), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2426) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "6",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2427), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2428) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2429), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2429) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2430), new DateTime(2024, 3, 30, 11, 15, 49, 268, DateTimeKind.Local).AddTicks(2431) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message");

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

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "7",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9786), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9786) });

            migrationBuilder.UpdateData(
                table: "Faculty",
                keyColumn: "Id",
                keyValue: "8",
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9787), new DateTime(2024, 3, 28, 18, 5, 56, 829, DateTimeKind.Local).AddTicks(9788) });
        }
    }
}
