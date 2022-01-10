using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class answerdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("26c50887-64eb-447c-bdcd-e597144fd04d"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("49466a1b-aa6a-4cca-bee0-b7bb3cc84fc0"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("4c090277-858a-49cb-84a8-447e47096a17"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("4fb3e94a-0c24-4caa-8f5c-db3c36ca5723"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("a6c8731f-f2ca-45a2-9f0b-c0a18628488b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("c433cd38-7ae7-44e8-b903-82ccbc2dc538"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ccde1b84-09e6-4cd5-bef6-19ac088ee8be"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ffb04f72-20dd-4923-a3a4-740e0926d088"));

            migrationBuilder.AddColumn<Guid>(
                name: "ResultsId",
                table: "Answer",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.CreateTable(
                name: "Results",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Results", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Answer_Results_ResultsId",
                table: "Answer");

            migrationBuilder.DropTable(
                name: "Results");

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

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("ffb04f72-20dd-4923-a3a4-740e0926d088"), 2, 1, "300-500" },
                    { new Guid("49466a1b-aa6a-4cca-bee0-b7bb3cc84fc0"), 2, 1, "500-800" },
                    { new Guid("c433cd38-7ae7-44e8-b903-82ccbc2dc538"), 2, 1, "800-1200" },
                    { new Guid("26c50887-64eb-447c-bdcd-e597144fd04d"), 2, 1, "1200+" },
                    { new Guid("4fb3e94a-0c24-4caa-8f5c-db3c36ca5723"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("4c090277-858a-49cb-84a8-447e47096a17"), 1, 2, "Documenten bewerken" },
                    { new Guid("ccde1b84-09e6-4cd5-bef6-19ac088ee8be"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("a6c8731f-f2ca-45a2-9f0b-c0a18628488b"), 1, 2, "Gamen" }
                });
        }
    }
}
