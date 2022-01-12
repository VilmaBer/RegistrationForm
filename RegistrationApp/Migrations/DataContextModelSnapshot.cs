﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RegistrationApp.Data;

namespace RegistrationApp.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.13")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RegistrationApp.Models.Answer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Answers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Taip"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Ne"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Metinis rangovas"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Konkursinis rangovas"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Nekonkursinis rangovas"
                        },
                        new
                        {
                            Id = 6,
                            Title = "Automatinis"
                        },
                        new
                        {
                            Id = 7,
                            Title = "Rankinis"
                        });
                });

            modelBuilder.Entity("RegistrationApp.Models.Form", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Forms");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Registracijos požymiai"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Forma 2"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Forma 3"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Forma 4"
                        });
                });

            modelBuilder.Entity("RegistrationApp.Models.FormQuestion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FormId");

                    b.HasIndex("QuestionId");

                    b.ToTable("FormsQuestions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FormId = 1,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            FormId = 1,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 3,
                            FormId = 1,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 4,
                            FormId = 1,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 5,
                            FormId = 1,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 6,
                            FormId = 2,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 7,
                            FormId = 2,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            FormId = 3,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 9,
                            FormId = 3,
                            QuestionId = 5
                        });
                });

            modelBuilder.Entity("RegistrationApp.Models.FormQuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("FormId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("FormId");

                    b.HasIndex("QuestionId");

                    b.ToTable("FormsQuestionsAnswers");
                });

            modelBuilder.Entity("RegistrationApp.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Title = "Reikia atlikti rangos darbus"
                        },
                        new
                        {
                            Id = 2,
                            Title = "Rangos darbus atliks"
                        },
                        new
                        {
                            Id = 3,
                            Title = "Verslo klientas"
                        },
                        new
                        {
                            Id = 4,
                            Title = "Skaičiavimo metodas"
                        },
                        new
                        {
                            Id = 5,
                            Title = "Svarbus klientas"
                        });
                });

            modelBuilder.Entity("RegistrationApp.Models.QuestionAnswer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("AnswerId")
                        .HasColumnType("int");

                    b.Property<int>("QuestionId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("AnswerId");

                    b.HasIndex("QuestionId");

                    b.ToTable("QuestionsAnswers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AnswerId = 1,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 2,
                            AnswerId = 2,
                            QuestionId = 1
                        },
                        new
                        {
                            Id = 3,
                            AnswerId = 3,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 4,
                            AnswerId = 4,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 5,
                            AnswerId = 5,
                            QuestionId = 2
                        },
                        new
                        {
                            Id = 6,
                            AnswerId = 1,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 7,
                            AnswerId = 2,
                            QuestionId = 3
                        },
                        new
                        {
                            Id = 8,
                            AnswerId = 6,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 9,
                            AnswerId = 7,
                            QuestionId = 4
                        },
                        new
                        {
                            Id = 10,
                            AnswerId = 1,
                            QuestionId = 5
                        },
                        new
                        {
                            Id = 11,
                            AnswerId = 2,
                            QuestionId = 5
                        });
                });

            modelBuilder.Entity("RegistrationApp.Models.FormQuestion", b =>
                {
                    b.HasOne("RegistrationApp.Models.Form", "Form")
                        .WithMany("FormQuestions")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationApp.Models.Question", "Question")
                        .WithMany("FormQuestions")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Form");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RegistrationApp.Models.FormQuestionAnswer", b =>
                {
                    b.HasOne("RegistrationApp.Models.Answer", "Answer")
                        .WithMany("FormQuestionAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationApp.Models.Form", null)
                        .WithMany("FormQuestionAnswers")
                        .HasForeignKey("FormId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationApp.Models.Question", "Question")
                        .WithMany("FormQuestionAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RegistrationApp.Models.QuestionAnswer", b =>
                {
                    b.HasOne("RegistrationApp.Models.Answer", "Answer")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("AnswerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("RegistrationApp.Models.Question", "Question")
                        .WithMany("QuestionAnswers")
                        .HasForeignKey("QuestionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Answer");

                    b.Navigation("Question");
                });

            modelBuilder.Entity("RegistrationApp.Models.Answer", b =>
                {
                    b.Navigation("FormQuestionAnswers");

                    b.Navigation("QuestionAnswers");
                });

            modelBuilder.Entity("RegistrationApp.Models.Form", b =>
                {
                    b.Navigation("FormQuestionAnswers");

                    b.Navigation("FormQuestions");
                });

            modelBuilder.Entity("RegistrationApp.Models.Question", b =>
                {
                    b.Navigation("FormQuestionAnswers");

                    b.Navigation("FormQuestions");

                    b.Navigation("QuestionAnswers");
                });
#pragma warning restore 612, 618
        }
    }
}