using Microsoft.EntityFrameworkCore.Migrations;

namespace AuthBE.Migrations
{
    public partial class asd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Login = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Email", "Login", "Name", "Password", "Surname" },
                values: new object[] { 1, null, "admin", "Gleb", "12345", "Ivanov" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "IdUser", "Email", "Login", "Name", "Password", "Surname" },
                values: new object[] { 2, null, "admin1", "Lena", "123", "Mishchuk" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");
        }
    }
}
