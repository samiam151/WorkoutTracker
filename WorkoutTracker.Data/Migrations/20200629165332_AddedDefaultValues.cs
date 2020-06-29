using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WorkoutTracker.Data.Migrations
{
    public partial class AddedDefaultValues : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Muscles",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MuscleGroups",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MovementsMuscleGroups",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Movements",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "MovementPatterns",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedAt",
                table: "Equipment",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "CreatedAt", "IsActive", "MovementId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 29, 16, 53, 32, 293, DateTimeKind.Utc).AddTicks(449), true, null, "Barbell" },
                    { 2, new DateTime(2020, 6, 29, 16, 53, 32, 293, DateTimeKind.Utc).AddTicks(477), true, null, "Dumbell" },
                    { 3, new DateTime(2020, 6, 29, 16, 53, 32, 293, DateTimeKind.Utc).AddTicks(480), true, null, "Jump Rope" },
                    { 4, new DateTime(2020, 6, 29, 16, 53, 32, 293, DateTimeKind.Utc).AddTicks(482), true, null, "Bench" }
                });

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 53, 32, 291, DateTimeKind.Utc).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 53, 32, 291, DateTimeKind.Utc).AddTicks(8451));

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 53, 32, 291, DateTimeKind.Utc).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 53, 32, 291, DateTimeKind.Utc).AddTicks(8473));

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 53, 32, 291, DateTimeKind.Utc).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 6, 29, 16, 53, 32, 291, DateTimeKind.Utc).AddTicks(8477));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Equipment",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Muscles");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MuscleGroups");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MovementsMuscleGroups");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Movements");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "MovementPatterns");

            migrationBuilder.DropColumn(
                name: "UpdatedAt",
                table: "Equipment");

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: null);

            migrationBuilder.UpdateData(
                table: "MovementPatterns",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: null);
        }
    }
}
