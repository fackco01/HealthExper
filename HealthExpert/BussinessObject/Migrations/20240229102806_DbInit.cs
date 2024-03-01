using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BussinessObject.Migrations
{
    /// <inheritdoc />
    public partial class DbInit : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "courseAdmins",
                columns: table => new
                {
                    courseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseAdmins", x => new { x.accountId, x.courseId });
                });

            migrationBuilder.CreateTable(
                name: "courseManagements",
                columns: table => new
                {
                    courseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    courseManagerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courseManagements", x => new { x.courseManagerId, x.courseId });
                });

            migrationBuilder.CreateTable(
                name: "roles",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_roles", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "courses",
                columns: table => new
                {
                    courseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    courseName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    price = table.Column<double>(type: "float", nullable: false),
                    rating = table.Column<double>(type: "float", nullable: false),
                    description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    studentNumber = table.Column<int>(type: "int", nullable: false),
                    certificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    dateUpdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bmiMin = table.Column<double>(type: "float", nullable: false),
                    bmiMax = table.Column<double>(type: "float", nullable: false),
                    typeId = table.Column<int>(type: "int", nullable: false),
                    courseAdminaccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    courseAdmincourseId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_courses", x => x.courseId);
                    table.ForeignKey(
                        name: "FK_courses_courseAdmins_courseAdminaccountId_courseAdmincourseId",
                        columns: x => new { x.courseAdminaccountId, x.courseAdmincourseId },
                        principalTable: "courseAdmins",
                        principalColumns: new[] { "accountId", "courseId" });
                });

            migrationBuilder.CreateTable(
                name: "accounts",
                columns: table => new
                {
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    gender = table.Column<bool>(type: "bit", nullable: false),
                    birthDate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false),
                    passwordHash = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    passwordSalt = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    verificationToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    verifiedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    passwordResetToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    resetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true),
                    courseAdminaccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    courseAdmincourseId = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    courseManagerId = table.Column<int>(type: "int", nullable: true),
                    courseManagercourseId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.accountId);
                    table.ForeignKey(
                        name: "FK_accounts_courseAdmins_courseAdminaccountId_courseAdmincourseId",
                        columns: x => new { x.courseAdminaccountId, x.courseAdmincourseId },
                        principalTable: "courseAdmins",
                        principalColumns: new[] { "accountId", "courseId" });
                    table.ForeignKey(
                        name: "FK_accounts_courseManagements_courseManagerId_courseManagercourseId",
                        columns: x => new { x.courseManagerId, x.courseManagercourseId },
                        principalTable: "courseManagements",
                        principalColumns: new[] { "courseManagerId", "courseId" });
                    table.ForeignKey(
                        name: "FK_accounts_roles_roleId",
                        column: x => x.roleId,
                        principalTable: "roles",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Course_CourseManager_Mapping",
                columns: table => new
                {
                    courseId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    courseManagerId = table.Column<int>(type: "int", nullable: false),
                    courseManagementcourseManagerId = table.Column<int>(type: "int", nullable: true),
                    courseManagementcourseId = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Course_CourseManager_Mapping", x => new { x.courseId, x.courseManagerId });
                    table.ForeignKey(
                        name: "FK_Course_CourseManager_Mapping_courseManagements_courseManagementcourseManagerId_courseManagementcourseId",
                        columns: x => new { x.courseManagementcourseManagerId, x.courseManagementcourseId },
                        principalTable: "courseManagements",
                        principalColumns: new[] { "courseManagerId", "courseId" });
                    table.ForeignKey(
                        name: "FK_Course_CourseManager_Mapping_courses_courseId",
                        column: x => x.courseId,
                        principalTable: "courses",
                        principalColumn: "courseId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "accomplishments",
                columns: table => new
                {
                    acplId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    acpltName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    acplDescription = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    receptDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accomplishments", x => x.acplId);
                    table.ForeignKey(
                        name: "FK_accomplishments_accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "accounts",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "avatars",
                columns: table => new
                {
                    avatarId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    avatarName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    avatarPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_avatars", x => x.avatarId);
                    table.ForeignKey(
                        name: "FK_avatars_accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "accounts",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "bmis",
                columns: table => new
                {
                    bmiId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    weight = table.Column<double>(type: "float", nullable: false),
                    height = table.Column<double>(type: "float", nullable: false),
                    bmiValue = table.Column<double>(type: "float", nullable: false),
                    bmiStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    bmiDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_bmis", x => x.bmiId);
                    table.ForeignKey(
                        name: "FK_bmis_accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "accounts",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "enrollments",
                columns: table => new
                {
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    enrollDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    enrollStatus = table.Column<bool>(type: "bit", nullable: false),
                    courseId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enrollments", x => new { x.accountId, x.courseId });
                    table.ForeignKey(
                        name: "FK_enrollments_accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "accounts",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_enrollments_courses_courseId1",
                        column: x => x.courseId1,
                        principalTable: "courses",
                        principalColumn: "courseId");
                });

            migrationBuilder.CreateTable(
                name: "feedbacks",
                columns: table => new
                {
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    courseId = table.Column<int>(type: "int", nullable: false),
                    feedbackId = table.Column<int>(type: "int", nullable: false),
                    detail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    courseId1 = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_feedbacks", x => new { x.accountId, x.courseId });
                    table.ForeignKey(
                        name: "FK_feedbacks_accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "accounts",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_feedbacks_courses_courseId1",
                        column: x => x.courseId1,
                        principalTable: "courses",
                        principalColumn: "courseId");
                });

            migrationBuilder.CreateTable(
                name: "photos",
                columns: table => new
                {
                    photoId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    photoName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    photoPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    uploadDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    isActive = table.Column<bool>(type: "bit", nullable: false),
                    accountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_photos", x => x.photoId);
                    table.ForeignKey(
                        name: "FK_photos_accounts_accountId",
                        column: x => x.accountId,
                        principalTable: "accounts",
                        principalColumn: "accountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "roles",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { 1, "Administration" },
                    { 2, "CourseAdmin" },
                    { 3, "CourseManager" },
                    { 4, "Learner" }
                });

            migrationBuilder.InsertData(
                table: "accounts",
                columns: new[] { "accountId", "birthDate", "courseAdminaccountId", "courseAdmincourseId", "courseManagerId", "courseManagercourseId", "createDate", "email", "fullName", "gender", "isActive", "password", "passwordHash", "passwordResetToken", "passwordSalt", "phone", "resetTokenExpires", "roleId", "userName", "verificationToken", "verifiedAt" },
                values: new object[] { new Guid("b488603d-ce50-49e4-87a1-19159f1c7824"), "01/01/1999", null, null, null, null, new DateTime(2024, 2, 29, 17, 28, 5, 946, DateTimeKind.Local).AddTicks(9000), "admin@gmail.com", "Administrator", true, true, "123123Aa!", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "012345678", null, 1, "admin", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_accomplishments_accountId",
                table: "accomplishments",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_accounts_courseAdminaccountId_courseAdmincourseId",
                table: "accounts",
                columns: new[] { "courseAdminaccountId", "courseAdmincourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_courseManagerId_courseManagercourseId",
                table: "accounts",
                columns: new[] { "courseManagerId", "courseManagercourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_accounts_roleId",
                table: "accounts",
                column: "roleId");

            migrationBuilder.CreateIndex(
                name: "IX_avatars_accountId",
                table: "avatars",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_bmis_accountId",
                table: "bmis",
                column: "accountId");

            migrationBuilder.CreateIndex(
                name: "IX_Course_CourseManager_Mapping_courseManagementcourseManagerId_courseManagementcourseId",
                table: "Course_CourseManager_Mapping",
                columns: new[] { "courseManagementcourseManagerId", "courseManagementcourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_courses_courseAdminaccountId_courseAdmincourseId",
                table: "courses",
                columns: new[] { "courseAdminaccountId", "courseAdmincourseId" });

            migrationBuilder.CreateIndex(
                name: "IX_enrollments_courseId1",
                table: "enrollments",
                column: "courseId1");

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_courseId1",
                table: "feedbacks",
                column: "courseId1");

            migrationBuilder.CreateIndex(
                name: "IX_photos_accountId",
                table: "photos",
                column: "accountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "accomplishments");

            migrationBuilder.DropTable(
                name: "avatars");

            migrationBuilder.DropTable(
                name: "bmis");

            migrationBuilder.DropTable(
                name: "Course_CourseManager_Mapping");

            migrationBuilder.DropTable(
                name: "enrollments");

            migrationBuilder.DropTable(
                name: "feedbacks");

            migrationBuilder.DropTable(
                name: "photos");

            migrationBuilder.DropTable(
                name: "courses");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "courseAdmins");

            migrationBuilder.DropTable(
                name: "courseManagements");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
