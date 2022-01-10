﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using nl.Data;

namespace nl.Data.Migrations
{
    [DbContext(typeof(NlTutContext))]
    [Migration("20211206134548_answerdata")]
    partial class answerdata
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.Property<Guid?>("ResultsId")
                        .HasColumnType("char(36)");

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("ResultsId");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("76ac7dbf-8c8c-4e88-a339-c8504d73a6f1"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "300-500"
                        },
                        new
                        {
                            Id = new Guid("4d1321cb-6726-4620-aedc-16fc0c62c74e"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "500-800"
                        },
                        new
                        {
                            Id = new Guid("26e3351a-50e0-4988-8a52-43fb3deab1b4"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "800-1200"
                        },
                        new
                        {
                            Id = new Guid("0a773ef6-962f-473d-bf81-4d2debcadd29"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "1200+"
                        },
                        new
                        {
                            Id = new Guid("92b391da-519c-4282-975a-dbdeb6f0ac9d"),
                            NextQuestionId = 1,
                            QuestionId = 2,
                            Text = "Mail / Netflix & YouTube"
                        },
                        new
                        {
                            Id = new Guid("6f74d08f-07e1-4544-b440-6fd1f0fd3914"),
                            NextQuestionId = 1,
                            QuestionId = 2,
                            Text = "Documenten bewerken"
                        },
                        new
                        {
                            Id = new Guid("1f9cc97a-2938-4779-8ce7-3fbba83416cb"),
                            NextQuestionId = 1,
                            QuestionId = 2,
                            Text = "Foto's/videdo's bewerken"
                        },
                        new
                        {
                            Id = new Guid("78b5c186-58db-49ca-9c70-19c661ca1412"),
                            NextQuestionId = 1,
                            QuestionId = 2,
                            Text = "Gamen"
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
                            Text = "Waar ga je je laptop voor gebruiken"
                        });
                });

            modelBuilder.Entity("nl.Commen.Models.Results", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Token")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Results");
                });

            modelBuilder.Entity("nl.Commen.Models.Answer", b =>
                {
                    b.HasOne("nl.Commen.Models.Results", null)
                        .WithMany("Answers")
                        .HasForeignKey("ResultsId");
                });

            modelBuilder.Entity("nl.Commen.Models.Results", b =>
                {
                    b.Navigation("Answers");
                });
#pragma warning restore 612, 618
        }
    }
}