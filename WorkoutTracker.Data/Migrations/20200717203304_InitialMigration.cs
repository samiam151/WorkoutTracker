using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace WorkoutTracker.Data.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MovementPatterns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementPatterns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "MuscleGroups",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MuscleGroups", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Movements",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    PatternId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movements", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Movements_MovementPatterns_PatternId",
                        column: x => x.PatternId,
                        principalTable: "MovementPatterns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Equipment",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    MovementId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Equipment", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Equipment_Movements_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MovementsMuscleGroups",
                columns: table => new
                {
                    MovementId = table.Column<int>(nullable: false),
                    MusclGroupId = table.Column<int>(nullable: false),
                    Id = table.Column<int>(nullable: false),
                    CreatedAt = table.Column<DateTime>(nullable: true),
                    UpdatedAt = table.Column<DateTime>(nullable: true),
                    MuscleGroupId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MovementsMuscleGroups", x => new { x.MovementId, x.MusclGroupId });
                    table.ForeignKey(
                        name: "FK_MovementsMuscleGroups_Movements_MovementId",
                        column: x => x.MovementId,
                        principalTable: "Movements",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MovementsMuscleGroups_MuscleGroups_MuscleGroupId",
                        column: x => x.MuscleGroupId,
                        principalTable: "MuscleGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Equipment",
                columns: new[] { "Id", "CreatedAt", "IsActive", "MovementId", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(1489), true, null, "Barbell" },
                    { 2, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(1521), true, null, "Dumbell" },
                    { 3, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(1525), true, null, "Jump Rope" },
                    { 4, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(1527), true, null, "Bench" }
                });

            migrationBuilder.InsertData(
                table: "MovementPatterns",
                columns: new[] { "Id", "CreatedAt", "Description", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 17, 20, 33, 3, 828, DateTimeKind.Utc).AddTicks(5363), null, true, "Hinge" },
                    { 2, new DateTime(2020, 7, 17, 20, 33, 3, 828, DateTimeKind.Utc).AddTicks(6844), null, true, "Squat" },
                    { 3, new DateTime(2020, 7, 17, 20, 33, 3, 828, DateTimeKind.Utc).AddTicks(6870), null, true, "Lunge" },
                    { 4, new DateTime(2020, 7, 17, 20, 33, 3, 828, DateTimeKind.Utc).AddTicks(6873), null, true, "Push" },
                    { 5, new DateTime(2020, 7, 17, 20, 33, 3, 828, DateTimeKind.Utc).AddTicks(6875), null, true, "Pull" },
                    { 6, new DateTime(2020, 7, 17, 20, 33, 3, 828, DateTimeKind.Utc).AddTicks(6878), null, true, "Carry" }
                });

            migrationBuilder.InsertData(
                table: "WorkoutTypes",
                columns: new[] { "Id", "CreatedAt", "IsActive", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(2446), true, "Full" },
                    { 2, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(2471), true, "Strength" },
                    { 3, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(2475), true, "Metabolic Conditioning" },
                    { 4, new DateTime(2020, 7, 17, 20, 33, 3, 830, DateTimeKind.Utc).AddTicks(2477), true, "Active Recovery" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Equipment_MovementId",
                table: "Equipment",
                column: "MovementId");

            migrationBuilder.CreateIndex(
                name: "IX_Movements_PatternId",
                table: "Movements",
                column: "PatternId");

            migrationBuilder.CreateIndex(
                name: "IX_MovementsMuscleGroups_MuscleGroupId",
                table: "MovementsMuscleGroups",
                column: "MuscleGroupId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Equipment");

            migrationBuilder.DropTable(
                name: "MovementsMuscleGroups");

            migrationBuilder.DropTable(
                name: "WorkoutTypes");

            migrationBuilder.DropTable(
                name: "Movements");

            migrationBuilder.DropTable(
                name: "MuscleGroups");

            migrationBuilder.DropTable(
                name: "MovementPatterns");
        }
    }
}
