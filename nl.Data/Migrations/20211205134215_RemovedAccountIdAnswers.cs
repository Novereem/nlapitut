using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class RemovedAccountIdAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0b121309-cdc6-4edc-88e9-d8e1aa4201c7"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0c9702c6-e44a-4a82-bc6a-0624dc2d5287"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("11de9668-1dff-4f03-bd1e-6bdebe547949"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("21a1ca4b-d348-401d-acd0-ebe8819f8a8e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("23de5d94-b0da-4872-abbe-23daad6e5240"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3c5d834d-9878-4ba3-abc1-4b2e981849d8"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("503170fa-c859-4773-9872-9d3e3202cb5b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("cb8dc626-70cb-4ae3-8137-8d21b0fc8037"));

            migrationBuilder.DropColumn(
                name: "AccountId",
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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "AccountId",
                table: "Answer",
                type: "longtext",
                nullable: true)
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
        }
    }
}
