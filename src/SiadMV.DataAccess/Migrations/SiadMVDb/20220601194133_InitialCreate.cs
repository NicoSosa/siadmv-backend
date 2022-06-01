using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SiadMV.DataAccess.Migrations.SiadMVDb
{
    public partial class InitialCreate : Migration
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

            migrationBuilder.InsertData(
                table: "CommonExpression",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdateDate" },
                values: new object[,]
                {
                    { new Guid("b5b835bc-ac3e-4feb-aecd-7efbe905e506"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(5023), "base de datos", null },
                    { new Guid("e16cf954-7f86-40d4-b53c-0025371b986e"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(5184), "mysql", null },
                    { new Guid("6b7d1039-3cd0-492d-8f8c-f44c4258433b"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(5194), "usuario", null },
                    { new Guid("91db24af-ab97-44c9-90bd-5149cf4c4220"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(5197), "autenticación", null },
                    { new Guid("57840dab-205c-44b3-afd2-c38c56e03378"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(5200), "almacenamiento", null },
                    { new Guid("04fbf285-0439-4e9d-b986-86d5386c83bb"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(5203), "rapida", null },
                    { new Guid("14c18a5b-94d4-4f5e-9d96-fffd77696b89"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(5206), "backend", null }
                });

            migrationBuilder.InsertData(
                table: "KeyFact",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdateDate" },
                values: new object[,]
                {
                    { new Guid("e3d83a30-5707-4436-a79c-f8b6e83d5619"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4098), "framework", null },
                    { new Guid("81aeed67-9b3b-410b-baa6-706b47a5cc0e"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4093), "memoria ram", null },
                    { new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4090), "procesamiento", null },
                    { new Guid("c5b310a8-5f6b-4fa4-ac36-c36734c5cabb"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4096), ".net", null },
                    { new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4074), "sql", null },
                    { new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(3803), "autenticacion", null },
                    { new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4086), "autorizacion", null }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdateDate" },
                values: new object[,]
                {
                    { new Guid("3c5f06e0-e33f-40fb-a43e-4224addd1671"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4491), "Pregunta de autenticación 1", null },
                    { new Guid("4b72b1b6-f14b-43a0-8cee-b3824114eb35"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4676), "Pregunta de autenticación 1", null },
                    { new Guid("b6fd88b0-0f5e-4b4b-ad4c-c45410d0379b"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4687), "Pregunta de autorizacion", null },
                    { new Guid("68a5f73d-89d3-4eae-a229-c34670362963"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4690), "Pregunta de SQL 1", null },
                    { new Guid("1e0db6a4-c93e-41a9-97cf-8cb0b47e24db"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4693), "Pregunta de SQL 2", null },
                    { new Guid("4d1db6bb-a66f-4711-9225-4cbeeff08249"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4696), "Pregunta de Procesamiento 1", null },
                    { new Guid("e59feaf8-9813-4b77-b34a-2fc379e5e59a"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4699), "Pregunta de Procesamiento 2", null },
                    { new Guid("c1d6ceb7-313d-42a3-91d5-780aeb12dfca"), new DateTime(2022, 6, 1, 16, 41, 33, 487, DateTimeKind.Local).AddTicks(4702), "Pregunta de Procesamiento 3", null }
                });

            migrationBuilder.InsertData(
                table: "UserCase",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdateDate" },
                values: new object[,]
                {
                    { new Guid("e21d8bfc-f99a-493a-a76e-5c53342ca8ad"), new DateTime(2022, 6, 1, 16, 41, 33, 486, DateTimeKind.Local).AddTicks(6694), "Aplicación instalada en dispositivos móviles Android utilizados por personal que realiza la toma de datos de clientes de la empresa fuera de esta, esta aplicación accede a una base de datos MS SQLServer, mediante webservices ejecutados en el mismo servidor intercambian información con el aplicativo de negocios.", null },
                    { new Guid("8c8deead-324b-429f-a283-4cc48c51305d"), new DateTime(2022, 6, 1, 16, 41, 33, 485, DateTimeKind.Local).AddTicks(9255), "Una organización de alrededor de 60 usuarios requiere un sistema de control de asistencia, el mismo debe ser web y accedido por la red interna de la empresa, se solicita que el frontend sea elaborado en PHP y el backend utiliza una base de datos. Además se solicita poder realizar una rápida recuperación en caso de un evento inesperado.", null },
                    { new Guid("a134d0cb-89ce-4fce-b0d0-95069f927ff5"), new DateTime(2022, 6, 1, 16, 41, 33, 486, DateTimeKind.Local).AddTicks(6733), "Servicios de autenticación y almacenamiento de archivos común a toda la organización, la estructura de dominio es utilizada para autenticar varios servicios incluido el acceso a los diferentes aplicativos, el almacenamiento de archivos está formado por varios directorios compartidos según áreas con los permisos NTFS correspondientes por grupos y/o usuarios.", null }
                });

            migrationBuilder.InsertData(
                table: "CommonExpressionKeyFact",
                columns: new[] { "CommonExpressionId", "KeyFactId", "Id" },
                values: new object[,]
                {
                    { new Guid("91db24af-ab97-44c9-90bd-5149cf4c4220"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("ebe166db-d196-4055-a095-58aa19c34f72") },
                    { new Guid("14c18a5b-94d4-4f5e-9d96-fffd77696b89"), new Guid("e3d83a30-5707-4436-a79c-f8b6e83d5619"), new Guid("289783b9-bc3d-4a11-a187-5f9390c93e48") },
                    { new Guid("04fbf285-0439-4e9d-b986-86d5386c83bb"), new Guid("81aeed67-9b3b-410b-baa6-706b47a5cc0e"), new Guid("bcfcd082-c81a-435e-bb83-152594c39343") },
                    { new Guid("04fbf285-0439-4e9d-b986-86d5386c83bb"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("c9633ccf-ac22-4dbc-9998-162f7caeb92f") },
                    { new Guid("6b7d1039-3cd0-492d-8f8c-f44c4258433b"), new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new Guid("ffd80884-6609-4d68-81ff-1c033e4a6b8d") },
                    { new Guid("14c18a5b-94d4-4f5e-9d96-fffd77696b89"), new Guid("c5b310a8-5f6b-4fa4-ac36-c36734c5cabb"), new Guid("bb9ac5c4-259b-4153-8dec-008e52514833") },
                    { new Guid("57840dab-205c-44b3-afd2-c38c56e03378"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("49992ff4-064f-4918-8d2f-2a3e3f94ee8f") },
                    { new Guid("e16cf954-7f86-40d4-b53c-0025371b986e"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("7126efaa-a67f-4b8c-9a76-c312c22dc334") },
                    { new Guid("b5b835bc-ac3e-4feb-aecd-7efbe905e506"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("c88cf859-d473-45c4-8b99-46ce6e180189") },
                    { new Guid("6b7d1039-3cd0-492d-8f8c-f44c4258433b"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("bd38c888-fb1e-49e7-bdb4-2ef7f398eff1") },
                    { new Guid("91db24af-ab97-44c9-90bd-5149cf4c4220"), new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new Guid("5dd73df5-a3ef-4316-b722-717c22bb0472") }
                });

            migrationBuilder.InsertData(
                table: "QuestionKeyFact",
                columns: new[] { "QuestionId", "KeyFactId", "Id" },
                values: new object[,]
                {
                    { new Guid("e59feaf8-9813-4b77-b34a-2fc379e5e59a"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("3ea7d2bc-41d9-4693-b34e-268ffb3cc92c") },
                    { new Guid("3c5f06e0-e33f-40fb-a43e-4224addd1671"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("a5e09e3c-c413-4aac-b8cc-0cb58ee7e005") },
                    { new Guid("4b72b1b6-f14b-43a0-8cee-b3824114eb35"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("b45cf9d8-fe14-4639-ac97-3f4a89a58b1f") },
                    { new Guid("b6fd88b0-0f5e-4b4b-ad4c-c45410d0379b"), new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new Guid("a020bb9e-b517-4b75-9541-1fad4f4b115b") },
                    { new Guid("68a5f73d-89d3-4eae-a229-c34670362963"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("f6471dc5-603f-45bd-aa6b-5e0ec68c8ed0") },
                    { new Guid("1e0db6a4-c93e-41a9-97cf-8cb0b47e24db"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("dc622982-95ac-42d3-b85d-b366649d0ad8") },
                    { new Guid("4d1db6bb-a66f-4711-9225-4cbeeff08249"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("950c3ae2-4733-4e08-bb95-0e79bef04737") },
                    { new Guid("c1d6ceb7-313d-42a3-91d5-780aeb12dfca"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("74855325-2e4b-4097-804b-45bd2d02d8f2") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CommonExpressionKeyFact_KeyFactId",
                table: "CommonExpressionKeyFact",
                column: "KeyFactId");

            migrationBuilder.CreateIndex(
                name: "IX_QuestionKeyFact_KeyFactId",
                table: "QuestionKeyFact",
                column: "KeyFactId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CommonExpressionKeyFact");

            migrationBuilder.DropTable(
                name: "QuestionKeyFact");

            migrationBuilder.DropTable(
                name: "UserCase");

            migrationBuilder.DropTable(
                name: "CommonExpression");

            migrationBuilder.DropTable(
                name: "KeyFact");

            migrationBuilder.DropTable(
                name: "Question");
        }
    }
}
