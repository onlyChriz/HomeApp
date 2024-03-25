using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HomeApp.Migrations
{
    /// <inheritdoc />
    public partial class UpdatedTaskModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDone",
                table: "ToDoTask",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDone",
                table: "ToDoTask");
        }
    }
}
