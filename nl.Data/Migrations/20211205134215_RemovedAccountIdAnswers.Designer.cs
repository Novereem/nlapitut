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
    [Migration("20211205134215_RemovedAccountIdAnswers")]
    partial class RemovedAccountIdAnswers
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

                    b.Property<string>("Text")
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Answer");

                    b.HasData(
                        new
                        {
                            Id = new Guid("ffb04f72-20dd-4923-a3a4-740e0926d088"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "300-500"
                        },
                        new
                        {
                            Id = new Guid("49466a1b-aa6a-4cca-bee0-b7bb3cc84fc0"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "500-800"
                        },
                        new
                        {
                            Id = new Guid("c433cd38-7ae7-44e8-b903-82ccbc2dc538"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "800-1200"
                        },
                        new
                        {
                            Id = new Guid("26c50887-64eb-447c-bdcd-e597144fd04d"),
                            NextQuestionId = 2,
                            QuestionId = 1,
                            Text = "1200+"
                        },
                        new
                        {
                            Id = new Guid("4fb3e94a-0c24-4caa-8f5c-db3c36ca5723"),
                            NextQuestionId = 1,
                            QuestionId = 2,
                            Text = "Mail / Netflix & YouTube"
                        },
                        new
                        {
                            Id = new Guid("4c090277-858a-49cb-84a8-447e47096a17"),
                            NextQuestionId = 1,
                            QuestionId = 2,
                            Text = "Documenten bewerken"
                        },
                        new
                        {
                            Id = new Guid("ccde1b84-09e6-4cd5-bef6-19ac088ee8be"),
                            NextQuestionId = 1,
                            QuestionId = 2,
                            Text = "Foto's/videdo's bewerken"
                        },
                        new
                        {
                            Id = new Guid("a6c8731f-f2ca-45a2-9f0b-c0a18628488b"),
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
#pragma warning restore 612, 618
        }
    }
}
