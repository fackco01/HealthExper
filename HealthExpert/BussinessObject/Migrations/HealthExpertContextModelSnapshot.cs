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

                    b.ToTable("roles");

                    b.HasData(
                        new
                        {
                            roleId = 1,
                            roleName = "Administration"
                        },
                        new
                        {
                            roleId = 2,
                            roleName = "CourseAdmin"
                        },
                        new
                        {
                            roleId = 3,
                            roleName = "CourseManager"
                        },
                        new
                        {
                            roleId = 4,
                            roleName = "Learner"
                        });
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Accomplishment", b =>
                {
                    b.Property<int>("acplId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("acplId"));

                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("acplDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("acpltName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("receptDate")
                        .HasColumnType("datetime2");
                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");
                        .HasColumnType("uniqueidentifier");
                    b.HasKey("acplId");
                    b.Property<string>("acplDescription")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                        .HasColumnType("nvarchar(max)");
                    b.HasIndex("accountId");
                    b.Property<string>("acpltName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                        .HasColumnType("nvarchar(max)");
                    b.ToTable("accomplishments");
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Account", b =>
                {
                    b.Property<Guid>("accountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("gender")
                        .HasColumnType("bit");
                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("receptDate")
                        .HasColumnType("datetime2");
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");
                    b.HasIndex("accountId");
                    b.Property<bool>("isActive")
                    b.Property<byte[]>("passwordHash")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("passwordResetToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("passwordSalt")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("resetTokenExpires")
                        .HasColumnType("datetime2");

                    b.Property<int>("roleId")
                        .HasColumnType("int");

                    b.Property<string>("userName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("verificationToken")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("verifiedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("accountId");

                    b.HasIndex("roleId");

                    b.ToTable("accounts");

                    b.HasData(
                        new
                        {
                            accountId = new Guid("762b8750-4554-4301-ad16-ff6ce64c7675"),
                            birthDate = "01/01/1999",
                            createDate = new DateTime(2024, 2, 11, 16, 22, 51, 964, DateTimeKind.Local).AddTicks(26),
                            email = "admin@gmail.com",
                            fullName = "Administrator",
                            gender = true,
                            isActive = true,
                            password = "123123Aa!",
                            passwordHash = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            passwordSalt = new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 },
                            phone = "012345678",
                            roleId = 1,
                            userName = "admin"
                        });
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Avatar", b =>
                {
                    b.Property<int>("avatarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("avatarId"));

                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("avatarName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("avatarPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("uploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("avatarId");

                    b.HasIndex("accountId");

                    b.ToTable("avatars");
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Photo", b =>
                {
                    b.Property<int>("photoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("photoId"));
                    b.ToTable("accomplishments");
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Account", b =>
                {
                    b.Property<Guid>("accountId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("birthDate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("createDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("fullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

            modelBuilder.Entity("BussinessObject.Model.FilePayment.Payment", b =>
                {
                    b.Property<int>("paymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("photoName")
                    b.Property<string>("password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("phone")
                        .IsRequired()

                    b.Property<DateTime>("paymentDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("paymentStatus")
                    b.Property<Guid>("userId")
                    b.Property<DateTime>("uploadDate")
                        .HasColumnType("datetime2");
                    b.HasIndex("roleId");

                    b.ToTable("accounts");

                    b.HasData(
                        new
                        {
                            accountId = new Guid("2f65e949-9f94-4241-92ea-cca248f69f09"),
                            birthDate = "01/01/1999",
                            createDate = new DateTime(2024, 1, 31, 19, 56, 57, 483, DateTimeKind.Local).AddTicks(8454),
                            email = "admin@gmail.com",
                            fullName = "Administrator",
                            gender = true,
                            isActive = true,
                            password = "123123Aa!",
                            phone = "012345678",
                            roleId = 1,
                            userName = "admin"
                        });
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Avatar", b =>
                {
                    b.Property<int>("avatarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");
                    b.Property<string>("postTitle")
                    b.HasKey("photoId");
                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("avatarId"));
                        .HasColumnType("nvarchar(max)");
                    b.HasIndex("accountId");
                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");
                        .HasColumnType("uniqueidentifier");
                    b.ToTable("photos");
                });
                    b.Property<string>("avatarName")
                        .HasColumnType("nvarchar(max)");

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Accomplishment", b =>
                {
                    b.HasOne("BussinessObject.Model.ModelUser.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                    b.Property<string>("avatarPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");
                    b.Property<int>("commentId")
                    b.Navigation("account");
                    b.Property<bool>("isActive")
                        .HasColumnType("bit");

                    b.Property<DateTime>("uploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("avatarId");

                    b.HasIndex("accountId");

                    b.ToTable("avatars");
                        .HasColumnType("int");

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Account", b =>
            modelBuilder.Entity("BussinessObject.Model.ModelUser.Photo", b =>

                    b.HasOne("BussinessObject.Model.Authen.Role", "role")
                        .WithMany("account")
                        .HasForeignKey("roleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                    b.Property<int>("photoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("photoId"));

                    b.Navigation("role");
                });
                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("isActive")
                        .HasColumnType("bit");
                    b.Property<int>("postId")
            modelBuilder.Entity("BussinessObject.Model.ModelUser.Avatar", b =>
                {
                    b.HasOne("BussinessObject.Model.ModelUser.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                    b.Property<string>("photoName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("photoPath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("uploadDate")
                        .HasColumnType("datetime2");

                    b.HasKey("photoId");

                    b.HasIndex("accountId");
                    b.Property<Guid>("userId")
                    b.Navigation("account");
                    b.ToTable("photos");
                        .HasColumnType("uniqueidentifier");

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Photo", b =>
            modelBuilder.Entity("BussinessObject.Model.ModelUser.Accomplishment", b =>
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("birthDate")
                        .HasForeignKey("accountId")
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Account", b =>
                {
                    b.HasOne("BussinessObject.Model.Authen.Role", "role")
                        .WithMany("account")
                        .HasForeignKey("roleId")

                    b.Property<string>("firstName")
                        .IsRequired()
                    b.Navigation("account");
                    b.Navigation("role");

            modelBuilder.Entity("BussinessObject.Model.FilePayment.Payment", b =>
                {
                    b.Property<int>("paymentId")
                    b.Navigation("account");
                    b.HasOne("BussinessObject.Model.ModelUser.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Photo", b =>
                {
                    b.HasOne("BussinessObject.Model.ModelUser.Account", "account")
                        .WithMany()
                        .HasForeignKey("accountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("account");
                });

            modelBuilder.Entity("BussinessObject.Model.Authen.Role", b =>
                {
                    b.Navigation("account");
                    b.HasKey("userId");

                    b.HasIndex("businessId");

                    b.HasIndex("roleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userId = new Guid("3c4160af-0342-4983-aa90-5c3660c4851e"),
                            birthDate = "01/01/1999",
                            createDate = new DateTime(2024, 1, 8, 16, 9, 3, 658, DateTimeKind.Local).AddTicks(2886),
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
                    b.Property<string>("postTitle")
                    b.Navigation("User");
                });
                        .HasColumnType("nvarchar(max)");
            modelBuilder.Entity("BussinessObject.Model.FileCourse.Course", b =>
                {
                    b.HasOne("BussinessObject.Model.Business", "Business")
                        .WithMany()
                        .HasForeignKey("businessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                        .HasColumnType("uniqueidentifier");
                    b.Navigation("Business");
                });

            modelBuilder.Entity("BussinessObject.Model.FileCourse.CourseContent", b =>
                {
                    b.HasOne("BussinessObject.Model.FileCourse.Course", "Course")
                        .WithMany()
                        .HasForeignKey("courseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                    b.Property<int>("commentId")
                    b.Navigation("Course");
                        .HasColumnType("int");

            modelBuilder.Entity("BussinessObject.Model.FileCourse.Enrollment", b =>

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
                    b.Property<int>("postId")
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
                    b.Property<Guid>("userId")
                    b.Navigation("User");
                        .HasColumnType("uniqueidentifier");

            modelBuilder.Entity("BussinessObject.Model.FilePost.PostComment", b =>
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("birthDate")
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

                    b.Property<string>("firstName")
                        .IsRequired()
                    b.Navigation("Role");

                    b.Property<Guid>("accountId")
                        .HasColumnType("uniqueidentifier");

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
                    b.HasKey("userId");

                    b.HasIndex("businessId");

                    b.HasIndex("roleId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            userId = new Guid("3c4160af-0342-4983-aa90-5c3660c4851e"),
                            birthDate = "01/01/1999",
                            createDate = new DateTime(2024, 1, 8, 16, 9, 3, 658, DateTimeKind.Local).AddTicks(2886),
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
                    b.HasOne("BussinessObject.Model.ModelUser.Account", "account")
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

            modelBuilder.Entity("BussinessObject.Model.ModelUser.Avatar", b =>
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
