﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WorkoutTracker.Data.Models;

namespace WorkoutTracker.Data.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20200630210257_AddedWorkoutType")]
    partial class AddedWorkoutType
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("WorkoutTracker.Data.Models.Entities.MovementsMuscleGroups", b =>
                {
                    b.Property<int>("MovementId")
                        .HasColumnType("integer");

                    b.Property<int>("MusclGroupId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<int>("Id")
                        .HasColumnType("integer");

                    b.Property<int?>("MuscleGroupId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("MovementId", "MusclGroupId");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("MovementsMuscleGroups");
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.Equipment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int?>("MovementId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MovementId");

                    b.ToTable("Equipment");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9761),
                            IsActive = true,
                            Name = "Barbell",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9768)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9783),
                            IsActive = true,
                            Name = "Dumbell",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9784)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9785),
                            IsActive = true,
                            Name = "Jump Rope",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9786)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9787),
                            IsActive = true,
                            Name = "Bench",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 582, DateTimeKind.Utc).AddTicks(9788)
                        });
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.Movement", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<int?>("PatternId")
                        .HasColumnType("integer");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("PatternId");

                    b.ToTable("Movements");
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.MovementPattern", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("MovementPatterns");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(8332),
                            IsActive = true,
                            Name = "Hinge",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(8413)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9448),
                            IsActive = true,
                            Name = "Squat",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9452)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9465),
                            IsActive = true,
                            Name = "Lunge",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9466)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9467),
                            IsActive = true,
                            Name = "Push",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9467)
                        },
                        new
                        {
                            Id = 5,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9468),
                            IsActive = true,
                            Name = "Pull",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9469)
                        },
                        new
                        {
                            Id = 6,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9470),
                            IsActive = true,
                            Name = "Carry",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 581, DateTimeKind.Utc).AddTicks(9471)
                        });
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.Muscle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<int?>("MuscleGroupId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("MuscleGroupId");

                    b.ToTable("Muscles");
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.MuscleGroup", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("MuscleGroups");
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.WorkoutType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime?>("CreatedAt")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .ValueGeneratedOnAddOrUpdate()
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("WorkoutTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(422),
                            IsActive = true,
                            Name = "Full",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(425)
                        },
                        new
                        {
                            Id = 2,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(438),
                            IsActive = true,
                            Name = "Strength",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(439)
                        },
                        new
                        {
                            Id = 3,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(481),
                            IsActive = true,
                            Name = "Metabolic Conditioning",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(482)
                        },
                        new
                        {
                            Id = 4,
                            CreatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(483),
                            IsActive = true,
                            Name = "Active Recovery",
                            UpdatedAt = new DateTime(2020, 6, 30, 21, 2, 57, 583, DateTimeKind.Utc).AddTicks(484)
                        });
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.Entities.MovementsMuscleGroups", b =>
                {
                    b.HasOne("WorkoutTracker.Data.Models.Movement", "Movement")
                        .WithMany("MovementsMuscleGroups")
                        .HasForeignKey("MovementId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WorkoutTracker.Data.Models.MuscleGroup", "MuscleGroup")
                        .WithMany("MovementsMuscleGroups")
                        .HasForeignKey("MuscleGroupId");
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.Equipment", b =>
                {
                    b.HasOne("WorkoutTracker.Data.Models.Movement", null)
                        .WithMany("EquipmentNeeded")
                        .HasForeignKey("MovementId");
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.Movement", b =>
                {
                    b.HasOne("WorkoutTracker.Data.Models.MovementPattern", "Pattern")
                        .WithMany()
                        .HasForeignKey("PatternId");
                });

            modelBuilder.Entity("WorkoutTracker.Data.Models.Muscle", b =>
                {
                    b.HasOne("WorkoutTracker.Data.Models.MuscleGroup", null)
                        .WithMany("MusclesWorked")
                        .HasForeignKey("MuscleGroupId");
                });
#pragma warning restore 612, 618
        }
    }
}
