using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class UserAnswer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Results_ResultsId",
                table: "Answer");

            migrationBuilder.DropIndex(
                name: "IX_Answer_ResultsId",
                table: "Answer");

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0a773ef6-962f-473d-bf81-4d2debcadd29"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("1f9cc97a-2938-4779-8ce7-3fbba83416cb"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("26e3351a-50e0-4988-8a52-43fb3deab1b4"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("4d1321cb-6726-4620-aedc-16fc0c62c74e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("6f74d08f-07e1-4544-b440-6fd1f0fd3914"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("76ac7dbf-8c8c-4e88-a339-c8504d73a6f1"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("78b5c186-58db-49ca-9c70-19c661ca1412"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("92b391da-519c-4282-975a-dbdeb6f0ac9d"));

            migrationBuilder.DropColumn(
                name: "ResultsId",
                table: "Answer");

            migrationBuilder.CreateTable(
                name: "UserAnswer",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AnswerId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    ResultsId = table.Column<Guid>(type: "char(36)", nullable: true, collation: "ascii_general_ci")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAnswer", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAnswer_Results_ResultsId",
                        column: x => x.ResultsId,
                        principalTable: "Results",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswer_ResultsId",
                table: "UserAnswer",
                column: "ResultsId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAnswer");

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

            migrationBuilder.AddColumn<Guid>(
                name: "ResultsId",
                table: "Answer",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "ResultsId", "Text" },
                values: new object[,]
                {
                    { new Guid("76ac7dbf-8c8c-4e88-a339-c8504d73a6f1"), 2, 1, null, "300-500" },
                    { new Guid("4d1321cb-6726-4620-aedc-16fc0c62c74e"), 2, 1, null, "500-800" },
                    { new Guid("26e3351a-50e0-4988-8a52-43fb3deab1b4"), 2, 1, null, "800-1200" },
                    { new Guid("0a773ef6-962f-473d-bf81-4d2debcadd29"), 2, 1, null, "1200+" },
                    { new Guid("92b391da-519c-4282-975a-dbdeb6f0ac9d"), 1, 2, null, "Mail / Netflix & YouTube" },
                    { new Guid("6f74d08f-07e1-4544-b440-6fd1f0fd3914"), 1, 2, null, "Documenten bewerken" },
                    { new Guid("1f9cc97a-2938-4779-8ce7-3fbba83416cb"), 1, 2, null, "Foto's/videdo's bewerken" },
                    { new Guid("78b5c186-58db-49ca-9c70-19c661ca1412"), 1, 2, null, "Gamen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Answer_ResultsId",
                table: "Answer",
                column: "ResultsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Answer_Results_ResultsId",
                table: "Answer",
                column: "ResultsId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
