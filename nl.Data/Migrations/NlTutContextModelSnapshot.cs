﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nl.Data;

namespace nl.Data.Migrations
{
    [DbContext(typeof(NlTutContext))]
    partial class NlTutContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("nl.Commen.Models.Answer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<int>("NextQuestionId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("873fcacf-05fc-4510-a3bf-cbbb3bacf1bd"),
                            NextQuestionId = 2,
                            OrderId = 1,
                            QuestionId = 1,
                            Text = "300-500"
                        },
                        new
                        {
                            Id = new Guid("97286fe0-b9a2-42f7-b11e-5d26fc19371f"),
                            NextQuestionId = 2,
                            OrderId = 2,
                            QuestionId = 1,
                            Text = "500-800"
                        },
                        new
                        {
                            Id = new Guid("a505db83-75f7-466b-84ec-9a2efc2e8b04"),
                            NextQuestionId = 2,
                            OrderId = 3,
                            QuestionId = 1,
                            Text = "800-1200"
                        },
                        new
                        {
                            Id = new Guid("1a4128b0-fbf7-49d0-91d6-912c5e36f5a3"),
                            NextQuestionId = 2,
                            OrderId = 4,
                            QuestionId = 1,
                            Text = "1200+"
                        },
                        new
                        {
                            Id = new Guid("8aa0bd98-d996-4190-bde5-c7ed614dfacf"),
                            NextQuestionId = 7,
                            OrderId = 1,
                            QuestionId = 2,
                            Text = "Mail / Netflix & YouTube"
                        },
                        new
                        {
                            Id = new Guid("aaaf0985-f33c-49fa-a1d4-2cfe17dbcbd2"),
                            NextQuestionId = 7,
                            OrderId = 2,
                            QuestionId = 2,
                            Text = "Documenten bewerken"
                        },
                        new
                        {
                            Id = new Guid("4ca1f250-d199-45d3-b348-54705f2be1b1"),
                            NextQuestionId = 3,
                            OrderId = 3,
                            QuestionId = 2,
                            Text = "Foto's/video's bewerken"
                        },
                        new
                        {
                            Id = new Guid("a9eb6d23-a2bd-4401-99f6-f08e41eb7ca8"),
                            NextQuestionId = 4,
                            OrderId = 4,
                            QuestionId = 2,
                            Text = "Gamen"
                        },
                        new
                        {
                            Id = new Guid("314770a9-91af-4014-9a49-067e7a9d0406"),
                            NextQuestionId = 6,
                            OrderId = 1,
                            QuestionId = 3,
                            Text = "Foto's"
                        },
                        new
                        {
                            Id = new Guid("82fb261c-8f10-415c-8df8-8489296042b8"),
                            NextQuestionId = 6,
                            OrderId = 2,
                            QuestionId = 3,
                            Text = "Video's"
                        },
                        new
                        {
                            Id = new Guid("9202bb94-7c8c-481b-ba61-b0acaef09bcc"),
                            NextQuestionId = 5,
                            OrderId = 1,
                            QuestionId = 4,
                            Text = "Shooters"
                        },
                        new
                        {
                            Id = new Guid("6f235d37-00d3-4bfc-b1f5-8b11f04aa52b"),
                            NextQuestionId = 5,
                            OrderId = 2,
                            QuestionId = 4,
                            Text = "Moba"
                        },
                        new
                        {
                            Id = new Guid("9f4c8236-be4e-474c-85cb-014903af2246"),
                            NextQuestionId = 5,
                            OrderId = 3,
                            QuestionId = 4,
                            Text = "Action-adventure"
                        },
                        new
                        {
                            Id = new Guid("f5f5067e-41c2-4bfb-9d2a-8d6b345dfc47"),
                            NextQuestionId = 5,
                            OrderId = 4,
                            QuestionId = 4,
                            Text = "Esports"
                        },
                        new
                        {
                            Id = new Guid("84eb274d-14b8-4417-b0d8-e963a7921c5f"),
                            NextQuestionId = 5,
                            OrderId = 5,
                            QuestionId = 4,
                            Text = "Real-time strategy"
                        },
                        new
                        {
                            Id = new Guid("4cdffdaf-253a-47d3-9ff5-5ca63c66e756"),
                            NextQuestionId = 8,
                            OrderId = 1,
                            QuestionId = 5,
                            Text = "Counter-Strike: Global Offensive"
                        },
                        new
                        {
                            Id = new Guid("8d4ce00f-9b9c-42ae-99f0-e56caf119344"),
                            NextQuestionId = 8,
                            OrderId = 2,
                            QuestionId = 5,
                            Text = "New World"
                        },
                        new
                        {
                            Id = new Guid("2dc3ed91-a167-4907-899f-c62899cab4cc"),
                            NextQuestionId = 8,
                            OrderId = 3,
                            QuestionId = 5,
                            Text = "Dota 2"
                        },
                        new
                        {
                            Id = new Guid("26658792-dc1b-4502-b8d4-e9fb3246f27a"),
                            NextQuestionId = 8,
                            OrderId = 4,
                            QuestionId = 5,
                            Text = "Battlefield 2042"
                        },
                        new
                        {
                            Id = new Guid("e53cd851-3f96-4d1d-8f04-67dbd195e2ca"),
                            NextQuestionId = 8,
                            OrderId = 5,
                            QuestionId = 5,
                            Text = "Rocket League"
                        },
                        new
                        {
                            Id = new Guid("b8351874-f8df-4a15-82c8-1d0b794105c8"),
                            NextQuestionId = 8,
                            OrderId = 6,
                            QuestionId = 5,
                            Text = "Apex Legends"
                        },
                        new
                        {
                            Id = new Guid("9772d1eb-f586-4dd0-8137-ec0aab7fad0b"),
                            NextQuestionId = 8,
                            OrderId = 7,
                            QuestionId = 5,
                            Text = "Phasmophobia"
                        },
                        new
                        {
                            Id = new Guid("0609a638-f714-4f52-b8ba-2608b1660090"),
                            NextQuestionId = 8,
                            OrderId = 8,
                            QuestionId = 5,
                            Text = "Dead by Daylight"
                        },
                        new
                        {
                            Id = new Guid("57d8787a-e8ba-4ac1-bffe-5e1b0f77a10c"),
                            NextQuestionId = 8,
                            OrderId = 9,
                            QuestionId = 5,
                            Text = "Tom Clancy's Rainbow Six: Siege"
                        },
                        new
                        {
                            Id = new Guid("5c7c0fb7-e9da-4001-9ca3-36881c9056ed"),
                            NextQuestionId = 8,
                            OrderId = 10,
                            QuestionId = 5,
                            Text = "Team Fortress 2"
                        },
                        new
                        {
                            Id = new Guid("d457b05f-a91e-4c1d-b46d-e49fac539719"),
                            NextQuestionId = 8,
                            OrderId = 11,
                            QuestionId = 5,
                            Text = "Rust"
                        },
                        new
                        {
                            Id = new Guid("cf9b7f47-10f4-478a-b814-d375b95d2432"),
                            NextQuestionId = 8,
                            OrderId = 12,
                            QuestionId = 5,
                            Text = "Destiny 2"
                        },
                        new
                        {
                            Id = new Guid("d6aa3c57-c772-4325-b152-8497499ff2a7"),
                            NextQuestionId = 8,
                            OrderId = 13,
                            QuestionId = 5,
                            Text = "PLAYERUNKNOWN'S BATTLEGROUNDS"
                        },
                        new
                        {
                            Id = new Guid("298900f8-49a4-4d8c-ad03-93681ca1da71"),
                            NextQuestionId = 8,
                            OrderId = 14,
                            QuestionId = 5,
                            Text = "Garry's Mod"
                        },
                        new
                        {
                            Id = new Guid("f55cdbda-326b-4929-a34e-333e04540801"),
                            NextQuestionId = 8,
                            OrderId = 15,
                            QuestionId = 5,
                            Text = "Left 4 Dead 2"
                        },
                        new
                        {
                            Id = new Guid("be85774f-9e3c-48fd-9625-489f3d6bf602"),
                            NextQuestionId = 8,
                            OrderId = 16,
                            QuestionId = 5,
                            Text = "Bloons TD 6"
                        },
                        new
                        {
                            Id = new Guid("d156da6c-6457-49ae-a556-66ae590c0e8c"),
                            NextQuestionId = 8,
                            OrderId = 17,
                            QuestionId = 5,
                            Text = "Brawlhalla"
                        },
                        new
                        {
                            Id = new Guid("638e70f9-8acd-4f75-ba2a-9543082926df"),
                            NextQuestionId = 8,
                            OrderId = 18,
                            QuestionId = 5,
                            Text = "Euro Truck Simulator 2"
                        },
                        new
                        {
                            Id = new Guid("9d133c22-fd0b-43f4-b6d9-97a84415b90f"),
                            NextQuestionId = 8,
                            OrderId = 19,
                            QuestionId = 5,
                            Text = "Among Us"
                        },
                        new
                        {
                            Id = new Guid("0e8705cf-c286-4e92-8eaf-da1a536dc4d7"),
                            NextQuestionId = 8,
                            OrderId = 20,
                            QuestionId = 5,
                            Text = "Grand Theft Auto 5"
                        },
                        new
                        {
                            Id = new Guid("4a3ca53d-0f47-47d5-b6f6-a70ad2082a53"),
                            NextQuestionId = 7,
                            OrderId = 1,
                            QuestionId = 6,
                            Text = "Ja"
                        },
                        new
                        {
                            Id = new Guid("17ed75c8-1a2c-4398-8174-62a52ee9421f"),
                            NextQuestionId = 7,
                            OrderId = 2,
                            QuestionId = 6,
                            Text = "Nee"
                        },
                        new
                        {
                            Id = new Guid("b43ce731-1052-4900-8c2f-f658b1b5c409"),
                            NextQuestionId = 9,
                            OrderId = 1,
                            QuestionId = 7,
                            Text = "Ja"
                        },
                        new
                        {
                            Id = new Guid("d65de99d-425f-4ae2-9a4e-99863f83ce8c"),
                            NextQuestionId = 9,
                            OrderId = 2,
                            QuestionId = 7,
                            Text = "Nee"
                        },
                        new
                        {
                            Id = new Guid("0f759b53-5623-4ac3-b10e-a9ea9d1354f4"),
                            NextQuestionId = 9,
                            OrderId = 1,
                            QuestionId = 8,
                            Text = "FPS"
                        },
                        new
                        {
                            Id = new Guid("4edd8f6d-f857-441e-9a0e-d83d2f098396"),
                            NextQuestionId = 9,
                            OrderId = 2,
                            QuestionId = 8,
                            Text = "Graphics"
                        },
                        new
                        {
                            Id = new Guid("861eb517-eafd-4388-a518-af502ca06b76"),
                            NextQuestionId = 1,
                            OrderId = 1,
                            QuestionId = 9,
                            Text = "13'"
                        },
                        new
                        {
                            Id = new Guid("0aab31cb-76d6-4fbf-862d-27e11946b943"),
                            NextQuestionId = 1,
                            OrderId = 2,
                            QuestionId = 9,
                            Text = "14'"
                        },
                        new
                        {
                            Id = new Guid("4ecb79d9-1245-4023-9057-aeba5f753beb"),
                            NextQuestionId = 1,
                            OrderId = 3,
                            QuestionId = 9,
                            Text = "15'6"
                        },
                        new
                        {
                            Id = new Guid("3fc22d8e-c694-4e6b-a701-c7f5ae9f2937"),
                            NextQuestionId = 1,
                            OrderId = 4,
                            QuestionId = 9,
                            Text = "17'"
                        });
                });

            modelBuilder.Entity("nl.Commen.Models.Component", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("Score")
                        .HasColumnType("int");

                    b.Property<string>("Type")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Components");

                    b.HasData(
                        new
                        {
                            Id = new Guid("cb8c0d7d-8622-42ce-831e-6e8b45e6c17e"),
                            Name = "3",
                            Score = 3,
                            Type = "Processor"
                        },
                        new
                        {
                            Id = new Guid("db4cc3c7-06e0-428a-b419-d956cc379b3e"),
                            Name = "5",
                            Score = 6,
                            Type = "Processor"
                        },
                        new
                        {
                            Id = new Guid("21597029-303a-4307-a4bb-62d1f7849eca"),
                            Name = "7",
                            Score = 9,
                            Type = "Processor"
                        },
                        new
                        {
                            Id = new Guid("b4dd671a-c3d8-4c70-a6b2-7c205f5f2aef"),
                            Name = "256gb",
                            Score = 3,
                            Type = "Storage"
                        },
                        new
                        {
                            Id = new Guid("2223a948-c906-4bd7-8272-5301376c1599"),
                            Name = "512gb",
                            Score = 6,
                            Type = "Storage"
                        },
                        new
                        {
                            Id = new Guid("74c38f9f-8eb4-444d-8bc3-9626b3f147b1"),
                            Name = "1tb",
                            Score = 9,
                            Type = "Storage"
                        },
                        new
                        {
                            Id = new Guid("f87faebb-6d75-41c4-932e-3b57f789fd83"),
                            Name = "8gb",
                            Score = 3,
                            Type = "Ram"
                        },
                        new
                        {
                            Id = new Guid("6e8a7491-6335-433c-a8a0-ee52b5b15285"),
                            Name = "16gb",
                            Score = 6,
                            Type = "Ram"
                        },
                        new
                        {
                            Id = new Guid("28e82adb-2983-4474-ba1b-7d021d029fce"),
                            Name = "32gb",
                            Score = 9,
                            Type = "Ram"
                        },
                        new
                        {
                            Id = new Guid("7076f76e-0cf8-4b31-a157-31250b120c32"),
                            Name = "geen",
                            Score = 1,
                            Type = "GraphicsCard"
                        },
                        new
                        {
                            Id = new Guid("16e9d068-6143-429f-aa48-372a91dcf14c"),
                            Name = "1650-1660",
                            Score = 3,
                            Type = "GraphicsCard"
                        },
                        new
                        {
                            Id = new Guid("c5387426-b471-40ec-a398-e706bcedfa07"),
                            Name = "2060/3050-2070/3060",
                            Score = 5,
                            Type = "GraphicsCard"
                        },
                        new
                        {
                            Id = new Guid("81cea0e6-be48-4aee-9e4e-6a4dde9ad1a5"),
                            Name = "2070/3070-2080ti/3090",
                            Score = 8,
                            Type = "GraphicsCard"
                        },
                        new
                        {
                            Id = new Guid("7d07acea-afc5-414f-b0e7-1061015df961"),
                            Name = "13'",
                            Score = 1,
                            Type = "ScreenSize"
                        },
                        new
                        {
                            Id = new Guid("59255b6b-6bd7-45cf-8382-7d3030839ad1"),
                            Name = "14'",
                            Score = 2,
                            Type = "ScreenSize"
                        },
                        new
                        {
                            Id = new Guid("f90fb094-ec09-4947-b0d2-9a53b442663d"),
                            Name = "15'6",
                            Score = 3,
                            Type = "ScreenSize"
                        },
                        new
                        {
                            Id = new Guid("a2ef6731-33fb-48a6-95a0-31286245c9f5"),
                            Name = "17'",
                            Score = 4,
                            Type = "ScreenSize"
                        });
                });

            modelBuilder.Entity("nl.Commen.Models.Laptop", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("GraphicsCard")
                        .HasColumnType("longtext");

                    b.Property<string>("Price")
                        .HasColumnType("longtext");

                    b.Property<string>("Processor")
                        .HasColumnType("longtext");

                    b.Property<string>("Ram")
                        .HasColumnType("longtext");

                    b.Property<string>("ScreenSize")
                        .HasColumnType("longtext");

                    b.Property<string>("Storage")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Laptops");

                    b.HasData(
                        new
                        {
                            Id = new Guid("95fb27d1-fa69-427d-b826-2f533f866545"),
                            Price = "300"
                        },
                        new
                        {
                            Id = new Guid("a6445a90-ec65-4dfa-a814-33a0438c7f28"),
                            Price = "500"
                        },
                        new
                        {
                            Id = new Guid("67bdb653-4a64-4ca7-8811-da6722dae820"),
                            Price = "800"
                        },
                        new
                        {
                            Id = new Guid("df479930-dfac-4bdf-98a2-e592deeaa9f6"),
                            Price = "1200"
                        },
                        new
                        {
                            Id = new Guid("5921a866-4014-4c0b-bf3d-35f09f10e9d3"),
                            Price = "300"
                        },
                        new
                        {
                            Id = new Guid("2bc8bcdd-7c85-4992-a9f8-f786e6dbf3fb"),
                            Price = "500"
                        },
                        new
                        {
                            Id = new Guid("c1a35cf5-7ec0-48f9-952f-114df35be98e"),
                            Price = "800"
                        },
                        new
                        {
                            Id = new Guid("39eba8a5-4d7b-4077-873b-b7411bbac09d"),
                            Price = "1200"
                        },
                        new
                        {
                            Id = new Guid("dd880da3-613f-4672-b326-22ee9e840d85"),
                            Price = "300"
                        },
                        new
                        {
                            Id = new Guid("d7e6698f-05af-491c-98d5-3a264ac32655"),
                            Price = "500"
                        },
                        new
                        {
                            Id = new Guid("5869acfa-4eac-48b0-9b0b-5ec379cad441"),
                            Price = "800"
                        },
                        new
                        {
                            Id = new Guid("a5d37db9-956a-4410-a853-cb2b1de77c6d"),
                            Price = "1200"
                        },
                        new
                        {
                            Id = new Guid("3f130a78-4f70-41d7-bace-762f31f60df3"),
                            Price = "300"
                        },
                        new
                        {
                            Id = new Guid("83e9fb4b-2225-400e-b7dc-2f1e36ab65ef"),
                            Price = "500"
                        },
                        new
                        {
                            Id = new Guid("625cf5c9-1c94-4590-91ff-eb79ceb85f81"),
                            Price = "800"
                        },
                        new
                        {
                            Id = new Guid("eab11da2-0dd6-4f2d-9115-a027803949d3"),
                            Price = "1200"
                        });
                });

            modelBuilder.Entity("nl.Commen.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Question");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Text = "Hoeveel geld wilt u besteden?"
                        },
                        new
                        {
                            Id = 2,
                            Text = "Waar ga je je laptop voor gebruiken?"
                        },
                        new
                        {
                            Id = 3,
                            Text = "Is het vooral video of foto bewerking?"
                        },
                        new
                        {
                            Id = 4,
                            Text = "Wat voor soort games speelt u?"
                        },
                        new
                        {
                            Id = 5,
                            Text = "Welke van de onderstaande games heeft u gespeeld of bent u van plan te spelen?"
                        },
                        new
                        {
                            Id = 6,
                            Text = "Doet u het professioneel?"
                        },
                        new
                        {
                            Id = 7,
                            Text = "Heeft u vaak veel programma's tegelijkertijd aanstaan? (4 of meer)"
                        },
                        new
                        {
                            Id = 8,
                            Text = "Heeft U liever meer FPS, en/of betere graphics"
                        },
                        new
                        {
                            Id = 9,
                            Text = "Welk grootte scherm heeft u het liefst"
                        });
                });

            modelBuilder.Entity("nl.Commen.Models.SingleAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AnswerId")
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.Property<Guid?>("UserAnswerId")
                        .HasColumnType("char(36)");

                    b.HasKey("Id");

                    b.HasIndex("UserAnswerId");

                    b.ToTable("SingeAnswers");
                });

            modelBuilder.Entity("nl.Commen.Models.SingleAnswerTemp", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("AnswerId")
                        .HasColumnType("longtext");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("SingleAnswerTemp");
                });

            modelBuilder.Entity("nl.Commen.Models.UserAnswer", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("UserAnswers");
                });

            modelBuilder.Entity("nl.Commen.Models.SingleAnswer", b =>
                {
                    b.HasOne("nl.Commen.Models.UserAnswer", null)
                        .WithMany("Answers")
                        .HasForeignKey("UserAnswerId");
                });

            modelBuilder.Entity("nl.Commen.Models.UserAnswer", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}
