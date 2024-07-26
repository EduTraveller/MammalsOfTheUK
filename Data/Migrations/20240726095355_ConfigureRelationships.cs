using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MammalsOfTheUK.Data.Migrations
{
    /// <inheritdoc />
    public partial class ConfigureRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Mammals",
                columns: table => new
                {
                    MammalID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Description = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    Image = table.Column<string>(type: "TEXT", maxLength: 120, nullable: false),
                    CommonName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    ScientificName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Family = table.Column<string>(type: "TEXT", maxLength: 50, nullable: false),
                    Habitat = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Diet = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    Origin = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    Predators = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    LooksLike = table.Column<string>(type: "TEXT", maxLength: 1000, nullable: false),
                    England = table.Column<int>(type: "INTEGER", nullable: true),
                    Wales = table.Column<int>(type: "INTEGER", nullable: true),
                    Scotland = table.Column<int>(type: "INTEGER", nullable: true),
                    NorthernIreland = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Mammals", x => x.MammalID);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    QuestionID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    QuizID = table.Column<int>(type: "INTEGER", nullable: false),
                    QuestionText = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    OptionA = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    OptionB = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    OptionC = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    OptionD = table.Column<string>(type: "TEXT", maxLength: 100, nullable: false),
                    CorrectOption = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.QuestionID);
                });

            migrationBuilder.CreateTable(
                name: "Quizzes",
                columns: table => new
                {
                    QuizID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    MammalID = table.Column<int>(type: "INTEGER", nullable: false),
                    Description = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Quizzes", x => x.QuizID);
                });

            migrationBuilder.CreateTable(
                name: "RiskCategories",
                columns: table => new
                {
                    MammalID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    England = table.Column<int>(type: "INTEGER", nullable: true),
                    Wales = table.Column<int>(type: "INTEGER", nullable: true),
                    Scotland = table.Column<int>(type: "INTEGER", nullable: true),
                    NorthernIreland = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RiskCategories", x => x.MammalID);
                });

            migrationBuilder.CreateTable(
                name: "UserQuizzes",
                columns: table => new
                {
                    UserID = table.Column<int>(type: "INTEGER", nullable: false),
                    QuizID = table.Column<int>(type: "INTEGER", nullable: false),
                    DateOfQuiz = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserQuizzes", x => new { x.UserID, x.QuizID });
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Mammals");

            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "Quizzes");

            migrationBuilder.DropTable(
                name: "RiskCategories");

            migrationBuilder.DropTable(
                name: "UserQuizzes");
        }
    }
}
