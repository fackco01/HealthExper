using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BussinessObject.Migrations
{
    /// <inheritdoc />
    public partial class DbInitial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    roleId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    roleName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.roleId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    userId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    userName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    firstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    lastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    password = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    gender = table.Column<bool>(type: "bit", nullable: false),
                    createDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    roleId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.userId);
                    table.ForeignKey(
                        name: "FK_Users_Role_roleId",
                        column: x => x.roleId,
                        principalTable: "Role",
                        principalColumn: "roleId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Role",
                columns: new[] { "roleId", "roleName" },
                values: new object[,]
                {
                    { 1, "Administration" },
                    { 2, "Enterprise" },
                    { 3, "Customer" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "userId", "createDate", "email", "firstName", "gender", "lastName", "password", "phone", "roleId", "userName" },
                values: new object[] { new Guid("e4058a4d-2fec-4bfe-8b76-7e14917a3f56"), new DateTime(2023, 12, 5, 13, 57, 55, 653, DateTimeKind.Local).AddTicks(4943), "admin@gmail.com", "ADMIN", true, "01", "123123Aa!", "012345678", 1, "admin" });

            migrationBuilder.CreateIndex(
                name: "IX_Users_roleId",
                table: "Users",
                column: "roleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Role");
        }
    }
}
