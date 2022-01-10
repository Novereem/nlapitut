using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class Wouter : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3e709a64-d2e2-4dbc-a056-0ba8c27736df"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7ace35e7-901b-4c66-bab3-110a8fe010ce"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("95d9dff9-d4a0-41f7-9480-1b29ded693cf"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("badb339d-caba-4310-9600-438d862296e5"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("cfb107d8-5103-4878-9aba-0b7f7013b502"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("e6c942d2-c927-47d2-83d1-a571ef2c7f0c"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f26046e9-063e-40c7-a4a1-4158ebb4cf57"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f8a30094-678a-44d7-8128-f860f8d11d64"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("045649d2-c3ec-4b0c-aae1-aab6fb34fa6c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("46585f76-7413-4541-bf9c-115d6d85ca6c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("53347cff-6ef0-4203-89db-f1df7885af39"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("5e906cdd-a19f-49b2-867d-d252ec08dda7"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("61d48146-657e-42ae-936d-9bfa83331ade"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("7aa871fa-6d8f-4e2a-aa13-28325a8152cb"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("8027b647-3402-4651-afd3-1ad2bcc214d9"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("87b1dacd-73bf-438a-97c4-6ebd71186629"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("9859da75-60a5-4d6c-9f4b-c96dbf127ab7"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("988b3db0-78bc-4694-b60b-adfd9e98cf92"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a245a8ae-e90f-492f-bc9b-cd7dcc19081b"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("bdc15735-c996-48c3-abad-8ba791527048"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("be061336-21ed-48c9-b63e-bcbe9ca8d83e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("e6f205e4-cd61-4c9d-a6ff-ea835c3f6e3c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("eb0a79aa-8205-4d6b-95a9-502414239a39"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("fc061ccc-e5f9-4070-b4dc-87eca9d58d22"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("badb339d-caba-4310-9600-438d862296e5"), 2, 1, "300-500" },
                    { new Guid("7ace35e7-901b-4c66-bab3-110a8fe010ce"), 2, 1, "500-800" },
                    { new Guid("cfb107d8-5103-4878-9aba-0b7f7013b502"), 2, 1, "800-1200" },
                    { new Guid("f26046e9-063e-40c7-a4a1-4158ebb4cf57"), 2, 1, "1200+" },
                    { new Guid("e6c942d2-c927-47d2-83d1-a571ef2c7f0c"), 1, 2, "Mail / Netflix & YouTube" },
                    { new Guid("95d9dff9-d4a0-41f7-9480-1b29ded693cf"), 1, 2, "Documenten bewerken" },
                    { new Guid("f8a30094-678a-44d7-8128-f860f8d11d64"), 1, 2, "Foto's/videdo's bewerken" },
                    { new Guid("3e709a64-d2e2-4dbc-a056-0ba8c27736df"), 1, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("bdc15735-c996-48c3-abad-8ba791527048"), "500", "Gamen" },
                    { new Guid("fc061ccc-e5f9-4070-b4dc-87eca9d58d22"), "300", "Gamen" },
                    { new Guid("87b1dacd-73bf-438a-97c4-6ebd71186629"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("be061336-21ed-48c9-b63e-bcbe9ca8d83e"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("045649d2-c3ec-4b0c-aae1-aab6fb34fa6c"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("a245a8ae-e90f-492f-bc9b-cd7dcc19081b"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("9859da75-60a5-4d6c-9f4b-c96dbf127ab7"), "1200", "Documenten bewerken" },
                    { new Guid("7aa871fa-6d8f-4e2a-aa13-28325a8152cb"), "1200", "Mail" },
                    { new Guid("e6f205e4-cd61-4c9d-a6ff-ea835c3f6e3c"), "500", "Documenten bewerken" },
                    { new Guid("8027b647-3402-4651-afd3-1ad2bcc214d9"), "300", "Documenten bewerken" },
                    { new Guid("5e906cdd-a19f-49b2-867d-d252ec08dda7"), "800", "Gamen" },
                    { new Guid("53347cff-6ef0-4203-89db-f1df7885af39"), "800", "Mail" },
                    { new Guid("988b3db0-78bc-4694-b60b-adfd9e98cf92"), "500", "Mail" },
                    { new Guid("61d48146-657e-42ae-936d-9bfa83331ade"), "300", "Mail" },
                    { new Guid("eb0a79aa-8205-4d6b-95a9-502414239a39"), "800", "Documenten bewerken" },
                    { new Guid("46585f76-7413-4541-bf9c-115d6d85ca6c"), "1200", "Gamen" }
                });
        }
    }
}
