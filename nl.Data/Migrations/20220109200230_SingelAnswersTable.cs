using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class SingelAnswersTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("215bac34-9fc8-49bd-8917-431eecc9c616"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("65d8841a-963a-418b-a93f-5daa1978676c"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("6c91db04-43da-4b69-b9b1-b357582edb80"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("6d1a25a0-5cbb-4389-b605-dc677713fd9e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("6efed41b-cbd7-49c9-8f50-9a5b61484fc9"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("a5dd69b9-fc55-4785-b4b2-6583125f7a45"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ce287a25-77e7-4e67-a520-edb9887a0ffb"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("cff906c6-dcd5-477e-9b9a-93cfadb28ad1"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("1107e141-e32a-42a5-b8bf-de8bfd10979b"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("23dcfddf-aea5-4992-bce3-e4d42e2f55fb"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("3849ef0c-bd5b-42dd-a32e-d3c6f5451bc7"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("5c1c963b-0cf5-4178-96fe-a4a54d249f44"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("6294ff1a-0dd6-4bf5-af43-f019cb68c0d9"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("7029c385-b5ad-4a2f-b7cb-30c3e9d9ab1a"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("73bf74bd-489d-458b-9935-2727ec1c5a80"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("8ef12b6e-6b36-4463-8e76-08c2d7dbfd4f"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("996734b2-b678-419f-9aff-ce5a66555fb7"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a49b5a6b-5dc5-4dd0-9937-95b9aab129f4"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("ad011104-33d0-4089-acf0-0afc42650b07"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("ad74a9a1-0559-494f-91cd-2faeac2b898b"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("cb93c8c0-5edd-4bec-82a6-84667d081ce9"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("e4f3aeaa-089e-4353-baa3-7e52a821b148"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("f6932d4c-8f63-43ab-83e1-c691c62ad76c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("fc63ddff-fa9f-4181-8921-e4002d5915de"));

            migrationBuilder.CreateTable(
                name: "SingeAnswers",
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
                    table.PrimaryKey("PK_SingeAnswers", x => x.Id);
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SingeAnswers");

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

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("a5dd69b9-fc55-4785-b4b2-6583125f7a45"), 2, 1, "300-500" },
                    { new Guid("cff906c6-dcd5-477e-9b9a-93cfadb28ad1"), 2, 1, "500-800" },
                    { new Guid("65d8841a-963a-418b-a93f-5daa1978676c"), 2, 1, "800-1200" },
                    { new Guid("6d1a25a0-5cbb-4389-b605-dc677713fd9e"), 2, 1, "1200+" },
                    { new Guid("215bac34-9fc8-49bd-8917-431eecc9c616"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("6efed41b-cbd7-49c9-8f50-9a5b61484fc9"), 1, 2, "Documenten bewerken" },
                    { new Guid("ce287a25-77e7-4e67-a520-edb9887a0ffb"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("6c91db04-43da-4b69-b9b1-b357582edb80"), 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("3849ef0c-bd5b-42dd-a32e-d3c6f5451bc7"), "500", "Gamen" },
                    { new Guid("996734b2-b678-419f-9aff-ce5a66555fb7"), "300", "Gamen" },
                    { new Guid("1107e141-e32a-42a5-b8bf-de8bfd10979b"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("6294ff1a-0dd6-4bf5-af43-f019cb68c0d9"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("cb93c8c0-5edd-4bec-82a6-84667d081ce9"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("8ef12b6e-6b36-4463-8e76-08c2d7dbfd4f"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("ad011104-33d0-4089-acf0-0afc42650b07"), "1200", "Documenten bewerken" },
                    { new Guid("7029c385-b5ad-4a2f-b7cb-30c3e9d9ab1a"), "1200", "Mail" },
                    { new Guid("f6932d4c-8f63-43ab-83e1-c691c62ad76c"), "500", "Documenten bewerken" },
                    { new Guid("e4f3aeaa-089e-4353-baa3-7e52a821b148"), "300", "Documenten bewerken" },
                    { new Guid("ad74a9a1-0559-494f-91cd-2faeac2b898b"), "800", "Gamen" },
                    { new Guid("5c1c963b-0cf5-4178-96fe-a4a54d249f44"), "800", "Mail" },
                    { new Guid("a49b5a6b-5dc5-4dd0-9937-95b9aab129f4"), "500", "Mail" },
                    { new Guid("73bf74bd-489d-458b-9935-2727ec1c5a80"), "300", "Mail" },
                    { new Guid("fc63ddff-fa9f-4181-8921-e4002d5915de"), "800", "Documenten bewerken" },
                    { new Guid("23dcfddf-aea5-4992-bce3-e4d42e2f55fb"), "1200", "Gamen" }
                });
        }
    }
}
