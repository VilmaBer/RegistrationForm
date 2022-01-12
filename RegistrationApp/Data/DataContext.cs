using Microsoft.EntityFrameworkCore;
using RegistrationApp.Models;

namespace RegistrationApp.Data
{
    public class DataContext : DbContext
    {
        public DbSet<Form> Forms { get; set; }

        public DbSet<Question> Questions { get; set; }

        public DbSet<FormQuestion> FormsQuestions { get; set; }

        public DbSet<Answer> Answers { get; set; }

        public DbSet<QuestionAnswer> QuestionsAnswers { get; set; }

        public DbSet<FormQuestionAnswer> FormsQuestionsAnswers { get; set; }

        public DataContext(DbContextOptions<DataContext> options)
               : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>();
            modelBuilder.Entity<Question>();
            modelBuilder.Entity<FormQuestion>();
            modelBuilder.Entity<Answer>();
            modelBuilder.Entity<QuestionAnswer>();
            modelBuilder.Entity<FormQuestionAnswer>();

            DataSeed(modelBuilder);
        }

        private static void DataSeed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Form>().HasData(
                new Form
                {
                    Id = 1,
                    Title = "Registracijos požymiai"
                },
                new Form
                {
                    Id = 2,
                    Title = "Forma 2"
                }, new Form
                {
                    Id = 3,
                    Title = "Forma 3"
                }, new Form
                {
                    Id = 4,
                    Title = "Forma 4"
                });

            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = 1,
                    Title = "Reikia atlikti rangos darbus"
                },
                new Question
                {
                    Id = 2,
                    Title = "Rangos darbus atliks"
                },
                new Question
                {
                    Id = 3,
                    Title = "Verslo klientas"
                },
                new Question
                {
                    Id = 4,
                    Title = "Skaičiavimo metodas"
                },
                new Question
                {
                    Id = 5,
                    Title = "Svarbus klientas"
                }
                );

            modelBuilder.Entity<FormQuestion>().HasData(
                new FormQuestion
                {
                    Id = 1,
                    FormId = 1,
                    QuestionId = 1,
                },

                 new FormQuestion
                 {
                     Id = 2,
                     FormId = 1,
                     QuestionId = 2,
                 },

                  new FormQuestion
                  {
                      Id = 3,
                      FormId = 1,
                      QuestionId = 3,
                  },

                   new FormQuestion
                   {
                       Id = 4,
                       FormId = 1,
                       QuestionId = 4,
                   },

                    new FormQuestion
                    {
                        Id = 5,
                        FormId = 1,
                        QuestionId = 5,
                    },

                    new FormQuestion
                    {
                        Id = 6,
                        FormId = 2,
                        QuestionId = 1,
                    },

                    new FormQuestion
                    {
                        Id = 7,
                        FormId = 2,
                        QuestionId = 3,
                    },

                     new FormQuestion
                     {
                         Id = 8,
                         FormId = 3,
                         QuestionId = 4,
                     },

                      new FormQuestion
                      {
                          Id = 9,
                          FormId = 3,
                          QuestionId = 5,
                      });

            modelBuilder.Entity<Answer>().HasData(
                 new Answer
                 {
                     Id = 1,
                     Title = "Taip"
                 },
                  new Answer
                  {
                      Id = 2,
                      Title = "Ne"
                  },
                   new Answer
                   {
                       Id = 3,
                       Title = "Metinis rangovas"
                   },
                    new Answer
                    {
                        Id = 4,
                        Title = "Konkursinis rangovas"
                    },

                    new Answer
                    {
                        Id = 5,
                        Title = "Nekonkursinis rangovas"
                    },

                    new Answer
                    {
                        Id = 6,
                        Title = "Automatinis"
                    },

                    new Answer
                    {
                        Id = 7,
                        Title = "Rankinis"
                    });


            modelBuilder.Entity<QuestionAnswer>().HasData(

                   new QuestionAnswer()
                   {
                       Id = 1,
                       QuestionId = 1,
                       AnswerId = 1,
                   },

                   new QuestionAnswer()
                   {
                       Id = 2,
                       QuestionId = 1,
                       AnswerId = 2,
                   },
                   new QuestionAnswer()
                   {
                       Id = 3,
                       QuestionId = 2,
                       AnswerId = 3,
                   },
                   new QuestionAnswer()
                   {
                       Id = 4,
                       QuestionId = 2,
                       AnswerId = 4,
                   },

                   new QuestionAnswer()
                   {
                       Id = 5,
                       QuestionId = 2,
                       AnswerId = 5,
                   },
                   new QuestionAnswer()
                   {
                       Id = 6,
                       QuestionId = 3,
                       AnswerId = 1,
                   },
                   new QuestionAnswer()
                   {
                       Id = 7,
                       QuestionId = 3,
                       AnswerId = 2,
                   },
                   new QuestionAnswer()
                   {
                       Id = 8,
                       QuestionId = 4,
                       AnswerId = 6,
                   },
                     //
                     new QuestionAnswer()
                     {
                         Id = 9,
                         QuestionId = 4,
                         AnswerId = 7,
                     },
                   new QuestionAnswer()
                   {
                       Id = 10,
                       QuestionId = 5,
                       AnswerId = 1,
                   },
                   new QuestionAnswer()
                   {
                       Id = 11,
                       QuestionId = 5,
                       AnswerId = 2,
                   });

            //modelBuilder.Entity<FormQuestionAnswer>().HasData(
            //    new FormQuestionAnswer
            //    {
            //        Id = 1,
            //        FormId = 1,
            //        QuestionId = 1,
            //        AnswerId = 2,
            //    },
            //     new FormQuestionAnswer
            //     {
            //         Id = 2,
            //         FormId = 1,
            //         QuestionId = 2,
            //         AnswerId = 3,
            //     }
            //    );
           
        }
    }
}
