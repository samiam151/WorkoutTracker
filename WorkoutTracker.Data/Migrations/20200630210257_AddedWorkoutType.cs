using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WorkoutTracker.Data.Migrations
{
    public partial class AddedWorkoutType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WorkoutTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkoutTypes", x => x.Id);
                });


            migrationBuilder.InsertData(
                table: "WorkoutTypes",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(422), true, "Full" },
                    { 2, new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(438), true, "Strength" },
                    { 3, new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(481), true, "Metabolic Conditioning" },
                    { 4, new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(483), true, "Active Recovery" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WorkoutTypes");

        }
    }
}
