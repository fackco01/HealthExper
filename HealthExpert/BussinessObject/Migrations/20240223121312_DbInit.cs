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
                    resetTokenExpires = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_accounts", x => x.accountId);
                    table.ForeignKey(
                        name: "FK_accounts_roles_roleId",
                        column: x => x.roleId,
                        principalTable: "roles",
                        principalColumn: "roleId",
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
                columns: new[] { "accountId", "birthDate", "createDate", "email", "fullName", "gender", "isActive", "password", "passwordHash", "passwordResetToken", "passwordSalt", "phone", "resetTokenExpires", "roleId", "userName", "verificationToken", "verifiedAt" },
                values: new object[] { new Guid("747e347d-7ea3-47b2-b7bc-77365c8bef93"), "01/01/1999", new DateTime(2024, 2, 23, 19, 13, 12, 372, DateTimeKind.Local).AddTicks(313), "admin@gmail.com", "Administrator", true, true, "123123Aa!", new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, null, new byte[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }, "012345678", null, 1, "admin", null, null });

            migrationBuilder.CreateIndex(
                name: "IX_accomplishments_accountId",
                table: "accomplishments",
                column: "accountId");

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
                name: "photos");

            migrationBuilder.DropTable(
                name: "accounts");

            migrationBuilder.DropTable(
                name: "roles");
        }
    }
}
