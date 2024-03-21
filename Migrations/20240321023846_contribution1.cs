using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SchoolProject1640.Migrations
{
    /// <inheritdoc />
    public partial class contribution1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Contribution",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AcademicYear = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ClosureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinalClosureDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contribution", x => x.Id);
                });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contribution");

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
    }
}
