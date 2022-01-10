using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class Answers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("1b9a5c4e-8cf8-4ba0-9bf0-37bae6cab99e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("23331025-ba04-4828-9289-4a15106f1ebc"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("591ff4a4-2c33-43d3-8f74-064281662f93"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("5b64c264-2681-4fcd-8d79-6eac537a2078"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("7e6449c3-891e-40d3-b8dc-0ac70b250b9e"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("8993cdb4-48d9-4634-aba2-f1896466cdd9"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("9695d863-3e5c-49cb-bdb5-b5c472f9d2f5"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a29fefd4-b4aa-427a-ad0a-82b4dbfdc179"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a54e5258-d42c-490c-8a6e-297af72e3643"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("dafb6aa7-5212-4c97-b399-e53f67ff2013"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("e3b72ffa-4c51-4237-ab50-c88da2a2373b"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("e531bba8-65f8-4207-908d-516917502d7c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("e9988d16-ab79-4786-a4e7-77ab9ee09b01"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("f8f758be-aa67-46e1-906e-4abb6b0b1c6d"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("fac4a43a-c198-4adb-9414-3f7f7e82d70c"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("fd6bb4a1-8372-4ecd-bfee-b99425f61a5f"));

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
