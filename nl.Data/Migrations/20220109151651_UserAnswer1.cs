using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class UserAnswer1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswer_Results_ResultsId",
                table: "UserAnswer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnswer",
                table: "UserAnswer");

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("1296b17a-65d0-4a69-8c83-c14d0a2d5fd8"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("68a55585-afc4-4170-84c0-d19daf898b01"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7090a55d-1028-44ce-96b3-dc7ee776e673"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7e7e4c0f-ce41-4057-9048-5ea39f12b54b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("880a6ab6-9bd3-43d8-86a3-df0b9f1888ba"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("9b70fa13-7f0f-4af4-bc10-91c221f83e7e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b0a0ceb4-e749-40cd-ba47-d32a8b744187"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f702cb29-0b50-455d-90d4-122a257695dc"));

            migrationBuilder.RenameTable(
                name: "UserAnswer",
                newName: "UserAnswers");

            migrationBuilder.RenameIndex(
                name: "IX_UserAnswer_ResultsId",
                table: "UserAnswers",
                newName: "IX_UserAnswers_ResultsId");

            migrationBuilder.AddColumn<string>(
                name: "Token",
                table: "UserAnswers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnswers",
                table: "UserAnswers",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Laptops",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Price = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Usage = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Laptops", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("37779411-ca3e-4d79-b660-613fb0620eae"), 2, 1, "300-500" },
                    { new Guid("b0ac0a94-9497-445c-8660-c5bc63d1e713"), 2, 1, "500-800" },
                    { new Guid("0b01958a-f2e1-4c59-9b0d-d18da8b7e338"), 2, 1, "800-1200" },
                    { new Guid("71fe6b6e-5d48-420a-a5e2-69b2350c2e60"), 2, 1, "1200+" },
                    { new Guid("cc833676-d59a-4795-af96-fd85e8137c3a"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("91f0fd9c-31fc-42b9-ba41-2b518d605520"), 1, 2, "Documenten bewerken" },
                    { new Guid("0e97a48d-c000-4e58-abcc-7b29c809ea01"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("7975a95d-1a1a-48a4-99c1-14909fa3ea6a"), 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("e531bba8-65f8-4207-908d-516917502d7c"), "500", "Gamen" },
                    { new Guid("e3b72ffa-4c51-4237-ab50-c88da2a2373b"), "300", "Gamen" },
                    { new Guid("7e6449c3-891e-40d3-b8dc-0ac70b250b9e"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("a54e5258-d42c-490c-8a6e-297af72e3643"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("23331025-ba04-4828-9289-4a15106f1ebc"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("9695d863-3e5c-49cb-bdb5-b5c472f9d2f5"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("fac4a43a-c198-4adb-9414-3f7f7e82d70c"), "1200", "Documenten bewerken" },
                    { new Guid("1b9a5c4e-8cf8-4ba0-9bf0-37bae6cab99e"), "1200", "Mail" },
                    { new Guid("591ff4a4-2c33-43d3-8f74-064281662f93"), "500", "Documenten bewerken" },
                    { new Guid("e9988d16-ab79-4786-a4e7-77ab9ee09b01"), "300", "Documenten bewerken" },
                    { new Guid("dafb6aa7-5212-4c97-b399-e53f67ff2013"), "800", "Gamen" },
                    { new Guid("8993cdb4-48d9-4634-aba2-f1896466cdd9"), "800", "Mail" },
                    { new Guid("5b64c264-2681-4fcd-8d79-6eac537a2078"), "500", "Mail" },
                    { new Guid("a29fefd4-b4aa-427a-ad0a-82b4dbfdc179"), "300", "Mail" },
                    { new Guid("fd6bb4a1-8372-4ecd-bfee-b99425f61a5f"), "800", "Documenten bewerken" },
                    { new Guid("f8f758be-aa67-46e1-906e-4abb6b0b1c6d"), "1200", "Gamen" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_Results_ResultsId",
                table: "UserAnswers",
                column: "ResultsId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_Results_ResultsId",
                table: "UserAnswers");

            migrationBuilder.DropTable(
                name: "Laptops");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserAnswers",
                table: "UserAnswers");

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0b01958a-f2e1-4c59-9b0d-d18da8b7e338"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0e97a48d-c000-4e58-abcc-7b29c809ea01"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("37779411-ca3e-4d79-b660-613fb0620eae"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("71fe6b6e-5d48-420a-a5e2-69b2350c2e60"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7975a95d-1a1a-48a4-99c1-14909fa3ea6a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("91f0fd9c-31fc-42b9-ba41-2b518d605520"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b0ac0a94-9497-445c-8660-c5bc63d1e713"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("cc833676-d59a-4795-af96-fd85e8137c3a"));

            migrationBuilder.DropColumn(
                name: "Token",
                table: "UserAnswers");

            migrationBuilder.RenameTable(
                name: "UserAnswers",
                newName: "UserAnswer");

            migrationBuilder.RenameIndex(
                name: "IX_UserAnswers_ResultsId",
                table: "UserAnswer",
                newName: "IX_UserAnswer_ResultsId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserAnswer",
                table: "UserAnswer",
                column: "Id");

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("f702cb29-0b50-455d-90d4-122a257695dc"), 2, 1, "300-500" },
                    { new Guid("7e7e4c0f-ce41-4057-9048-5ea39f12b54b"), 2, 1, "500-800" },
                    { new Guid("1296b17a-65d0-4a69-8c83-c14d0a2d5fd8"), 2, 1, "800-1200" },
                    { new Guid("68a55585-afc4-4170-84c0-d19daf898b01"), 2, 1, "1200+" },
                    { new Guid("b0a0ceb4-e749-40cd-ba47-d32a8b744187"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("7090a55d-1028-44ce-96b3-dc7ee776e673"), 1, 2, "Documenten bewerken" },
                    { new Guid("9b70fa13-7f0f-4af4-bc10-91c221f83e7e"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("880a6ab6-9bd3-43d8-86a3-df0b9f1888ba"), 1, 2, "Gamen" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswer_Results_ResultsId",
                table: "UserAnswer",
                column: "ResultsId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
