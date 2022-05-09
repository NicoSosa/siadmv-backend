using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiadMV.DataAccess.Migrations.SiadMVDb
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KeyFact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KeyFact", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Question",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Question", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserCase",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserCase", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionKeyFact",
                columns: table => new
                {
                    KeyFactId = table.Column<Guid>(nullable: false),
                    QuestionId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionKeyFact", x => new { x.QuestionId, x.KeyFactId });
                    table.ForeignKey(
                        name: "FK_QuestionKeyFact_KeyFact_KeyFactId",
                        column: x => x.KeyFactId,
                        principalTable: "KeyFact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_QuestionKeyFact_Question_QuestionId",
                        column: x => x.QuestionId,
                        principalTable: "Question",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_QuestionKeyFact_KeyFactId",
                table: "QuestionKeyFact",
                column: "KeyFactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "QuestionKeyFact");

            migrationBuilder.DropTable(
                name: "UserCase");

            migrationBuilder.DropTable(
                name: "KeyFact");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
