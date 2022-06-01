using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiadMV.DataAccess.Migrations.SiadMVDb
{
    public partial class AddCommonExpression : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CommonExpression",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    LastUpdateDate = table.Column<DateTime>(nullable: true),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonExpression", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CommonExpressionKeyFact",
                columns: table => new
                {
                    KeyFactId = table.Column<Guid>(nullable: false),
                    CommonExpressionId = table.Column<Guid>(nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CommonExpressionKeyFact", x => new { x.CommonExpressionId, x.KeyFactId });
                    table.ForeignKey(
                        name: "FK_CommonExpressionKeyFact_CommonExpression_CommonExpressionId",
                        column: x => x.CommonExpressionId,
                        principalTable: "CommonExpression",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CommonExpressionKeyFact_KeyFact_KeyFactId",
                        column: x => x.KeyFactId,
                        principalTable: "KeyFact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommonExpressionKeyFact_KeyFactId",
                table: "CommonExpressionKeyFact",
                column: "KeyFactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommonExpressionKeyFact");

            migrationBuilder.DropTable(
                name: "CommonExpression");
        }
    }
}
