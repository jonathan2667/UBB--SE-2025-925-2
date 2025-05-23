﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Workout.Core.Data;

#nullable disable

namespace Workout.Core.Migrations
{
    [DbContext(typeof(WorkoutDbContext))]
    [Migration("20250506060906_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Workout.Core.Models.CalendarDayModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("DayNumber")
                        .HasColumnType("int");

                    b.Property<int>("GridColumn")
                        .HasColumnType("int");

                    b.Property<int>("GridRow")
                        .HasColumnType("int");

                    b.Property<bool>("HasClass")
                        .HasColumnType("bit");

                    b.Property<bool>("HasWorkout")
                        .HasColumnType("bit");

                    b.Property<bool>("IsCurrentDay")
                        .HasColumnType("bit");

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("bit");

                    b.Property<bool>("IsWorkoutCompleted")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("CalendarDays");
                });

            modelBuilder.Entity("Workout.Core.Models.ClassModel", b =>
                {
                    b.Property<int>("CID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CID"));

                    b.Property<int>("CTID")
                        .HasColumnType("int")
                        .HasColumnName("CTID");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("PTID")
                        .HasColumnType("int")
                        .HasColumnName("PTID");

                    b.HasKey("CID");

                    b.HasIndex("CTID");

                    b.HasIndex("PTID");

                    b.ToTable("Classes", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.ClassTypeModel", b =>
                {
                    b.Property<int>("CTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("CTID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CTID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("CTID");

                    b.ToTable("ClassTypes", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.CompleteWorkoutModel", b =>
                {
                    b.Property<int>("WID")
                        .HasColumnType("int")
                        .HasColumnName("WID");

                    b.Property<int>("EID")
                        .HasColumnType("int")
                        .HasColumnName("EID");

                    b.Property<int>("RepsPerSet")
                        .HasColumnType("int")
                        .HasColumnName("RepsPerSet");

                    b.Property<int>("Sets")
                        .HasColumnType("int");

                    b.HasKey("WID", "EID");

                    b.HasIndex("EID");

                    b.ToTable("CompleteWorkouts", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.ExercisesModel", b =>
                {
                    b.Property<int>("EID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("EID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("VARCHAR(MAX)");

                    b.Property<int>("Difficulty")
                        .HasColumnType("int");

                    b.Property<int>("MGID")
                        .HasColumnType("int")
                        .HasColumnName("MGID");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("EID");

                    b.HasIndex("MGID");

                    b.ToTable("Exercises", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.MuscleGroupModel", b =>
                {
                    b.Property<int>("MGID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MGID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MGID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("MGID");

                    b.ToTable("MuscleGroups", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.PersonalTrainerModel", b =>
                {
                    b.Property<int>("PTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("PTID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PTID"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime>("WorksSince")
                        .HasColumnType("datetime2")
                        .HasColumnName("WorksSince");

                    b.HasKey("PTID");

                    b.ToTable("PersonalTrainers", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.RankDefinition", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("ColorArgb")
                        .HasColumnType("int")
                        .HasColumnName("ColorValue");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("nvarchar(255)");

                    b.Property<int>("MaxPoints")
                        .HasColumnType("int");

                    b.Property<int>("MinPoints")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("RankDefinitions", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.RankingModel", b =>
                {
                    b.Property<int>("UID")
                        .HasColumnType("int")
                        .HasColumnName("UID");

                    b.Property<int>("MGID")
                        .HasColumnType("int")
                        .HasColumnName("MGID");

                    b.Property<int>("Rank")
                        .HasColumnType("int")
                        .HasColumnName("Rank");

                    b.HasKey("UID", "MGID");

                    b.HasIndex("MGID");

                    b.ToTable("Rankings", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.UserClassModel", b =>
                {
                    b.Property<int>("UID")
                        .HasColumnType("int")
                        .HasColumnName("UID");

                    b.Property<int>("CID")
                        .HasColumnType("int")
                        .HasColumnName("CID");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.HasKey("UID", "CID", "Date");

                    b.HasIndex("CID");

                    b.ToTable("UserClasses", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.UserModel", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("UID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.HasKey("ID");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.UserWorkoutModel", b =>
                {
                    b.Property<int>("UID")
                        .HasColumnType("int")
                        .HasColumnName("UID");

                    b.Property<int>("WID")
                        .HasColumnType("int")
                        .HasColumnName("WID");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2")
                        .HasColumnName("Date");

                    b.Property<bool>("Completed")
                        .HasColumnType("bit");

                    b.HasKey("UID", "WID", "Date");

                    b.HasIndex("WID");

                    b.ToTable("UserWorkouts", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.WorkoutModel", b =>
                {
                    b.Property<int>("WID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<int>("WTID")
                        .HasColumnType("int")
                        .HasColumnName("WTID");

                    b.HasKey("WID");

                    b.HasIndex("WTID");

                    b.ToTable("Workouts", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.WorkoutTypeModel", b =>
                {
                    b.Property<int>("WTID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("WTID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("WTID"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("WTID");

                    b.ToTable("WorkoutTypes", (string)null);
                });

            modelBuilder.Entity("Workout.Core.Models.ClassModel", b =>
                {
                    b.HasOne("Workout.Core.Models.ClassTypeModel", "ClassType")
                        .WithMany()
                        .HasForeignKey("CTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workout.Core.Models.PersonalTrainerModel", "PersonalTrainer")
                        .WithMany()
                        .HasForeignKey("PTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ClassType");

                    b.Navigation("PersonalTrainer");
                });

            modelBuilder.Entity("Workout.Core.Models.CompleteWorkoutModel", b =>
                {
                    b.HasOne("Workout.Core.Models.ExercisesModel", "Exercise")
                        .WithMany()
                        .HasForeignKey("EID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workout.Core.Models.WorkoutModel", "Workout")
                        .WithMany("CompleteWorkouts")
                        .HasForeignKey("WID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Exercise");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("Workout.Core.Models.ExercisesModel", b =>
                {
                    b.HasOne("Workout.Core.Models.MuscleGroupModel", "MuscleGroup")
                        .WithMany()
                        .HasForeignKey("MGID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MuscleGroup");
                });

            modelBuilder.Entity("Workout.Core.Models.RankingModel", b =>
                {
                    b.HasOne("Workout.Core.Models.MuscleGroupModel", "MuscleGroup")
                        .WithMany()
                        .HasForeignKey("MGID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workout.Core.Models.UserModel", "User")
                        .WithMany("Rankings")
                        .HasForeignKey("UID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("MuscleGroup");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Workout.Core.Models.UserClassModel", b =>
                {
                    b.HasOne("Workout.Core.Models.ClassModel", "Class")
                        .WithMany("UserClasses")
                        .HasForeignKey("CID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workout.Core.Models.UserModel", "User")
                        .WithMany("UserClasses")
                        .HasForeignKey("UID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Class");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Workout.Core.Models.UserWorkoutModel", b =>
                {
                    b.HasOne("Workout.Core.Models.UserModel", "User")
                        .WithMany("UserWorkouts")
                        .HasForeignKey("UID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Workout.Core.Models.WorkoutModel", "Workout")
                        .WithMany("UserWorkouts")
                        .HasForeignKey("WID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");

                    b.Navigation("Workout");
                });

            modelBuilder.Entity("Workout.Core.Models.WorkoutModel", b =>
                {
                    b.HasOne("Workout.Core.Models.WorkoutTypeModel", "WorkoutType")
                        .WithMany()
                        .HasForeignKey("WTID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkoutType");
                });

            modelBuilder.Entity("Workout.Core.Models.ClassModel", b =>
                {
                    b.Navigation("UserClasses");
                });

            modelBuilder.Entity("Workout.Core.Models.UserModel", b =>
                {
                    b.Navigation("Rankings");

                    b.Navigation("UserClasses");

                    b.Navigation("UserWorkouts");
                });

            modelBuilder.Entity("Workout.Core.Models.WorkoutModel", b =>
                {
                    b.Navigation("CompleteWorkouts");

                    b.Navigation("UserWorkouts");
                });
#pragma warning restore 612, 618
        }
    }
}
