using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pet",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    type = table.Column<string>(type: "TEXT", nullable: true),
                    alias = table.Column<string>(type: "TEXT", nullable: true),
                    character = table.Column<string>(type: "TEXT", nullable: true),
                    size = table.Column<string>(type: "TEXT", nullable: true),
                    friendliness = table.Column<string>(type: "TEXT", nullable: true),
                    heatresistance = table.Column<string>(type: "TEXT", nullable: true),
                    coldtolerance = table.Column<string>(type: "TEXT", nullable: true),
                    detail = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pet", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Pet");
        }
    }
}
