using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Blog.v1.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class dbGeneralUpdate3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    BlockDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Contents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: true),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CategoryId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedOn = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contents_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Contents_Users_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CreatedOn", "ModifiedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3069), new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3078), "AI" },
                    { 2, new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3080), new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3081), "Web" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDate", "BlockDate", "CreatedOn", "Email", "FirstName", "IsActive", "LastName", "ModifiedOn", "Name", "Password", "PhoneNumber", "UserName" },
                values: new object[] { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3356), "bnurdursun@gmail.com", "Admin", true, "adm", new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3356), "adm", "1234", "1234567890", "admin" });

            migrationBuilder.InsertData(
                table: "Contents",
                columns: new[] { "Id", "AuthorId", "CategoryId", "Content", "CreatedOn", "ModifiedOn", "Name", "Title" },
                values: new object[,]
                {
                    { 1, null, 2, "Web content deneme 1", new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3317), new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3318), "Web Subject1", "Web Content Title 1" },
                    { 2, null, 2, "Web content deneme 1", new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3323), new DateTime(2024, 5, 11, 11, 35, 4, 555, DateTimeKind.Utc).AddTicks(3323), "Web Subject1", "Web Content Title 1" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Contents_AuthorId",
                table: "Contents",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Contents_CategoryId",
                table: "Contents",
                column: "CategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Contents");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
