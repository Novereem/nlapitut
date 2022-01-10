using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class TempSingleAnswers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "SingleAnswerTemp",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "char(36)", nullable: false, collation: "ascii_general_ci"),
                    AnswerId = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Token = table.Column<string>(type: "longtext", nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SingleAnswerTemp", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("497021e2-0a15-492b-a30b-c5e0f1a75b81"), 2, 1, "300-500" },
                    { new Guid("3aa3086e-df8a-4802-8ac1-d5b9943825db"), 2, 1, "500-800" },
                    { new Guid("40d1c504-1d13-4669-8f9d-8b75929aa96f"), 2, 1, "800-1200" },
                    { new Guid("c54a2a3b-bdab-4b13-b3b8-fdb077b8e87e"), 2, 1, "1200+" },
                    { new Guid("83a2d453-75bf-490d-a840-f56a55dc625b"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("adafed34-2a69-410e-a9ab-7a6c718d29a7"), 1, 2, "Documenten bewerken" },
                    { new Guid("005294b6-b368-4dda-91dc-55063ce0b249"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("1d254e32-93bb-422e-85a1-64d234c19924"), 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("b43c7d99-0ea1-4609-96ab-8b5f15783a5f"), "500", "Gamen" },
                    { new Guid("8703ec61-7305-4388-aa25-df3537e1825a"), "300", "Gamen" },
                    { new Guid("bb799a3d-26ce-4076-ab17-54d89ac88215"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("7be4110e-fcb2-4c25-80cf-50fa173210ab"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("7ccf155e-09a3-4a57-a3fc-7a875dfc96eb"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("f57d7936-397d-4fde-8594-1245cbe51393"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("a8996670-c993-45fe-8934-9592d4f2c82e"), "1200", "Documenten bewerken" },
                    { new Guid("8b967dc9-992e-4b03-93e4-a9d66b70111f"), "1200", "Mail" },
                    { new Guid("b304a556-43eb-48c8-a5c8-27e97c759a1e"), "500", "Documenten bewerken" },
                    { new Guid("d0a98de9-8689-4754-85ee-55f9ffd63d1b"), "300", "Documenten bewerken" },
                    { new Guid("765fb017-85b1-4eeb-ac1d-c6ed2a1f353d"), "800", "Gamen" },
                    { new Guid("bba908e5-8d88-4c50-a2ee-090f2f0ea35e"), "800", "Mail" },
                    { new Guid("439ac5ef-a44b-4d9a-8cfd-a5d8ef5a40b8"), "500", "Mail" },
                    { new Guid("7953eb24-6a42-41f8-88f2-79a7f13f2b85"), "300", "Mail" },
                    { new Guid("c162faf6-6160-49f4-964e-ad1db9681c31"), "800", "Documenten bewerken" },
                    { new Guid("748ef6c9-c766-4837-96a8-4fa5c47c28e1"), "1200", "Gamen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SingleAnswerTemp");

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("005294b6-b368-4dda-91dc-55063ce0b249"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("1d254e32-93bb-422e-85a1-64d234c19924"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3aa3086e-df8a-4802-8ac1-d5b9943825db"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("40d1c504-1d13-4669-8f9d-8b75929aa96f"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("497021e2-0a15-492b-a30b-c5e0f1a75b81"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("83a2d453-75bf-490d-a840-f56a55dc625b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("adafed34-2a69-410e-a9ab-7a6c718d29a7"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("c54a2a3b-bdab-4b13-b3b8-fdb077b8e87e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("439ac5ef-a44b-4d9a-8cfd-a5d8ef5a40b8"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("748ef6c9-c766-4837-96a8-4fa5c47c28e1"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("765fb017-85b1-4eeb-ac1d-c6ed2a1f353d"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("7953eb24-6a42-41f8-88f2-79a7f13f2b85"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("7be4110e-fcb2-4c25-80cf-50fa173210ab"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("7ccf155e-09a3-4a57-a3fc-7a875dfc96eb"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("8703ec61-7305-4388-aa25-df3537e1825a"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("8b967dc9-992e-4b03-93e4-a9d66b70111f"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a8996670-c993-45fe-8934-9592d4f2c82e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("b304a556-43eb-48c8-a5c8-27e97c759a1e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("b43c7d99-0ea1-4609-96ab-8b5f15783a5f"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("bb799a3d-26ce-4076-ab17-54d89ac88215"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("bba908e5-8d88-4c50-a2ee-090f2f0ea35e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("c162faf6-6160-49f4-964e-ad1db9681c31"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("d0a98de9-8689-4754-85ee-55f9ffd63d1b"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("f57d7936-397d-4fde-8594-1245cbe51393"));

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
        }
    }
}
