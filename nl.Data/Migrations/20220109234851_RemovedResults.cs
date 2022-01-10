using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class RemovedResults : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserAnswers_Results_ResultsId",
                table: "UserAnswers");

            migrationBuilder.DropTable(
                name: "Results");

            migrationBuilder.DropIndex(
                name: "IX_UserAnswers_ResultsId",
                table: "UserAnswers");

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2b5ce723-7a3f-4c6e-8646-439cedbd9fba"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3a406580-84d9-4328-9399-5a689cd773c3"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3b749dcd-80bf-497b-afbe-3c0a40876039"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("44c2e711-4dd0-4f33-be6c-194e8e0f5902"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("81805e59-e9f4-4a6e-acb1-471fc59b2d04"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("a15a32ec-15f9-4f09-be7b-26261830c56a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("e18395bd-c59b-408f-a061-bc6de617a695"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("eb8c78d5-65b5-4491-9146-830ad015cddd"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("1670f5d3-c968-4445-8234-bcc471fabdbf"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("2913ed4e-8428-434b-9c8f-a87a3cee29a1"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("345ed0c4-b262-4eae-936a-f0afeeb20241"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("54a00091-81cf-4cc1-ad72-2de6eef2354f"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("59935cc8-3c2d-4a62-8215-c03f29d85da0"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("6e539712-624b-480f-aaf1-d677e11d2bb4"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("721bb2a2-2dd9-48e2-9176-98d81630556a"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("8861a4f7-7d34-40a5-84ac-e5263e08bd12"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("906843e3-3558-44fb-a5d0-4c8b8081b525"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("9a4c7f72-7009-4a48-a80e-0605ae022d0c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("ae33df09-5cbb-49f6-b6da-4880c541547b"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("d40e0259-3f47-4df8-b4d9-ea58b9312bfb"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("d8d169a7-939a-4a8b-a7e1-bff676a1c1ec"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("f6173813-1949-40d3-8f33-c7f6ad97d77d"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("fa1db5ce-b06c-49ed-9ba5-183a7c4036fc"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("fc6c4f0a-291c-4b49-93ff-972c07f9baf2"));

            migrationBuilder.DropColumn(
                name: "AnswerId",
                table: "UserAnswers");

            migrationBuilder.DropColumn(
                name: "ResultsId",
                table: "UserAnswers");

            migrationBuilder.AddColumn<Guid>(
                name: "UserAnswerId",
                table: "SingeAnswers",
                type: "char(36)",
                nullable: true,
                collation: "ascii_general_ci");

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("0d9878c6-4214-4418-8fbc-65cdd83fee97"), 2, 1, "300-500" },
                    { new Guid("91fb710c-77c6-4d81-998e-161bb1797c08"), 2, 1, "500-800" },
                    { new Guid("778ed6ed-6a53-4429-8b5c-b4cbbec39737"), 2, 1, "800-1200" },
                    { new Guid("b0c359cb-38ee-4c58-891b-f8203468cbc3"), 2, 1, "1200+" },
                    { new Guid("8d0a1695-688a-43c7-8299-bd397fbbaa31"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("ea6830ca-de89-4642-9fad-ff2251b4682c"), 1, 2, "Documenten bewerken" },
                    { new Guid("c56fe364-d8a5-44cc-bdf8-ed960e6267e2"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("fe881e88-d814-4808-a701-afc60b1b9797"), 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("719ebf8c-7ca1-46a1-a1b8-ca834c13e9ed"), "500", "Gamen" },
                    { new Guid("3b719fed-6b61-4458-bc4f-287452b115f4"), "300", "Gamen" },
                    { new Guid("81ce27b0-3e96-4be0-a814-6c887503fe7d"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("54d953f6-fefe-436e-a2c9-849f1d4287d9"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("2998d8d9-f63d-4098-9dba-84ed4127d63c"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("6066cd41-fda8-46dd-bbd5-22444e9a398e"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("ff93f7fa-187e-4594-996e-988a96348b90"), "1200", "Documenten bewerken" },
                    { new Guid("be4cf46a-c44d-41a6-82a2-2d7ddced8989"), "1200", "Mail" },
                    { new Guid("38cd137a-25ad-4e04-af42-1dde67bab85c"), "500", "Documenten bewerken" },
                    { new Guid("47d16dd4-5b56-4b09-bfc4-da5681cd0d5d"), "300", "Documenten bewerken" },
                    { new Guid("b5c96f2d-1d5f-47e1-8d08-33fe15b16ed8"), "800", "Gamen" },
                    { new Guid("16c5a7f3-8ab1-4509-859f-ad0c3de2ed03"), "800", "Mail" },
                    { new Guid("91e5fa60-23ef-4b92-a713-b37cd1b830e7"), "500", "Mail" },
                    { new Guid("ae926ae9-eae1-4a12-9d06-6aeae7413ecf"), "300", "Mail" },
                    { new Guid("76c03d6b-82bb-47f1-88ce-6ad7305c12dd"), "800", "Documenten bewerken" },
                    { new Guid("4718836b-2787-491f-a35b-78f97f828677"), "1200", "Gamen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_SingeAnswers_UserAnswerId",
                table: "SingeAnswers",
                column: "UserAnswerId");

            migrationBuilder.AddForeignKey(
                name: "FK_SingeAnswers_UserAnswers_UserAnswerId",
                table: "SingeAnswers",
                column: "UserAnswerId",
                principalTable: "UserAnswers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_SingeAnswers_UserAnswers_UserAnswerId",
                table: "SingeAnswers");

            migrationBuilder.DropIndex(
                name: "IX_SingeAnswers_UserAnswerId",
                table: "SingeAnswers");

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0d9878c6-4214-4418-8fbc-65cdd83fee97"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("778ed6ed-6a53-4429-8b5c-b4cbbec39737"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("8d0a1695-688a-43c7-8299-bd397fbbaa31"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("91fb710c-77c6-4d81-998e-161bb1797c08"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b0c359cb-38ee-4c58-891b-f8203468cbc3"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("c56fe364-d8a5-44cc-bdf8-ed960e6267e2"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ea6830ca-de89-4642-9fad-ff2251b4682c"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("fe881e88-d814-4808-a701-afc60b1b9797"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("16c5a7f3-8ab1-4509-859f-ad0c3de2ed03"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("2998d8d9-f63d-4098-9dba-84ed4127d63c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("38cd137a-25ad-4e04-af42-1dde67bab85c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("3b719fed-6b61-4458-bc4f-287452b115f4"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("4718836b-2787-491f-a35b-78f97f828677"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("47d16dd4-5b56-4b09-bfc4-da5681cd0d5d"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("54d953f6-fefe-436e-a2c9-849f1d4287d9"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("6066cd41-fda8-46dd-bbd5-22444e9a398e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("719ebf8c-7ca1-46a1-a1b8-ca834c13e9ed"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("76c03d6b-82bb-47f1-88ce-6ad7305c12dd"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("81ce27b0-3e96-4be0-a814-6c887503fe7d"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("91e5fa60-23ef-4b92-a713-b37cd1b830e7"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("ae926ae9-eae1-4a12-9d06-6aeae7413ecf"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("b5c96f2d-1d5f-47e1-8d08-33fe15b16ed8"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("be4cf46a-c44d-41a6-82a2-2d7ddced8989"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("ff93f7fa-187e-4594-996e-988a96348b90"));

            migrationBuilder.DropColumn(
                name: "UserAnswerId",
                table: "SingeAnswers");

            migrationBuilder.AddColumn<string>(
                name: "AnswerId",
                table: "UserAnswers",
                type: "longtext",
                nullable: true)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<Guid>(
                name: "ResultsId",
                table: "UserAnswers",
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
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("eb8c78d5-65b5-4491-9146-830ad015cddd"), 2, 1, "300-500" },
                    { new Guid("2b5ce723-7a3f-4c6e-8646-439cedbd9fba"), 2, 1, "500-800" },
                    { new Guid("81805e59-e9f4-4a6e-acb1-471fc59b2d04"), 2, 1, "800-1200" },
                    { new Guid("e18395bd-c59b-408f-a061-bc6de617a695"), 2, 1, "1200+" },
                    { new Guid("a15a32ec-15f9-4f09-be7b-26261830c56a"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("3a406580-84d9-4328-9399-5a689cd773c3"), 1, 2, "Documenten bewerken" },
                    { new Guid("44c2e711-4dd0-4f33-be6c-194e8e0f5902"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("3b749dcd-80bf-497b-afbe-3c0a40876039"), 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("54a00091-81cf-4cc1-ad72-2de6eef2354f"), "500", "Gamen" },
                    { new Guid("906843e3-3558-44fb-a5d0-4c8b8081b525"), "300", "Gamen" },
                    { new Guid("d8d169a7-939a-4a8b-a7e1-bff676a1c1ec"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("2913ed4e-8428-434b-9c8f-a87a3cee29a1"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("721bb2a2-2dd9-48e2-9176-98d81630556a"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("d40e0259-3f47-4df8-b4d9-ea58b9312bfb"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("6e539712-624b-480f-aaf1-d677e11d2bb4"), "1200", "Documenten bewerken" },
                    { new Guid("fc6c4f0a-291c-4b49-93ff-972c07f9baf2"), "1200", "Mail" },
                    { new Guid("fa1db5ce-b06c-49ed-9ba5-183a7c4036fc"), "500", "Documenten bewerken" },
                    { new Guid("ae33df09-5cbb-49f6-b6da-4880c541547b"), "300", "Documenten bewerken" },
                    { new Guid("1670f5d3-c968-4445-8234-bcc471fabdbf"), "800", "Gamen" },
                    { new Guid("f6173813-1949-40d3-8f33-c7f6ad97d77d"), "800", "Mail" },
                    { new Guid("59935cc8-3c2d-4a62-8215-c03f29d85da0"), "500", "Mail" },
                    { new Guid("345ed0c4-b262-4eae-936a-f0afeeb20241"), "300", "Mail" },
                    { new Guid("8861a4f7-7d34-40a5-84ac-e5263e08bd12"), "800", "Documenten bewerken" },
                    { new Guid("9a4c7f72-7009-4a48-a80e-0605ae022d0c"), "1200", "Gamen" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAnswers_ResultsId",
                table: "UserAnswers",
                column: "ResultsId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserAnswers_Results_ResultsId",
                table: "UserAnswers",
                column: "ResultsId",
                principalTable: "Results",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
