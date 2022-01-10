using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class Jasper : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("33aa7ca4-ef2d-4f55-b083-639c4ed1a7ab"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3d98c984-dd38-47fa-9dfb-9560b56cea16"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("6b85d77e-03a0-49cc-81c5-a8d5fd4f4eeb"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("76c48119-0861-4a43-b96a-d2eb61a26001"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7f76e1fd-6864-4970-ae58-4d222f1ec3d3"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("943b9534-b833-4f4b-a16b-985b4fc3e16f"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("abeb4a5c-d9dd-47e0-b22d-e0f5c531adaf"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ac5c8fd6-d973-4bc1-a219-ff3df628f42e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("0cf266cc-964c-438e-911a-2c807ce84a08"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("21dbb7c3-466d-41bd-8a6e-46e5580012c5"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("2886cf88-f1c9-476a-9d24-4a5386090a76"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("33e82c8b-ff25-45b8-9f21-c50d997d09ec"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("3b447042-ebbc-4135-a5a6-0c3432a73735"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("516537dc-5f90-481b-9bd0-48fe8b058fb1"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("5572133e-83a7-4a08-a490-426cbeb691cf"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("5ac965cc-5b76-4db2-b042-4dd9b453b921"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("6d9ed885-2b93-43f2-9abf-8e8b8a72aa91"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("6e18b13a-3af0-41ce-ba26-cf435a1dbdf7"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("90cf04d8-3855-4cc6-ba76-907bab560c69"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("9dea66ed-0422-4f2e-a722-eaa3308743b4"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a4ff0df7-609f-46a3-a6f8-ac58b607f334"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("cc41c21c-b1dc-4c13-bc36-e6f7c76ff485"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("f065ab1e-3abc-4f92-95d8-95fb9c94f8f6"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("f2af025b-21e6-4ece-825a-6c32d00cb487"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("7f76e1fd-6864-4970-ae58-4d222f1ec3d3"), 2, 1, "300-500" },
                    { new Guid("6b85d77e-03a0-49cc-81c5-a8d5fd4f4eeb"), 2, 1, "500-800" },
                    { new Guid("ac5c8fd6-d973-4bc1-a219-ff3df628f42e"), 2, 1, "800-1200" },
                    { new Guid("33aa7ca4-ef2d-4f55-b083-639c4ed1a7ab"), 2, 1, "1200+" },
                    { new Guid("abeb4a5c-d9dd-47e0-b22d-e0f5c531adaf"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("943b9534-b833-4f4b-a16b-985b4fc3e16f"), 1, 2, "Documenten bewerken" },
                    { new Guid("76c48119-0861-4a43-b96a-d2eb61a26001"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("3d98c984-dd38-47fa-9dfb-9560b56cea16"), 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("9dea66ed-0422-4f2e-a722-eaa3308743b4"), "500", "Gamen" },
                    { new Guid("3b447042-ebbc-4135-a5a6-0c3432a73735"), "300", "Gamen" },
                    { new Guid("a4ff0df7-609f-46a3-a6f8-ac58b607f334"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("5572133e-83a7-4a08-a490-426cbeb691cf"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("33e82c8b-ff25-45b8-9f21-c50d997d09ec"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("21dbb7c3-466d-41bd-8a6e-46e5580012c5"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("f065ab1e-3abc-4f92-95d8-95fb9c94f8f6"), "1200", "Documenten bewerken" },
                    { new Guid("516537dc-5f90-481b-9bd0-48fe8b058fb1"), "1200", "Mail" },
                    { new Guid("5ac965cc-5b76-4db2-b042-4dd9b453b921"), "500", "Documenten bewerken" },
                    { new Guid("f2af025b-21e6-4ece-825a-6c32d00cb487"), "300", "Documenten bewerken" },
                    { new Guid("6d9ed885-2b93-43f2-9abf-8e8b8a72aa91"), "800", "Gamen" },
                    { new Guid("0cf266cc-964c-438e-911a-2c807ce84a08"), "800", "Mail" },
                    { new Guid("cc41c21c-b1dc-4c13-bc36-e6f7c76ff485"), "500", "Mail" },
                    { new Guid("2886cf88-f1c9-476a-9d24-4a5386090a76"), "300", "Mail" },
                    { new Guid("90cf04d8-3855-4cc6-ba76-907bab560c69"), "800", "Documenten bewerken" },
                    { new Guid("6e18b13a-3af0-41ce-ba26-cf435a1dbdf7"), "1200", "Gamen" }
                });
        }
    }
}
