using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace nl.Data.Migrations
{
    public partial class MoreQuestions : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("87eaed43-ce5f-4304-9ed4-be808bfffe6b"), 2, 1, "300-500" },
                    { new Guid("bb099b2f-f26d-4c17-9429-12e73f18653f"), 8, 5, "Rust" },
                    { new Guid("fe0c4eea-e3e5-47bc-b115-009398d54cdc"), 8, 5, "Destiny 2" },
                    { new Guid("64ba5c1d-1853-4b48-afcf-9bf63d140d8a"), 8, 5, "PLAYERUNKNOWN'S BATTLEGROUNDS" },
                    { new Guid("04fca485-aeb5-4e9b-b251-6d942690938e"), 8, 5, "Garry's Mod" },
                    { new Guid("73d283d6-d71f-4e9e-a051-1bd81ecab2ed"), 8, 5, "Left 4 Dead 2" },
                    { new Guid("17bd92c7-6b21-412e-9fbb-cf2f2a23dbad"), 8, 5, "Brawlhalla" },
                    { new Guid("c50378ae-7fe5-40d1-a569-26216bb936ff"), 8, 5, "Euro Truck Simulator 2" },
                    { new Guid("5e06db60-8f01-4e1f-ab18-ad925ca269ed"), 8, 5, "Among Us" },
                    { new Guid("cccd3a90-facd-4507-895a-cd6f6c2e8b71"), 8, 5, "Grand Theft Auto 5" },
                    { new Guid("36060b9c-22fd-4c38-8718-83289daddf6d"), 7, 6, "Ja" },
                    { new Guid("4b56bf71-a027-4320-9555-2b0f21742ae1"), 7, 6, "Nee" },
                    { new Guid("5985bdad-10c4-4789-abf2-03d4ff95123a"), 8, 7, "Ja" },
                    { new Guid("279e4bbe-cc8f-441d-9ba4-0f66412ae919"), 8, 7, "Nee" },
                    { new Guid("51058636-15e2-40df-a7b1-6d6cb9aecfcc"), 9, 8, "FPS" },
                    { new Guid("1dcb4f82-f3ce-4b40-a682-1f35a5b52353"), 9, 8, "Graphics" },
                    { new Guid("2866db74-3207-497b-bbc5-9630ca76eec5"), 1, 9, "13'" },
                    { new Guid("b6a427e0-cfeb-43b9-be51-09c96bdb6e23"), 1, 9, "14'" },
                    { new Guid("72e4d591-974d-4e3e-b853-51e1ac222a2b"), 1, 9, "15'6" },
                    { new Guid("be241db4-fb37-4415-a1bc-7cf3f3a79304"), 1, 9, "17'" },
                    { new Guid("edd532fe-28b4-4752-bb5a-550e877d7329"), 8, 5, "Team Fortress 2" },
                    { new Guid("ff7b7fe0-740b-4931-8779-094524f8239a"), 8, 5, "Tom Clancy's Rainbow Six: Siege" },
                    { new Guid("2f778f39-a619-4598-aead-9b19a8377373"), 8, 5, "Bloons TD 6" },
                    { new Guid("ee9c2203-9600-4be8-a07c-a34b4ad331ab"), 8, 5, "Phasmophobia" },
                    { new Guid("0eb6ecf7-7fa8-4ce1-a692-49cf13514ba9"), 2, 1, "500-800" },
                    { new Guid("510224d1-d0aa-4685-a5ee-1ac52e4c5169"), 2, 1, "800-1200" },
                    { new Guid("0f430791-7750-40bf-9da4-6e1b3020623d"), 2, 1, "1200+" },
                    { new Guid("52643864-6eee-4dac-9669-c564ece8e346"), 8, 5, "Dead by Daylight" },
                    { new Guid("3af99dcb-c4a9-4184-ae46-c8950b025090"), 7, 2, "Documenten bewerken" },
                    { new Guid("ba61983d-c13a-4f5a-9e5a-b8742af336e9"), 3, 2, "Foto's/video's bewerken" },
                    { new Guid("55060494-3330-47c2-8b4a-d1f1cc054bbc"), 4, 2, "Gamen" },
                    { new Guid("5a40cd64-6d40-4bb1-8c64-71ac17a90b4f"), 6, 3, "Foto's" },
                    { new Guid("337ae19b-4473-4eb5-99e1-712f93a77e10"), 6, 3, "Video's" },
                    { new Guid("abc5eb7c-b396-4188-9fa7-dfc4d97b0ecf"), 5, 4, "Shooters" },
                    { new Guid("62bb4415-3cbd-426b-92c4-934b6e5f36c0"), 7, 2, "Mail / Netflix & YouTube" },
                    { new Guid("7b2d0282-972c-4bb6-a2e5-0416905b3640"), 5, 4, "Action-adventure" },
                    { new Guid("5500b988-5c6f-4562-9fe5-ffc278a83c1e"), 5, 4, "Moba" },
                    { new Guid("3a9fb635-cf8b-46cc-aff8-afd808f1c199"), 8, 5, "Apex Legends" },
                    { new Guid("2d5cad18-d852-4ee5-9c67-cdcdb853a279"), 8, 5, "Battlefield 2042" },
                    { new Guid("d2d9a848-510d-4e50-93e2-e29cdfab2e7f"), 8, 5, "Dota 2" },
                    { new Guid("a89f99c4-8461-40f2-b628-499b7bdd9174"), 8, 5, "Rocket League" },
                    { new Guid("65c23657-4df5-439b-9b94-812d712773c9"), 8, 5, "Counter-Strike: Global Offensive" },
                    { new Guid("b9212982-2003-4f86-b951-2086b5b0d70d"), 5, 4, "Real-time strategy" },
                    { new Guid("2d7c6812-b280-4703-8bda-6d505d3163bf"), 5, 4, "Esports" },
                    { new Guid("0f58fa1c-1c22-4f8a-a1f4-0942b10d7cbd"), 8, 5, "New World" }
                });

            migrationBuilder.InsertData(
                table: "Laptops",
                columns: new[] { "Id", "Price", "Usage" },
                values: new object[,]
                {
                    { new Guid("09583b13-3f6f-482e-a407-d017a23bad99"), "500", "Gamen" },
                    { new Guid("e7bf6f7a-a099-4349-abad-f8bed0989661"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("c44e3725-bc54-4c28-bb3d-757183205d72"), "300", "Gamen" },
                    { new Guid("9f958947-cfde-48fc-ba2f-a6fc55f501ad"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("575ec629-c1e8-4c10-b161-731d23a178e9"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("7b073160-224f-4605-b603-c1adfb501121"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("5678fe65-2460-4294-975b-8b0db11cf081"), "1200", "Documenten bewerken" },
                    { new Guid("b123211e-748e-47f2-947e-3623972c8d48"), "800", "Mail" },
                    { new Guid("8243da56-bf4a-45ab-b71c-427221d33507"), "500", "Documenten bewerken" },
                    { new Guid("c060d254-3f50-4d2f-a410-85691ee2d5fd"), "300", "Documenten bewerken" },
                    { new Guid("f81e88e8-53a8-4333-acb6-ffef1902eaa5"), "1200", "Mail" },
                    { new Guid("42411e12-33f9-4d81-b5d0-3f0ec04dab62"), "500", "Mail" },
                    { new Guid("caa22ac6-64f0-4566-b3eb-2231594ac0b0"), "300", "Mail" },
                    { new Guid("c8ae8a6b-a09a-44e3-affe-8678f58c6818"), "800", "Gamen" },
                    { new Guid("0e694d7c-7d03-415c-b762-d77b9fb00c03"), "800", "Documenten bewerken" },
                    { new Guid("73aded0f-ef92-460a-8f31-e2317eefa766"), "1200", "Gamen" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("04fca485-aeb5-4e9b-b251-6d942690938e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0eb6ecf7-7fa8-4ce1-a692-49cf13514ba9"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0f430791-7750-40bf-9da4-6e1b3020623d"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("0f58fa1c-1c22-4f8a-a1f4-0942b10d7cbd"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("17bd92c7-6b21-412e-9fbb-cf2f2a23dbad"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("1dcb4f82-f3ce-4b40-a682-1f35a5b52353"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("279e4bbe-cc8f-441d-9ba4-0f66412ae919"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2866db74-3207-497b-bbc5-9630ca76eec5"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2d5cad18-d852-4ee5-9c67-cdcdb853a279"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2d7c6812-b280-4703-8bda-6d505d3163bf"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("2f778f39-a619-4598-aead-9b19a8377373"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("337ae19b-4473-4eb5-99e1-712f93a77e10"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("36060b9c-22fd-4c38-8718-83289daddf6d"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3a9fb635-cf8b-46cc-aff8-afd808f1c199"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("3af99dcb-c4a9-4184-ae46-c8950b025090"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("4b56bf71-a027-4320-9555-2b0f21742ae1"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("510224d1-d0aa-4685-a5ee-1ac52e4c5169"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("51058636-15e2-40df-a7b1-6d6cb9aecfcc"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("52643864-6eee-4dac-9669-c564ece8e346"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("5500b988-5c6f-4562-9fe5-ffc278a83c1e"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("55060494-3330-47c2-8b4a-d1f1cc054bbc"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("5985bdad-10c4-4789-abf2-03d4ff95123a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("5a40cd64-6d40-4bb1-8c64-71ac17a90b4f"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("5e06db60-8f01-4e1f-ab18-ad925ca269ed"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("62bb4415-3cbd-426b-92c4-934b6e5f36c0"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("64ba5c1d-1853-4b48-afcf-9bf63d140d8a"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("65c23657-4df5-439b-9b94-812d712773c9"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("72e4d591-974d-4e3e-b853-51e1ac222a2b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("73d283d6-d71f-4e9e-a051-1bd81ecab2ed"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("7b2d0282-972c-4bb6-a2e5-0416905b3640"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("87eaed43-ce5f-4304-9ed4-be808bfffe6b"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("a89f99c4-8461-40f2-b628-499b7bdd9174"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("abc5eb7c-b396-4188-9fa7-dfc4d97b0ecf"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b6a427e0-cfeb-43b9-be51-09c96bdb6e23"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("b9212982-2003-4f86-b951-2086b5b0d70d"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ba61983d-c13a-4f5a-9e5a-b8742af336e9"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("bb099b2f-f26d-4c17-9429-12e73f18653f"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("be241db4-fb37-4415-a1bc-7cf3f3a79304"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("c50378ae-7fe5-40d1-a569-26216bb936ff"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("cccd3a90-facd-4507-895a-cd6f6c2e8b71"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("d2d9a848-510d-4e50-93e2-e29cdfab2e7f"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("edd532fe-28b4-4752-bb5a-550e877d7329"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ee9c2203-9600-4be8-a07c-a34b4ad331ab"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("fe0c4eea-e3e5-47bc-b115-009398d54cdc"));

            migrationBuilder.DeleteData(
                table: "Answer",
                keyColumn: "Id",
                keyValue: new Guid("ff7b7fe0-740b-4931-8779-094524f8239a"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("09583b13-3f6f-482e-a407-d017a23bad99"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("0e694d7c-7d03-415c-b762-d77b9fb00c03"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("42411e12-33f9-4d81-b5d0-3f0ec04dab62"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("5678fe65-2460-4294-975b-8b0db11cf081"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("575ec629-c1e8-4c10-b161-731d23a178e9"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("73aded0f-ef92-460a-8f31-e2317eefa766"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("7b073160-224f-4605-b603-c1adfb501121"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("8243da56-bf4a-45ab-b71c-427221d33507"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("9f958947-cfde-48fc-ba2f-a6fc55f501ad"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("b123211e-748e-47f2-947e-3623972c8d48"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("c060d254-3f50-4d2f-a410-85691ee2d5fd"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("c44e3725-bc54-4c28-bb3d-757183205d72"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("c8ae8a6b-a09a-44e3-affe-8678f58c6818"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("caa22ac6-64f0-4566-b3eb-2231594ac0b0"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("e7bf6f7a-a099-4349-abad-f8bed0989661"));

            migrationBuilder.DeleteData(
                table: "Laptops",
                keyColumn: "Id",
                keyValue: new Guid("f81e88e8-53a8-4333-acb6-ffef1902eaa5"));

            migrationBuilder.InsertData(
                table: "Answer",
                columns: new[] { "Id", "NextQuestionId", "QuestionId", "Text" },
                values: new object[,]
                {
                    { new Guid("2b30057a-1fa1-4144-b17c-773c65c9594e"), 2, 1, "300-500" },
                    { new Guid("78737b95-6721-46b1-9617-ee04594d578a"), 5, 4, "Real-time strategy" },
                    { new Guid("5d7798a3-b870-41e6-939e-f4761a7ce6ad"), 5, 4, "Esports" },
                    { new Guid("206ae5cf-9d6c-44d9-abed-5f7892fee369"), 5, 4, "Action-adventure" },
                    { new Guid("a7b66806-89f2-4412-acf4-88bb9a8564da"), 5, 4, "Moba" },
                    { new Guid("c67ff388-2199-4f5c-a3aa-943ff32e192c"), 6, 3, "Video's" },
                    { new Guid("c18a38a9-d635-490a-8041-f09479b0e35a"), 6, 3, "Foto's" },
                    { new Guid("7f75cb3a-9ea8-40ca-ba95-9dc821e56288"), 5, 4, "Shooters" },
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
                    { new Guid("505a5598-b14c-49f3-8a42-19142f1064be"), "300", "Foto's/videdo's bewerken" },
                    { new Guid("285046af-76b6-4011-b5d4-58468c4973b6"), "500", "Gamen" },
                    { new Guid("a9c6bcf0-8bf7-4730-99d1-245a251d6d93"), "300", "Gamen" },
                    { new Guid("b2ca6b7b-cdeb-43fa-8db8-b30353f53998"), "1200", "Foto's/videdo's bewerken" },
                    { new Guid("35acc52e-805f-4637-bac4-2c47859800d7"), "800", "Foto's/videdo's bewerken" },
                    { new Guid("cf744d9e-abc7-4e4a-9747-f7d24b60c399"), "500", "Foto's/videdo's bewerken" },
                    { new Guid("fd7085eb-08de-41e7-8794-773c97f5529e"), "1200", "Documenten bewerken" },
                    { new Guid("2e0f0cd4-127d-4c45-8008-d907399db9ca"), "300", "Mail" },
                    { new Guid("986e549b-e462-4558-b85b-c342227aa957"), "500", "Documenten bewerken" },
                    { new Guid("42d97c42-c98b-47bf-b52a-21ca659bbd6d"), "300", "Documenten bewerken" },
                    { new Guid("3c528779-f2e9-4fc4-ad63-e7514ea750a1"), "1200", "Mail" },
                    { new Guid("99764bad-2c68-404d-91bb-ddb4143114b2"), "800", "Mail" },
                    { new Guid("a7c058d0-9acb-4255-826a-8b1bed88f324"), "500", "Mail" },
                    { new Guid("3367c3b4-5c3f-4814-b1b7-dd340e4cfec1"), "800", "Gamen" },
                    { new Guid("a7222b5d-1731-482b-8902-6dd9c70e78f6"), "800", "Documenten bewerken" },
                    { new Guid("2bc9d667-0568-4c29-b471-c204ab1799ff"), "1200", "Gamen" }
                });
        }
    }
}
