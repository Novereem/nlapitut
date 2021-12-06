using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Answer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    QuestionId = table.Column<int>(type: "int", nullable: false),
                    NextQuestionId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    AccountId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Answer", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Text = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "AccountId", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("cb8dc626-70cb-4ae3-8137-8d21b0fc8037"), null, 2, 1, "300-500" },
                    { new Guid("0b121309-cdc6-4edc-88e9-d8e1aa4201c7"), null, 2, 1, "500-800" },
                    { new Guid("3c5d834d-9878-4ba3-abc1-4b2e981849d8"), null, 2, 1, "800-1200" },
                    { new Guid("11de9668-1dff-4f03-bd1e-6bdebe547949"), null, 2, 1, "1200+" },
                    { new Guid("503170fa-c859-4773-9872-9d3e3202cb5b"), null, 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("21a1ca4b-d348-401d-acd0-ebe8819f8a8e"), null, 1, 2, "Documenten bewerken" },
                    { new Guid("0c9702c6-e44a-4a82-bc6a-0624dc2d5287"), null, 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("23de5d94-b0da-4872-abbe-23daad6e5240"), null, 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 1, "Hoeveel geld wilt u besteden?" },
                    { 2, "Waar ga je je laptop voor gebruiken" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Answer");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
