﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApplication2.Data;

namespace WebApplication2.Migrations
{
    [DbContext(typeof(CmsContext))]
    partial class CmsContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApplication2.Models.Admin", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Admins");
                });

            modelBuilder.Entity("WebApplication2.Models.Categories", b =>
                {
                    b.Property<int>("CategoriesID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("TrainingstaffID")
                        .HasColumnType("int");

                    b.HasKey("CategoriesID");

                    b.HasIndex("TrainingstaffID");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("WebApplication2.Models.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CategoriesID")
                        .HasColumnType("int");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseID");

                    b.HasIndex("CategoriesID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("WebApplication2.Models.Topic", b =>
                {
                    b.Property<int>("TopicID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int?>("CourseID")
                        .HasColumnType("int");

                    b.Property<string>("Descriptions")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TopicID");

                    b.HasIndex("CourseID");

                    b.ToTable("Topics");
                });

            modelBuilder.Entity("WebApplication2.Models.TopicTrainer", b =>
                {
                    b.Property<int>("TrainerID")
                        .HasColumnType("int");

                    b.Property<int>("TopicID")
                        .HasColumnType("int");

                    b.HasKey("TrainerID", "TopicID");

                    b.HasIndex("TopicID");

                    b.ToTable("TopicTrainers");
                });

            modelBuilder.Entity("WebApplication2.Models.Trainee", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Education")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TOEICScore")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trainees");
                });

            modelBuilder.Entity("WebApplication2.Models.TraineevCourse", b =>
                {
                    b.Property<int>("TraineeID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.HasKey("TraineeID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("TraineevCourses");
                });

            modelBuilder.Entity("WebApplication2.Models.Trainer", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WorkingPlace")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trainers");
                });

            modelBuilder.Entity("WebApplication2.Models.Trainingstaff", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Edu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Experience")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassWord")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Trainningstaffs");
                });

            modelBuilder.Entity("WebApplication2.Models.Categories", b =>
                {
                    b.HasOne("WebApplication2.Models.Trainingstaff", "Trainingstaff")
                        .WithMany("Categories")
                        .HasForeignKey("TrainingstaffID");

                    b.Navigation("Trainingstaff");
                });

            modelBuilder.Entity("WebApplication2.Models.Course", b =>
                {
                    b.HasOne("WebApplication2.Models.Categories", "Categories")
                        .WithMany()
                        .HasForeignKey("CategoriesID");

                    b.Navigation("Categories");
                });

            modelBuilder.Entity("WebApplication2.Models.Topic", b =>
                {
                    b.HasOne("WebApplication2.Models.Course", "Course")
                        .WithMany("Topics")
                        .HasForeignKey("CourseID");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("WebApplication2.Models.TopicTrainer", b =>
                {
                    b.HasOne("WebApplication2.Models.Topic", "Topic")
                        .WithMany("TopicTrainers")
                        .HasForeignKey("TopicID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.Trainer", "Trainer")
                        .WithMany("TopicTrainers")
                        .HasForeignKey("TrainerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");

                    b.Navigation("Trainer");
                });

            modelBuilder.Entity("WebApplication2.Models.TraineevCourse", b =>
                {
                    b.HasOne("WebApplication2.Models.Course", "Course")
                        .WithMany("TraineevCourses")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApplication2.Models.Trainee", "Trainee")
                        .WithMany("TraineevCourses")
                        .HasForeignKey("TraineeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Trainee");
                });

            modelBuilder.Entity("WebApplication2.Models.Course", b =>
                {
                    b.Navigation("Topics");

                    b.Navigation("TraineevCourses");
                });

            modelBuilder.Entity("WebApplication2.Models.Topic", b =>
                {
                    b.Navigation("TopicTrainers");
                });

            modelBuilder.Entity("WebApplication2.Models.Trainee", b =>
                {
                    b.Navigation("TraineevCourses");
                });

            modelBuilder.Entity("WebApplication2.Models.Trainer", b =>
                {
                    b.Navigation("TopicTrainers");
                });

            modelBuilder.Entity("WebApplication2.Models.Trainingstaff", b =>
                {
                    b.Navigation("Categories");
                });
#pragma warning restore 612, 618
        }
    }
}
