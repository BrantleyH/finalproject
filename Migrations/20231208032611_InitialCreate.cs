using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace finalproject.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseballCard",
                columns: table => new
                {
                    BaseballCardID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", maxLength: 60, nullable: false),
                    CardPackage = table.Column<string>(type: "TEXT", maxLength: 40, nullable: false),
                    CardType = table.Column<string>(type: "TEXT", maxLength: 30, nullable: false),
                    CardNumber = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    CardCondition = table.Column<string>(type: "TEXT", maxLength: 5, nullable: false),
                    Price = table.Column<decimal>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseballCard", x => x.BaseballCardID);
                });

            migrationBuilder.CreateTable(
                name: "Owner",
                columns: table => new
                {
                    OwnerID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Ownership = table.Column<string>(type: "TEXT", nullable: false),
                    BaseballCardID = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owner", x => x.OwnerID);
                    table.ForeignKey(
                        name: "FK_Owner_BaseballCard_BaseballCardID",
                        column: x => x.BaseballCardID,
                        principalTable: "BaseballCard",
                        principalColumn: "BaseballCardID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Owner_BaseballCardID",
                table: "Owner",
                column: "BaseballCardID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Owner");

            migrationBuilder.DropTable(
                name: "BaseballCard");
        }
    }
}
