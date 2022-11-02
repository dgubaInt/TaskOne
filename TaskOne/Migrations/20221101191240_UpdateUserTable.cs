using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskOne.Migrations
{
    public partial class UpdateUserTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LName",
                table: "Users",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "FName",
                table: "Users",
                newName: "FirstName");

            migrationBuilder.AlterColumn<string>(
                name: "Option",
                table: "Users",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Users",
                newName: "LName");

            migrationBuilder.RenameColumn(
                name: "FirstName",
                table: "Users",
                newName: "FName");

            migrationBuilder.AlterColumn<int>(
                name: "Option",
                table: "Users",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
