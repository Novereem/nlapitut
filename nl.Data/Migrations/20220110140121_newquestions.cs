using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class newquestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    { new Guid("2b30057a-1fa1-4144-b17c-773c65c9594e"), 2, 1, "300-500" },
                    { new Guid("78737b95-6721-46b1-9617-ee04594d578a"), 5, 4, "Real-time strategy" },
                    { new Guid("5d7798a3-b870-41e6-939e-f4761a7ce6ad"), 5, 4, "Esports" },
                    { new Guid("206ae5cf-9d6c-44d9-abed-5f7892fee369"), 5, 4, "Action-adventure" },
                    { new Guid("7f75cb3a-9ea8-40ca-ba95-9dc821e56288"), 5, 4, "Shooters" },
                    { new Guid("c67ff388-2199-4f5c-a3aa-943ff32e192c"), 6, 3, "Video's" },
                    { new Guid("c18a38a9-d635-490a-8041-f09479b0e35a"), 6, 3, "Foto's" },
                    { new Guid("a7b66806-89f2-4412-acf4-88bb9a8564da"), 5, 4, "Moba" },
                    { new Guid("02458852-0cd5-41d6-a5b7-0fc0c5cc03de"), 3, 2, "Foto's/video's bewerken" },
                    { new Guid("7c96f61b-0ea0-4b88-9b9d-82bb2f690f78"), 7, 2, "Documenten bewerken" },
                    { new Guid("f9e7ae77-673a-41fc-8ea7-c3d411106e17"), 7, 2, "Mail / Netflix & YouTube" },
                    { new Guid("c31b99b8-841c-47f2-aebc-f8e9b4e6c69e"), 2, 1, "1200+" },
                    { new Guid("329e83fb-85a9-4e56-9111-0f9ee8814b50"), 2, 1, "800-1200" },
                    { new Guid("6e79b67d-2cc2-431e-a602-14fc4e46c593"), 2, 1, "500-800" },
                    { new Guid("8f40f411-4c73-497e-ab1d-92aa01d3dd07"), 4, 2, "Gamen" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("cf744d9e-abc7-4e4a-9747-f7d24b60c399"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("2bc9d667-0568-4c29-b471-c204ab1799ff"), "1200", "Gamen" },
                    { new Guid("3367c3b4-5c3f-4814-b1b7-dd340e4cfec1"), "800", "Gamen" },
                    { new Guid("285046af-76b6-4011-b5d4-58468c4973b6"), "500", "Gamen" },
                    { new Guid("a9c6bcf0-8bf7-4730-99d1-245a251d6d93"), "300", "Gamen" },
                    { new Guid("b2ca6b7b-cdeb-43fa-8db8-b30353f53998"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("35acc52e-805f-4637-bac4-2c47859800d7"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("505a5598-b14c-49f3-8a42-19142f1064be"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("42d97c42-c98b-47bf-b52a-21ca659bbd6d"), "300", "Documenten bewerken" },
                    { new Guid("a7222b5d-1731-482b-8902-6dd9c70e78f6"), "800", "Documenten bewerken" },
                    { new Guid("986e549b-e462-4558-b85b-c342227aa957"), "500", "Documenten bewerken" },
                    { new Guid("3c528779-f2e9-4fc4-ad63-e7514ea750a1"), "1200", "Mail" },
                    { new Guid("99764bad-2c68-404d-91bb-ddb4143114b2"), "800", "Mail" },
                    { new Guid("a7c058d0-9acb-4255-826a-8b1bed88f324"), "500", "Mail" },
                    { new Guid("2e0f0cd4-127d-4c45-8008-d907399db9ca"), "300", "Mail" },
                    { new Guid("fd7085eb-08de-41e7-8794-773c97f5529e"), "1200", "Documenten bewerken" }
                });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "Waar ga je je laptop voor gebruiken?");

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { 9, "Welk grootte scherm heeft u het liefst" },
                    { 3, "Is het vooral video of foto bewerking?" },
                    { 4, "Wat voor soort games speelt u?" },
                    { 5, "Welke van de onderstaande games heeft u gespeeld of bent u van plan te spelen?" },
                    { 6, "Doet u het professioneel?" },
                    { 7, "Heeft u vaak veel programma's tegelijkertijd aanstaan? (4 of meer)" },
                    { 8, "Heeft U liever meer FPS, en/of betere graphics" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("02458852-0cd5-41d6-a5b7-0fc0c5cc03de"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("206ae5cf-9d6c-44d9-abed-5f7892fee369"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2b30057a-1fa1-4144-b17c-773c65c9594e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("329e83fb-85a9-4e56-9111-0f9ee8814b50"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("5d7798a3-b870-41e6-939e-f4761a7ce6ad"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("6e79b67d-2cc2-431e-a602-14fc4e46c593"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("78737b95-6721-46b1-9617-ee04594d578a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7c96f61b-0ea0-4b88-9b9d-82bb2f690f78"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7f75cb3a-9ea8-40ca-ba95-9dc821e56288"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("8f40f411-4c73-497e-ab1d-92aa01d3dd07"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("a7b66806-89f2-4412-acf4-88bb9a8564da"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("c18a38a9-d635-490a-8041-f09479b0e35a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("c31b99b8-841c-47f2-aebc-f8e9b4e6c69e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("c67ff388-2199-4f5c-a3aa-943ff32e192c"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("f9e7ae77-673a-41fc-8ea7-c3d411106e17"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("285046af-76b6-4011-b5d4-58468c4973b6"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("2bc9d667-0568-4c29-b471-c204ab1799ff"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("2e0f0cd4-127d-4c45-8008-d907399db9ca"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("3367c3b4-5c3f-4814-b1b7-dd340e4cfec1"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("35acc52e-805f-4637-bac4-2c47859800d7"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("3c528779-f2e9-4fc4-ad63-e7514ea750a1"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("42d97c42-c98b-47bf-b52a-21ca659bbd6d"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("505a5598-b14c-49f3-8a42-19142f1064be"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("986e549b-e462-4558-b85b-c342227aa957"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("99764bad-2c68-404d-91bb-ddb4143114b2"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a7222b5d-1731-482b-8902-6dd9c70e78f6"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a7c058d0-9acb-4255-826a-8b1bed88f324"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("a9c6bcf0-8bf7-4730-99d1-245a251d6d93"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("b2ca6b7b-cdeb-43fa-8db8-b30353f53998"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("cf744d9e-abc7-4e4a-9747-f7d24b60c399"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("fd7085eb-08de-41e7-8794-773c97f5529e"));

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 9);

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
                    { new Guid("765fb017-85b1-4eeb-ac1d-c6ed2a1f353d"), "800", "Gamen" },
                    { new Guid("b43c7d99-0ea1-4609-96ab-8b5f15783a5f"), "500", "Gamen" },
                    { new Guid("8703ec61-7305-4388-aa25-df3537e1825a"), "300", "Gamen" },
                    { new Guid("bb799a3d-26ce-4076-ab17-54d89ac88215"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("7be4110e-fcb2-4c25-80cf-50fa173210ab"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("7ccf155e-09a3-4a57-a3fc-7a875dfc96eb"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("f57d7936-397d-4fde-8594-1245cbe51393"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("d0a98de9-8689-4754-85ee-55f9ffd63d1b"), "300", "Documenten bewerken" },
                    { new Guid("c162faf6-6160-49f4-964e-ad1db9681c31"), "800", "Documenten bewerken" },
                    { new Guid("b304a556-43eb-48c8-a5c8-27e97c759a1e"), "500", "Documenten bewerken" },
                    { new Guid("748ef6c9-c766-4837-96a8-4fa5c47c28e1"), "1200", "Gamen" },
                    { new Guid("8b967dc9-992e-4b03-93e4-a9d66b70111f"), "1200", "Mail" },
                    { new Guid("bba908e5-8d88-4c50-a2ee-090f2f0ea35e"), "800", "Mail" },
                    { new Guid("439ac5ef-a44b-4d9a-8cfd-a5d8ef5a40b8"), "500", "Mail" },
                    { new Guid("7953eb24-6a42-41f8-88f2-79a7f13f2b85"), "300", "Mail" },
                    { new Guid("a8996670-c993-45fe-8934-9592d4f2c82e"), "1200", "Documenten bewerken" }
                });

            migrationBuilder.UpdateData(
                table: "Question",
                keyColumn: "Id",
                keyValue: 2,
                column: "Text",
                value: "Waar ga je je laptop voor gebruiken");
        }
    }
}
