using Microsoft.EntityFrameworkCore.Migrations;

namespace RegistrationApp.Migrations
{
    public partial class DataSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Answers",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Taip" },
                    { 2, "Ne" },
                    { 3, "Metinis rangovas" },
                    { 4, "Konkursinis rangovas" },
                    { 5, "Nekonkursinis rangovas" },
                    { 6, "Automatinis" },
                    { 7, "Rankinis" }
                });

            migrationBuilder.InsertData(
                table: "Forms",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Registracijos požymiai" },
                    { 2, "Forma 2" },
                    { 3, "Forma 3" },
                    { 4, "Forma 4" }
                });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Reikia atlikti rangos darbus" },
                    { 2, "Rangos darbus atliks" },
                    { 3, "Verslo klientas" },
                    { 4, "Skaičiavimo metodas" },
                    { 5, "Svarbus klientas" }
                });

            migrationBuilder.InsertData(
                table: "FormsQuestions",
                columns: new[] { "Id", "FormId", "QuestionId" },
                values: new object[,]
                {
                    { 1, 1, 1 },
                    { 9, 3, 5 },
                    { 5, 1, 5 },
                    { 8, 3, 4 },
                    { 4, 1, 4 },
                    { 3, 1, 3 },
                    { 7, 2, 3 },
                    { 2, 1, 2 },
                    { 6, 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "QuestionsAnswers",
                columns: new[] { "Id", "AnswerId", "QuestionId" },
                values: new object[,]
                {
                    { 5, 5, 2 },
                    { 3, 3, 2 },
                    { 10, 1, 5 },
                    { 6, 1, 3 },
                    { 7, 2, 3 },
                    { 2, 2, 1 },
                    { 8, 6, 4 },
                    { 9, 7, 4 },
                    { 1, 1, 1 },
                    { 4, 4, 2 },
                    { 11, 2, 5 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "FormsQuestions",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "QuestionsAnswers",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Answers",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Forms",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
