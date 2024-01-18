﻿// <auto-generated />
using System;
using BussinessObject.ContextData;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BussinessObject.Migrations
{
    [DbContext(typeof(HealthExpertContext))]
    partial class HealthExpertContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BussinessObject.Model.Authen.Role", b =>
                {
                    b.Property<int>("roleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("roleId"));

                    b.Property<string>("roleName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("roleId");

                    b.ToTable("Roles");

                    b.HasData(
                        new
                        {
                            roleId = 1,
                            roleName = "Administration"
                        },
                        new
                        {
                            roleId = 2,
                            roleName = "Enterprise"
                        },
                        new
                        {
                            roleId = 3,
                            roleName = "Customer"
                        });
                });

            modelBuilder.Entity("BussinessObject.Model.BMI", b =>
                {
                    b.Property<int>("bmiId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("bmiId"));

                    b.Property<DateTime>("captureDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("height")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoAfter")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoBefore")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("value")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("weight")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("bmiId");

                    b.HasIndex("userId")
                        .IsUnique();

                    b.ToTable("BMIs");
                });

            modelBuilder.Entity("BussinessObject.Model.Business", b =>
                {
                    b.Property<int>("businessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("businessId"));

                    b.Property<string>("address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("businessName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("businessId");

                    b.ToTable("Businesss");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.Course", b =>
                {
                    b.Property<int>("courseId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("courseId"));

                    b.Property<int>("businessId")
                        .HasColumnType("int");

                    b.Property<string>("courseName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("rate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("courseId");

                    b.HasIndex("businessId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.CourseContent", b =>
                {
                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<string>("title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("video")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasIndex("courseId");

                    b.ToTable("CourseContents");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.Enrollment", b =>
                {
                    b.Property<int>("enrollmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("enrollmentId"));

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("enrollmentDate")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("enrollmentId");

                    b.HasIndex("courseId");

                    b.HasIndex("userId");

                    b.ToTable("Enrollments");
                });

            modelBuilder.Entity("BussinessObject.Model.FilePayment.Payment", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("paymentId"));

                    b.Property<int>("courseId")
                        .HasColumnType("int");

                    b.Property<decimal>("paymentAmount")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("paymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("paymentStatus")
                        .HasColumnType("int");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("paymentId");

                    b.HasIndex("courseId");

                    b.HasIndex("userId");

                    b.ToTable("Payment");
                });

            modelBuilder.Entity("BussinessObject.Model.FilePost.Post", b =>
                {
                    b.Property<int>("postId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("postId"));

                    b.Property<string>("postContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("postDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("postTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("userId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("postId");

                    b.HasIndex("userId");

                    b.ToTable("Posts");
                });

            modelBuilder.Entity("BussinessObject.Model.FilePost.PostComment", b =>
                {
                    b.Property<int>("commentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("commentId"));

                    b.Property<Guid?>("UsersuserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("commentDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("commentText")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("postId")
                        .HasColumnType("int");

                    b.HasKey("commentId");

                    b.HasIndex("UsersuserId");

                    b.HasIndex("postId");

                    b.ToTable("PostComments");
                });

            modelBuilder.Entity("BussinessObject.Model.User", b =>
                {
                    b.Property<Guid>("userId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("avatar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("businessId")
                        .HasColumnType("int");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("firstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gender")
                        .HasColumnType("bit");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<string>("lastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("wallpaper")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("userId");

                    b.HasIndex("businessId");

                    b.HasIndex("roleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userId = new Guid("86982e04-cab0-465b-9825-48431d0e4fbc"),
                            birthDate = "01/01/1999",
                            createDate = new DateTime(2024, 1, 16, 16, 50, 15, 82, DateTimeKind.Local).AddTicks(5572),
                            email = "admin@gmail.com",
                            firstName = "ADMIN",
                            gender = true,
                            isActive = true,
                            lastName = "01",
                            password = "123123Aa!",
                            phone = "012345678",
                            roleId = 1,
                            userName = "admin"
                        });
                });

            modelBuilder.Entity("BussinessObject.Model.BMI", b =>
                {
                    b.HasOne("BussinessObject.Model.User", "User")
                        .WithOne("BMI")
                        .HasForeignKey("BussinessObject.Model.BMI", "userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.Course", b =>
                {
                    b.HasOne("BussinessObject.Model.Business", "Business")
                        .WithMany()
                        .HasForeignKey("businessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.CourseContent", b =>
                {
                    b.HasOne("BussinessObject.Model.FileCourse.Course", "Course")
                        .WithMany()
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.Enrollment", b =>
                {
                    b.HasOne("BussinessObject.Model.FileCourse.Course", "Course")
                        .WithMany("Enrollments")
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BussinessObject.Model.User", "User")
                        .WithMany("Enrollments")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObject.Model.FilePayment.Payment", b =>
                {
                    b.HasOne("BussinessObject.Model.FileCourse.Course", "Course")
                        .WithMany()
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BussinessObject.Model.User", "User")
                        .WithMany()
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObject.Model.FilePost.Post", b =>
                {
                    b.HasOne("BussinessObject.Model.User", "User")
                        .WithMany("Posts")
                        .HasForeignKey("userId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("BussinessObject.Model.FilePost.PostComment", b =>
                {
                    b.HasOne("BussinessObject.Model.User", "Users")
                        .WithMany()
                        .HasForeignKey("UsersuserId");

                    b.HasOne("BussinessObject.Model.FilePost.Post", "Post")
                        .WithMany("PostComments")
                        .HasForeignKey("postId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Post");

                    b.Navigation("Users");
                });

            modelBuilder.Entity("BussinessObject.Model.User", b =>
                {
                    b.HasOne("BussinessObject.Model.Business", null)
                        .WithMany("Users")
                        .HasForeignKey("businessId");

                    b.HasOne("BussinessObject.Model.Authen.Role", "Role")
                        .WithMany("users")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");
                });

            modelBuilder.Entity("BussinessObject.Model.Authen.Role", b =>
                {
                    b.Navigation("users");
                });

            modelBuilder.Entity("BussinessObject.Model.Business", b =>
                {
                    b.Navigation("Users");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.Course", b =>
                {
                    b.Navigation("Enrollments");
                });

            modelBuilder.Entity("BussinessObject.Model.FilePost.Post", b =>
                {
                    b.Navigation("PostComments");
                });

            modelBuilder.Entity("BussinessObject.Model.User", b =>
                {
                    b.Navigation("BMI");

                    b.Navigation("Enrollments");

                    b.Navigation("Posts");
                });
#pragma warning restore 612, 618
        }
    }
}
