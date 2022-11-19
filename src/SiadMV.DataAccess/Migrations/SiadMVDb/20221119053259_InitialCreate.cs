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
                    { new Guid("b5b835bc-ac3e-4feb-aecd-7efbe905e506"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5476), "base de datos", null },
                    { new Guid("481998a3-9cde-4e99-9393-eeced6faa160"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5896), "servicios en cluster", null },
                    { new Guid("10b2a6d2-33e6-42f9-b3e8-6ffab049183d"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5893), "cluster", null },
                    { new Guid("f8d9b3c5-39dc-48e3-9ac2-c3b727fe79ae"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5890), "servidores propios", null },
                    { new Guid("0e66128e-d19c-4542-8558-bcae33ef9fe4"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5888), "funciones en la nube", null },
                    { new Guid("ad34523a-7c82-4dee-8ad1-c26f3101c5c5"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5882), "web services", null },
                    { new Guid("30a9a3d0-087b-4aef-89e7-bf143dc4d773"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5879), "servicios web", null },
                    { new Guid("a577cd73-4ca9-4a99-8683-d36a36b82f1e"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5876), "aws", null },
                    { new Guid("4891136a-21d4-4eae-9fa5-87d3d0d6a8f8"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5874), "servicios en la nube", null },
                    { new Guid("b0d76a1e-8894-461c-82ab-003cd186a2a7"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5871), "encriptación de datos", null },
                    { new Guid("57fd0ecf-d381-4ba6-b6e7-0fdd0ea2d9af"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5868), "información sensible", null },
                    { new Guid("f895169d-3814-46db-b085-5da06178a7b3"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5865), "alta seguridad", null },
                    { new Guid("91ce5bc7-02be-459f-9aac-4cb66e374ed6"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5862), "pago", null },
                    { new Guid("11599b84-9ef5-4a51-9071-a8a9ac4f82c9"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5859), "pagar", null },
                    { new Guid("17e66267-8b1f-4ba5-87e9-600bd14e3f90"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5857), "procesamiento interno", null },
                    { new Guid("733ec812-3269-4f5a-9135-430ca7e63bcd"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5854), "logica de negocio", null },
                    { new Guid("97ab4afe-c603-46c4-9de7-1b3f4a6e3c86"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5851), "roles de usuario", null },
                    { new Guid("555ea69d-affd-4d71-81d2-349fc50bab02"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5848), "estar logeado", null },
                    { new Guid("24a5d93a-b9d6-4bc9-b7ec-a576ca32b905"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5845), "permisos de usuario", null },
                    { new Guid("8f44631c-2039-447c-bc5c-d7eef33e525c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5843), "usuario logeado", null },
                    { new Guid("a567d736-85c4-4a03-86ab-5a6fc3db57d1"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5840), "iniciar sesion", null },
                    { new Guid("63af4f57-d7e3-460d-b3c2-aee6b27408c5"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5837), "backend distribuido", null },
                    { new Guid("e2cf3321-e586-4fbc-ad71-6d294468aadc"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5834), "microservicio ortogonal", null },
                    { new Guid("b5a32da5-4376-4e13-bcf0-5b22d105c652"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5832), "servicio de integracion", null },
                    { new Guid("355e777e-99ca-45bc-8d4a-a899eea8a536"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5829), "microservicio de integracion", null },
                    { new Guid("5ac3840a-1cef-4466-83fb-5bf8984dc94a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5826), "servicios transversales", null },
                    { new Guid("a17ff1c5-aafb-46f6-9e5a-cb065a3b3f23"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5899), "servidores remotos", null },
                    { new Guid("8aa5c10b-7cb5-4958-99dd-a954bec722fe"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5901), "servicios externos", null },
                    { new Guid("ad66d5b4-691e-4429-9bd5-3258dd7f06d2"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5904), "rapida respuesta", null },
                    { new Guid("0028fac7-b222-4345-a1ce-950828c7dcd4"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5907), "velocidad de respuesta", null },
                    { new Guid("14c18a5b-94d4-4f5e-9d96-fffd77696b89"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(6010), "backend", null },
                    { new Guid("c4d05448-6e5b-4ead-92f5-003106e313ba"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(6008), "no monolito", null },
                    { new Guid("b5896be7-664c-4b67-b181-e652ab02a227"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(6005), "muchos frameworks", null },
                    { new Guid("a2c84d3b-d38f-4a24-853c-b3830393aeb6"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(6002), "muchos lenguajes", null },
                    { new Guid("19bcdb8b-7bcc-46c8-a926-91ccad6dccf8"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5999), "multiple lenguajes", null },
                    { new Guid("e8097d1e-b593-40ea-971e-133def88a2e9"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5996), "multiple frameworks", null },
                    { new Guid("fb94b7a4-6ff7-48d0-9a29-513b12ce3181"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5963), "unico lenguaje", null },
                    { new Guid("e3ea656a-b3bb-4b7f-8623-da799a8091eb"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5960), "monolito", null },
                    { new Guid("5524b4c0-6509-4211-9384-4040b073b54b"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5957), "unica conexion", null },
                    { new Guid("0d966438-574d-4be6-bf4e-f13f137a5ce5"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5955), "características de conectividad individual", null },
                    { new Guid("39a3065c-2b5c-439f-8bc1-1bc9c9874c92"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5952), "logica centralizada", null },
                    { new Guid("e70201d4-59aa-40ef-9fb5-d24955d2ab76"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5949), "logica interna", null },
                    { new Guid("d47920a6-c9f1-482a-b88a-63303c43a08c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5824), "muchas peticiones seguidas", null },
                    { new Guid("e215b065-e265-41b6-87d3-e1f99a9c1671"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5946), "escalar servicios", null },
                    { new Guid("b5934e10-8c63-409a-8278-6274c853099f"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5941), "sistema monolítico", null },
                    { new Guid("d323391f-88d6-46b1-8aea-0ba01e6bfe98"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5938), "sin microservicios", null },
                    { new Guid("8305e0e4-146f-4a1b-b1fb-a25519f7d3a5"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5935), "arquitectura pequeña", null },
                    { new Guid("1b82f2a8-8915-401d-bab9-1702aafbfa3a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5932), "bajo presupuesto", null },
                    { new Guid("fc16c9f4-55d9-4952-bfae-00dcbbaaad19"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5930), "bajo costos de implementación", null },
                    { new Guid("3707e6b6-a3d3-4bcd-9026-b3c37c1195bd"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5927), "respuestas en tiempo real", null },
                    { new Guid("0fcc3c69-cc59-450a-809c-95cca12cbbdf"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5924), "procesar en tiempo real", null },
                    { new Guid("5bd3782f-92fe-407f-b9d0-2c9f0b71f37c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5921), "no asincronico", null },
                    { new Guid("7319ef65-e73a-4042-ba1f-60d8d6963498"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5918), "dependencia de sincronía", null },
                    { new Guid("e6ac71e1-47bc-4352-b7fe-6c31aa8252db"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5915), "logica sincronica", null },
                    { new Guid("e70d46dd-3c8d-4747-b97a-959a6d7a3152"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5913), "manejar desbordamiento", null },
                    { new Guid("e056b015-51d5-4c08-9ca9-a77666845045"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5910), "tolerancia a fallos", null },
                    { new Guid("50b0f7a2-ea0d-4816-bb12-d47b528b94b0"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5943), "microservicios propios", null },
                    { new Guid("4c8f03c1-bc2a-4a24-b75d-b58d56a9d6cd"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5821), "desbordamiento", null },
                    { new Guid("8724420f-6fbb-41ac-8a55-cbd19642569c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5885), "cloud functions", null },
                    { new Guid("7c26279c-047a-4ad6-9a7b-0291381b9dbc"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5815), "desbordamiento de búfer de la red", null },
                    { new Guid("a840cf20-407b-419c-b1f3-9b3f65c19b43"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5728), "log aggregation", null },
                    { new Guid("e797ff74-eb01-405e-9ef0-e910bfd9c8e7"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5726), "agregador de registros", null },
                    { new Guid("b6dfefd7-8b49-4558-ac21-3f496e732203"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5723), "servir contenido estatico", null },
                    { new Guid("af6aab50-75e9-4b99-91a5-10a6ffa50eb8"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5720), "almacenar cache", null },
                    { new Guid("b642df2f-896c-456a-a6c3-05d1d28538a9"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5717), "reducir ancho de banda", null },
                    { new Guid("20e2eb5e-a210-43f1-aa00-66b859a0de4a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5714), "cache de proxies", null },
                    { new Guid("fddcc624-2826-4bc4-8203-ffa388a83074"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5712), "cache de proxy", null },
                    { new Guid("4d7c68fc-af85-4ce1-8cc5-d2896a151b1b"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5709), "aplicacion legada", null },
                    { new Guid("8b4d1f4a-8fde-4fdd-a676-47d2fd02a18c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5706), "sistema legado", null },
                    { new Guid("210b4865-2e13-479a-a669-abba288e4603"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5703), "aplicacion heredada", null },
                    { new Guid("17c2e42e-648a-4ab2-89d5-c88e298e1728"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5701), "docker", null },
                    { new Guid("aff5c7f9-9c94-44ff-9331-b64b6c9d608d"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5698), "kubernetes", null },
                    { new Guid("da59d8f9-e03d-4458-8d90-ea0a9e5aea8a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5731), "centralizar logs", null },
                    { new Guid("f6cfdb5f-2cf6-497b-9232-c4c8bc55e744"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5695), "sistema operativo virtualizado", null },
                    { new Guid("ba33b380-9dee-46b5-a35b-dcc7e12e6be4"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5689), "contenedores", null },
                    { new Guid("44a5d060-717e-4c83-988f-7f420f99db16"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5686), "container", null },
                    { new Guid("57c12229-5827-45c0-830c-2f4395f0232b"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5684), "entorno de contenedores", null },
                    { new Guid("cc54a230-c2f2-4cc6-877f-f2a6f0aea177"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5681), "petición http", null },
                    { new Guid("688ffcd1-7411-4b6c-94ce-f9a9a612578e"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5678), "sistema heredado", null },
                    { new Guid("afe508e9-f73b-4f4b-830d-fd54efa5c460"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5675), "api de terceros", null },
                    { new Guid("1b95eaa2-8c1c-42d7-8963-9dff52138d58"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5818), "debordamiento por peticiones", null },
                    { new Guid("04fbf285-0439-4e9d-b986-86d5386c83bb"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5669), "rapida", null },
                    { new Guid("57840dab-205c-44b3-afd2-c38c56e03378"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5666), "almacenamiento", null },
                    { new Guid("91db24af-ab97-44c9-90bd-5149cf4c4220"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5663), "autenticación", null },
                    { new Guid("6b7d1039-3cd0-492d-8f8c-f44c4258433b"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5660), "usuario", null },
                    { new Guid("e16cf954-7f86-40d4-b53c-0025371b986e"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5649), "mysql", null },
                    { new Guid("da8282c2-3d62-4841-8e98-4e00940370bc"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5692), "containers", null },
                    { new Guid("64e4a04f-ec50-4ac4-a029-f2bed14d1c45"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5734), "persistir logs", null },
                    { new Guid("f3b04739-b8eb-47e0-b332-6f5c774a022a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5672), "api externa", null },
                    { new Guid("7aded8f4-3446-4aed-847a-939016790e21"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5739), "microservicios externos", null },
                    { new Guid("fbc8e63d-ca87-4592-a0b6-89ca7b4f1198"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5737), "logs centralizados", null },
                    { new Guid("ec1895ee-5696-4225-bb04-011181fe1a7a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5812), "desbordamiento de la red", null },
                    { new Guid("a3f6348b-9311-46a9-b986-f7d56e465791"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5809), "reducir el desbordamiento de la red", null },
                    { new Guid("df1c7d32-311a-4924-8e38-018e70be9842"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5806), "usar diferentes lenguajes", null },
                    { new Guid("4e475c0f-cbee-4fd3-822a-3c97171f95fe"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5804), "microservicios descentralizados", null },
                    { new Guid("487ad4fd-7f0f-46c6-8971-1dc54e070b61"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5801), "usar diferentes frameworks", null },
                    { new Guid("b53d120b-c5f7-4234-beb1-6b3b5c34e544"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5795), "maas", null },
                    { new Guid("7074375a-0b21-42b5-bbc5-c6a035e259a4"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5792), "servicios de monitoreo", null },
                    { new Guid("2cd3eb2b-edd2-45ea-b77e-31bfdcd1fcaf"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5789), "servicios de control", null },
                    { new Guid("e7a571b7-75f6-4fc3-9692-95be76e546c6"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5787), "ftp", null },
                    { new Guid("22c8df61-db25-4b81-9c82-9adc3d106ca9"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5784), "dns", null },
                    { new Guid("bbcdd396-f115-4204-8d28-1ac338ef6c86"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5781), "dhcp", null },
                    { new Guid("4fe8df6a-7364-468e-940d-e70dc8f94150"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5778), "red de area local", null },
                    { new Guid("1ae599b7-118b-4e43-ac58-aec6fd3cece5"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5798), "servicios de multi frameworks", null },
                    { new Guid("cff58552-b392-4eab-a7aa-928e51d8b14f"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5773), "lan", null },
                    { new Guid("14736895-fb4d-40a5-be91-b0458c344d97"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5770), "recursos compartidos en la red", null },
                    { new Guid("e9f53078-24d3-4ae3-974a-33b93e76da09"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5767), "conexion de red", null },
                    { new Guid("fb70406f-4ef7-435d-9986-a33f04d3e39c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5765), "infraestructura de red", null },
                    { new Guid("b486d799-d61a-40e3-bed1-fa6e283090ca"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5762), "servicios de red", null },
                    { new Guid("339f6fdf-fe4f-41d9-ab89-799ce4f56b7c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5759), "api", null },
                    { new Guid("9cf381f0-896a-4d43-a4fc-bdaf9dbe4a78"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5756), "arquitectura distribuida", null },
                    { new Guid("9d01c5bf-7f74-4509-a335-f73632fe4408"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5754), "arquitectura flexible", null },
                    { new Guid("263a8faf-e96a-43db-bd89-9934340c0759"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5742), "microservicios de terceros", null },
                    { new Guid("ad591242-9816-45ee-8178-847f8adab6e5"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5751), "arquitectura escalable", null },
                    { new Guid("9ddcbde3-d1d9-40d6-9b84-83ab88baa962"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5748), "microservicios", null },
                    { new Guid("01269a45-82ad-41d9-b85d-ecd8bff454d8"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5745), "aplicacion distrisbuida", null },
                    { new Guid("1f7db9e6-d640-49bd-8e7d-aefab5550d5a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5776), "wan", null }
                });

            migrationBuilder.InsertData(
                table: "KeyFact",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdateDate" },
                values: new object[,]
                {
                    { new Guid("d556aacd-e65f-48cb-8c0c-20ff552b384e"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4363), "soporte en la nube", null },
                    { new Guid("f9256021-ada7-44f8-bbc0-15724122bd2e"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4361), "alta seguridad", null },
                    { new Guid("1ba3d7dd-6cf5-4f51-adfb-55dc58edf0e2"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4352), "servicios de autorizacion", null },
                    { new Guid("64d54c94-ddb9-4a50-a1a8-6e09bf2c37f9"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4355), "soporte en cluster", null },
                    { new Guid("b2e58af5-6fdd-44b9-bf35-215ff236f34f"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4349), "servicios de autenticacion", null },
                    { new Guid("6e42c851-377a-4122-846e-11ef7bc37baf"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4358), "microservicios de soporte", null },
                    { new Guid("136eebb3-fbad-403f-8cd7-9b2a35b614e4"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4366), "latencia critica", null },
                    { new Guid("162eca2d-6b53-4125-bd0c-545bf4a61df0"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4383), "microservicios con unico lenguaje", null },
                    { new Guid("a9c1dc56-43df-4356-891a-ae8226881378"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4372), "arquitectura minima", null },
                    { new Guid("748c128b-731a-43c2-845d-7c21464e2616"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4375), "escalabilidad de servicios independiente", null },
                    { new Guid("8f5dc538-3929-404f-b3a5-faaef6a3f0db"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4377), "conectividad unica entre funcionalidades", null },
                    { new Guid("34dff11d-0482-4ae2-85ad-cc3f7622cab0"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4380), "microservicios con unico framework", null },
                    { new Guid("240adc46-8dea-4543-aebc-bc3c2e748289"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4386), "integracion profunda", null },
                    { new Guid("f66cfee5-5697-4ffa-bd92-12bd5412008d"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4388), "integracion de conectividad compleja", null },
                    { new Guid("e3d83a30-5707-4436-a79c-f8b6e83d5619"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4391), "framework", null },
                    { new Guid("62109b2a-e963-48f1-bd9c-7737e20b80a6"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4347), "host para multiples microservicios", null },
                    { new Guid("3ec064a8-36c1-4c2c-b8cc-5bd88cbd90b9"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4369), "respuestas sincronas", null },
                    { new Guid("b25a1d3b-4d23-4154-b434-fc1ff1991421"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4344), "reduccion de desbordamiento de red", null },
                    { new Guid("2a77fa7a-b9c5-400c-ad44-2e61e0f6fa90"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4315), "proxy caching", null },
                    { new Guid("f25c8852-2558-4d4d-956b-bdee6a94a972"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4338), "contendor de multiples responsabilidades", null },
                    { new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4008), "autenticacion", null },
                    { new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4280), "sql", null },
                    { new Guid("e8182736-f6a1-47e8-bd35-97142087e025"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4341), "servicios transversales", null },
                    { new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4297), "procesamiento", null },
                    { new Guid("81aeed67-9b3b-410b-baa6-706b47a5cc0e"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4301), "memoria ram", null },
                    { new Guid("c5b310a8-5f6b-4fa4-ac36-c36734c5cabb"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4303), ".net", null },
                    { new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4307), "entorno de contenedores", null },
                    { new Guid("10b4d9ce-65c1-4f6e-bfed-23d6c90801ab"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4309), "aplicaciones heredadas", null },
                    { new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4293), "autorizacion", null },
                    { new Guid("aa2504c2-0f5a-4517-bda8-adeb5c092061"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4319), "log aggregator", null },
                    { new Guid("fdff5ec3-e510-48d7-b10c-bfeca06f152d"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4322), "microservicios externos", null },
                    { new Guid("72f09b3b-6e1c-483a-99f9-56dc9a72ff76"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4324), "arquitectura de microservicios", null },
                    { new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4327), "servicios de redes", null },
                    { new Guid("45fb724c-d736-45f2-82c1-db6945a46677"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4330), "monitoreo de servicios", null },
                    { new Guid("11228834-5692-4149-a8ad-514430a106a1"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4333), "microservicios con multiples frameworks", null },
                    { new Guid("39bcf484-8eb9-4987-939b-2073bac0d7f4"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4336), "microservicios con multiples lenguajes", null },
                    { new Guid("d5c00bf4-e203-4456-bc36-749433303d49"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4313), "servicios heredados", null }
                });

            migrationBuilder.InsertData(
                table: "Question",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdateDate" },
                values: new object[,]
                {
                    { new Guid("c1d6ceb7-313d-42a3-91d5-780aeb12dfca"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5092), "Pregunta de Procesamiento 3", null },
                    { new Guid("e59feaf8-9813-4b77-b34a-2fc379e5e59a"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5089), "Pregunta de Procesamiento 2", null },
                    { new Guid("4d1db6bb-a66f-4711-9225-4cbeeff08249"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5087), "Pregunta de Procesamiento 1", null },
                    { new Guid("1e0db6a4-c93e-41a9-97cf-8cb0b47e24db"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5084), "Pregunta de SQL 2", null },
                    { new Guid("4b72b1b6-f14b-43a0-8cee-b3824114eb35"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5068), "Pregunta de autenticación 1", null },
                    { new Guid("b6fd88b0-0f5e-4b4b-ad4c-c45410d0379b"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5078), "Pregunta de autorizacion", null },
                    { new Guid("3c5f06e0-e33f-40fb-a43e-4224addd1671"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(4844), "Pregunta de autenticación 1", null },
                    { new Guid("68a5f73d-89d3-4eae-a229-c34670362963"), new DateTime(2022, 11, 19, 2, 32, 59, 323, DateTimeKind.Local).AddTicks(5081), "Pregunta de SQL 1", null }
                });

            migrationBuilder.InsertData(
                table: "UserCase",
                columns: new[] { "Id", "CreationDate", "Description", "LastUpdateDate" },
                values: new object[,]
                {
                    { new Guid("e21d8bfc-f99a-493a-a76e-5c53342ca8ad"), new DateTime(2022, 11, 19, 2, 32, 59, 322, DateTimeKind.Local).AddTicks(5970), "Aplicación instalada en dispositivos móviles Android utilizados por personal que realiza la toma de datos de clientes de la empresa fuera de esta, esta aplicación accede a una base de datos MS SQLServer, mediante webservices ejecutados en el mismo servidor intercambian información con el aplicativo de negocios.", null },
                    { new Guid("8c8deead-324b-429f-a283-4cc48c51305d"), new DateTime(2022, 11, 19, 2, 32, 59, 321, DateTimeKind.Local).AddTicks(8000), "Una organización de alrededor de 60 usuarios requiere un sistema de control de asistencia, el mismo debe ser web y accedido por la red interna de la empresa, se solicita que el frontend sea elaborado en PHP y el backend utiliza una base de datos. Además se solicita poder realizar una rápida recuperación en caso de un evento inesperado.", null },
                    { new Guid("a134d0cb-89ce-4fce-b0d0-95069f927ff5"), new DateTime(2022, 11, 19, 2, 32, 59, 322, DateTimeKind.Local).AddTicks(6007), "Servicios de autenticación y almacenamiento de archivos común a toda la organización, la estructura de dominio es utilizada para autenticar varios servicios incluido el acceso a los diferentes aplicativos, el almacenamiento de archivos está formado por varios directorios compartidos según áreas con los permisos NTFS correspondientes por grupos y/o usuarios.", null }
                });

            migrationBuilder.InsertData(
                table: "CommonExpressionKeyFact",
                columns: new[] { "CommonExpressionId", "KeyFactId", "Id" },
                values: new object[,]
                {
                    { new Guid("91db24af-ab97-44c9-90bd-5149cf4c4220"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("b1227d68-6952-41d4-b10e-4aa22eff5f82") },
                    { new Guid("91ce5bc7-02be-459f-9aac-4cb66e374ed6"), new Guid("f9256021-ada7-44f8-bbc0-15724122bd2e"), new Guid("91609937-fb59-41a3-9526-2246440353c6") },
                    { new Guid("f895169d-3814-46db-b085-5da06178a7b3"), new Guid("f9256021-ada7-44f8-bbc0-15724122bd2e"), new Guid("2ff7ac1e-9d7c-4acd-9165-530ba25726dd") },
                    { new Guid("57fd0ecf-d381-4ba6-b6e7-0fdd0ea2d9af"), new Guid("f9256021-ada7-44f8-bbc0-15724122bd2e"), new Guid("8bf3b31c-ffca-428c-b32b-d31594b6d04c") },
                    { new Guid("b0d76a1e-8894-461c-82ab-003cd186a2a7"), new Guid("f9256021-ada7-44f8-bbc0-15724122bd2e"), new Guid("26492367-3c1d-483c-8380-e614b6214d20") },
                    { new Guid("4891136a-21d4-4eae-9fa5-87d3d0d6a8f8"), new Guid("d556aacd-e65f-48cb-8c0c-20ff552b384e"), new Guid("35469481-9754-489f-93cd-142961b6e5bb") },
                    { new Guid("a577cd73-4ca9-4a99-8683-d36a36b82f1e"), new Guid("d556aacd-e65f-48cb-8c0c-20ff552b384e"), new Guid("6ac7b2b7-a153-444a-9a56-197cd4150eb4") },
                    { new Guid("11599b84-9ef5-4a51-9071-a8a9ac4f82c9"), new Guid("f9256021-ada7-44f8-bbc0-15724122bd2e"), new Guid("4f0d6de8-82c5-4ded-9808-eb87d9f603f7") },
                    { new Guid("30a9a3d0-087b-4aef-89e7-bf143dc4d773"), new Guid("d556aacd-e65f-48cb-8c0c-20ff552b384e"), new Guid("bb69323e-ab13-4b29-8d71-4b832a83d04c") },
                    { new Guid("8724420f-6fbb-41ac-8a55-cbd19642569c"), new Guid("d556aacd-e65f-48cb-8c0c-20ff552b384e"), new Guid("29b12af1-15cf-40d4-a2d0-f8b6d8b184fa") },
                    { new Guid("0e66128e-d19c-4542-8558-bcae33ef9fe4"), new Guid("d556aacd-e65f-48cb-8c0c-20ff552b384e"), new Guid("2ba9381a-91d0-450d-98bd-43503a549c25") },
                    { new Guid("ad66d5b4-691e-4429-9bd5-3258dd7f06d2"), new Guid("136eebb3-fbad-403f-8cd7-9b2a35b614e4"), new Guid("d3333e4c-035f-4e82-9fbb-db0684db3059") },
                    { new Guid("0028fac7-b222-4345-a1ce-950828c7dcd4"), new Guid("136eebb3-fbad-403f-8cd7-9b2a35b614e4"), new Guid("6ff44471-c6bb-4e98-ae86-e6edc85ab2b9") },
                    { new Guid("e056b015-51d5-4c08-9ca9-a77666845045"), new Guid("136eebb3-fbad-403f-8cd7-9b2a35b614e4"), new Guid("09963857-d245-4559-aabf-c7160f2f1f27") },
                    { new Guid("e70d46dd-3c8d-4747-b97a-959a6d7a3152"), new Guid("136eebb3-fbad-403f-8cd7-9b2a35b614e4"), new Guid("0e796ddf-dc96-480d-9212-8e2b6849ce13") },
                    { new Guid("ad34523a-7c82-4dee-8ad1-c26f3101c5c5"), new Guid("d556aacd-e65f-48cb-8c0c-20ff552b384e"), new Guid("50a60b1c-0f46-4172-b895-2de7e955ec0e") },
                    { new Guid("e6ac71e1-47bc-4352-b7fe-6c31aa8252db"), new Guid("3ec064a8-36c1-4c2c-b8cc-5bd88cbd90b9"), new Guid("95b19254-1a6c-48a8-aa68-30df26899ae8") },
                    { new Guid("17e66267-8b1f-4ba5-87e9-600bd14e3f90"), new Guid("6e42c851-377a-4122-846e-11ef7bc37baf"), new Guid("d1f2fa34-f423-43df-854a-a072f3fc0fb7") },
                    { new Guid("4e475c0f-cbee-4fd3-822a-3c97171f95fe"), new Guid("6e42c851-377a-4122-846e-11ef7bc37baf"), new Guid("4663ad1e-25ed-4077-a7b2-286fecde319a") },
                    { new Guid("263a8faf-e96a-43db-bd89-9934340c0759"), new Guid("62109b2a-e963-48f1-bd9c-7737e20b80a6"), new Guid("1fbef5d3-7674-49a8-9c7c-3c5edbd324b8") },
                    { new Guid("a567d736-85c4-4a03-86ab-5a6fc3db57d1"), new Guid("b2e58af5-6fdd-44b9-bf35-215ff236f34f"), new Guid("7f96b2c0-0136-4678-8d3c-886a3ba779d6") },
                    { new Guid("8f44631c-2039-447c-bc5c-d7eef33e525c"), new Guid("b2e58af5-6fdd-44b9-bf35-215ff236f34f"), new Guid("cc116b4e-1fa0-4220-b40c-44685a7e1562") },
                    { new Guid("24a5d93a-b9d6-4bc9-b7ec-a576ca32b905"), new Guid("b2e58af5-6fdd-44b9-bf35-215ff236f34f"), new Guid("9724d523-47b5-4df4-95cb-f606db134750") },
                    { new Guid("555ea69d-affd-4d71-81d2-349fc50bab02"), new Guid("1ba3d7dd-6cf5-4f51-adfb-55dc58edf0e2"), new Guid("c971c3dc-f19c-4ea6-8bc3-62534754fe05") },
                    { new Guid("97ab4afe-c603-46c4-9de7-1b3f4a6e3c86"), new Guid("1ba3d7dd-6cf5-4f51-adfb-55dc58edf0e2"), new Guid("43da4ee4-8455-4be1-8b14-8e22b4dcf7ad") },
                    { new Guid("733ec812-3269-4f5a-9135-430ca7e63bcd"), new Guid("6e42c851-377a-4122-846e-11ef7bc37baf"), new Guid("617ae6b4-3eef-4817-8e53-4093d1dfc007") },
                    { new Guid("24a5d93a-b9d6-4bc9-b7ec-a576ca32b905"), new Guid("1ba3d7dd-6cf5-4f51-adfb-55dc58edf0e2"), new Guid("ce95001f-d906-46ab-96da-1bf85adb376f") },
                    { new Guid("10b2a6d2-33e6-42f9-b3e8-6ffab049183d"), new Guid("64d54c94-ddb9-4a50-a1a8-6e09bf2c37f9"), new Guid("85cf4ab9-c3ca-4335-bc29-883e11b5872d") },
                    { new Guid("481998a3-9cde-4e99-9393-eeced6faa160"), new Guid("64d54c94-ddb9-4a50-a1a8-6e09bf2c37f9"), new Guid("9979b573-f97d-4115-aacb-7d63b8b7083a") },
                    { new Guid("17e66267-8b1f-4ba5-87e9-600bd14e3f90"), new Guid("64d54c94-ddb9-4a50-a1a8-6e09bf2c37f9"), new Guid("80cc8d4c-58f2-46c5-97dc-265cca89a22e") },
                    { new Guid("a17ff1c5-aafb-46f6-9e5a-cb065a3b3f23"), new Guid("64d54c94-ddb9-4a50-a1a8-6e09bf2c37f9"), new Guid("8bbb0218-edb1-4b88-b8fe-69e88e4bf5d5") },
                    { new Guid("8aa5c10b-7cb5-4958-99dd-a954bec722fe"), new Guid("64d54c94-ddb9-4a50-a1a8-6e09bf2c37f9"), new Guid("1e736495-2905-4f96-87c4-4f496dd2a654") },
                    { new Guid("355e777e-99ca-45bc-8d4a-a899eea8a536"), new Guid("6e42c851-377a-4122-846e-11ef7bc37baf"), new Guid("ea28c86c-be1b-4203-9313-265827d9c001") },
                    { new Guid("f8d9b3c5-39dc-48e3-9ac2-c3b727fe79ae"), new Guid("64d54c94-ddb9-4a50-a1a8-6e09bf2c37f9"), new Guid("6e300b8c-512a-47fb-ac90-d3dece789ffd") },
                    { new Guid("7aded8f4-3446-4aed-847a-939016790e21"), new Guid("62109b2a-e963-48f1-bd9c-7737e20b80a6"), new Guid("4d403e3b-9a0f-4a79-8d40-e02f42bd1723") },
                    { new Guid("7319ef65-e73a-4042-ba1f-60d8d6963498"), new Guid("3ec064a8-36c1-4c2c-b8cc-5bd88cbd90b9"), new Guid("66d55c9d-43d3-4ba5-91a2-7b4723f27448") },
                    { new Guid("0fcc3c69-cc59-450a-809c-95cca12cbbdf"), new Guid("3ec064a8-36c1-4c2c-b8cc-5bd88cbd90b9"), new Guid("7f82ccc1-afd8-411f-989e-f33462631afb") },
                    { new Guid("b5934e10-8c63-409a-8278-6274c853099f"), new Guid("162eca2d-6b53-4125-bd0c-545bf4a61df0"), new Guid("1e346037-e7ad-49a1-8755-ff3145f1a90a") },
                    { new Guid("e3ea656a-b3bb-4b7f-8623-da799a8091eb"), new Guid("162eca2d-6b53-4125-bd0c-545bf4a61df0"), new Guid("11237c54-eb94-4f52-b6b3-142f33a6651a") },
                    { new Guid("39a3065c-2b5c-439f-8bc1-1bc9c9874c92"), new Guid("162eca2d-6b53-4125-bd0c-545bf4a61df0"), new Guid("22774ffe-eedd-49c2-a322-53b389a1f82c") },
                    { new Guid("0d966438-574d-4be6-bf4e-f13f137a5ce5"), new Guid("240adc46-8dea-4543-aebc-bc3c2e748289"), new Guid("b88525ad-7d9a-470e-a23f-399cba5e70e9") },
                    { new Guid("5524b4c0-6509-4211-9384-4040b073b54b"), new Guid("240adc46-8dea-4543-aebc-bc3c2e748289"), new Guid("10772fb6-3831-411e-97f0-ecfe9ef23bac") },
                    { new Guid("fb94b7a4-6ff7-48d0-9a29-513b12ce3181"), new Guid("240adc46-8dea-4543-aebc-bc3c2e748289"), new Guid("461bf7ea-221e-4611-b130-1e070f3f2988") },
                    { new Guid("39a3065c-2b5c-439f-8bc1-1bc9c9874c92"), new Guid("34dff11d-0482-4ae2-85ad-cc3f7622cab0"), new Guid("c3af4320-2b0c-48a9-8864-0c08220374a9") },
                    { new Guid("688ffcd1-7411-4b6c-94ce-f9a9a612578e"), new Guid("240adc46-8dea-4543-aebc-bc3c2e748289"), new Guid("a866202d-5836-404e-81cf-8b14338a40bb") },
                    { new Guid("339f6fdf-fe4f-41d9-ab89-799ce4f56b7c"), new Guid("f66cfee5-5697-4ffa-bd92-12bd5412008d"), new Guid("26dc2c5b-1727-4909-a10e-93bb7419292f") },
                    { new Guid("e8097d1e-b593-40ea-971e-133def88a2e9"), new Guid("f66cfee5-5697-4ffa-bd92-12bd5412008d"), new Guid("355d5b1d-9bd1-467e-953b-725d33595a10") },
                    { new Guid("19bcdb8b-7bcc-46c8-a926-91ccad6dccf8"), new Guid("f66cfee5-5697-4ffa-bd92-12bd5412008d"), new Guid("16fd03ff-3711-43c1-8813-1dfdb41d0901") },
                    { new Guid("a2c84d3b-d38f-4a24-853c-b3830393aeb6"), new Guid("f66cfee5-5697-4ffa-bd92-12bd5412008d"), new Guid("f15ea808-b5c3-4e3b-97a1-0f66b9d3f5a3") },
                    { new Guid("b5896be7-664c-4b67-b181-e652ab02a227"), new Guid("f66cfee5-5697-4ffa-bd92-12bd5412008d"), new Guid("8d93ccf2-cf04-4595-ad23-4669bb69622b") },
                    { new Guid("14c18a5b-94d4-4f5e-9d96-fffd77696b89"), new Guid("e3d83a30-5707-4436-a79c-f8b6e83d5619"), new Guid("42ca2cd1-7e4f-42fb-80db-f427395f29a0") },
                    { new Guid("c4d05448-6e5b-4ead-92f5-003106e313ba"), new Guid("f66cfee5-5697-4ffa-bd92-12bd5412008d"), new Guid("356324ef-4f44-4187-a9c2-9d98af71e6b0") },
                    { new Guid("5bd3782f-92fe-407f-b9d0-2c9f0b71f37c"), new Guid("3ec064a8-36c1-4c2c-b8cc-5bd88cbd90b9"), new Guid("e8da5b48-039d-499d-a169-52cb16234998") },
                    { new Guid("e3ea656a-b3bb-4b7f-8623-da799a8091eb"), new Guid("34dff11d-0482-4ae2-85ad-cc3f7622cab0"), new Guid("6d9648f9-2480-4def-9632-368324cfd561") },
                    { new Guid("b5934e10-8c63-409a-8278-6274c853099f"), new Guid("8f5dc538-3929-404f-b3a5-faaef6a3f0db"), new Guid("5c21836c-32de-4282-a930-09b2a9ec9ba0") },
                    { new Guid("3707e6b6-a3d3-4bcd-9026-b3c37c1195bd"), new Guid("3ec064a8-36c1-4c2c-b8cc-5bd88cbd90b9"), new Guid("30fdbdf3-8e55-4c6f-a165-c58d060f4a3b") },
                    { new Guid("fc16c9f4-55d9-4952-bfae-00dcbbaaad19"), new Guid("a9c1dc56-43df-4356-891a-ae8226881378"), new Guid("3c8f372e-fc3a-4835-b28f-a7207a7679a2") },
                    { new Guid("1b82f2a8-8915-401d-bab9-1702aafbfa3a"), new Guid("a9c1dc56-43df-4356-891a-ae8226881378"), new Guid("11dbb4b1-9737-40e8-993e-11015cff01ce") },
                    { new Guid("8305e0e4-146f-4a1b-b1fb-a25519f7d3a5"), new Guid("a9c1dc56-43df-4356-891a-ae8226881378"), new Guid("78fe7db7-7894-4782-828e-3fd0e451b5fd") },
                    { new Guid("d323391f-88d6-46b1-8aea-0ba01e6bfe98"), new Guid("a9c1dc56-43df-4356-891a-ae8226881378"), new Guid("c304b3ab-ec69-4844-a19f-5e96e6ce0916") },
                    { new Guid("b5934e10-8c63-409a-8278-6274c853099f"), new Guid("a9c1dc56-43df-4356-891a-ae8226881378"), new Guid("d2898465-e1b9-4549-b844-b348f60b328e") },
                    { new Guid("b5934e10-8c63-409a-8278-6274c853099f"), new Guid("34dff11d-0482-4ae2-85ad-cc3f7622cab0"), new Guid("b60b0091-30de-419b-8097-678d681b3828") },
                    { new Guid("50b0f7a2-ea0d-4816-bb12-d47b528b94b0"), new Guid("748c128b-731a-43c2-845d-7c21464e2616"), new Guid("313c81e8-e715-4fb9-bd38-b21ddd4a6b59") },
                    { new Guid("e70201d4-59aa-40ef-9fb5-d24955d2ab76"), new Guid("748c128b-731a-43c2-845d-7c21464e2616"), new Guid("cdb77e0b-b6bb-409c-955a-d58073d32cbd") },
                    { new Guid("f8d9b3c5-39dc-48e3-9ac2-c3b727fe79ae"), new Guid("748c128b-731a-43c2-845d-7c21464e2616"), new Guid("75664f71-6145-4d1e-ad86-027b855891e1") },
                    { new Guid("39a3065c-2b5c-439f-8bc1-1bc9c9874c92"), new Guid("748c128b-731a-43c2-845d-7c21464e2616"), new Guid("5274ebcb-ca5d-43cb-915e-b45c5e3a9e96") },
                    { new Guid("0d966438-574d-4be6-bf4e-f13f137a5ce5"), new Guid("8f5dc538-3929-404f-b3a5-faaef6a3f0db"), new Guid("9a1290b5-d6e6-4961-835d-7a2fe82af788") },
                    { new Guid("5524b4c0-6509-4211-9384-4040b073b54b"), new Guid("8f5dc538-3929-404f-b3a5-faaef6a3f0db"), new Guid("1b8c4360-84e9-4ac0-8d99-5af0d503f7d7") },
                    { new Guid("e3ea656a-b3bb-4b7f-8623-da799a8091eb"), new Guid("8f5dc538-3929-404f-b3a5-faaef6a3f0db"), new Guid("79900bff-8252-448e-a2d4-18b0e2e955d6") },
                    { new Guid("e215b065-e265-41b6-87d3-e1f99a9c1671"), new Guid("748c128b-731a-43c2-845d-7c21464e2616"), new Guid("fe1fd0e4-3d0e-454f-bfa6-89f7f05ca1e2") },
                    { new Guid("4e475c0f-cbee-4fd3-822a-3c97171f95fe"), new Guid("62109b2a-e963-48f1-bd9c-7737e20b80a6"), new Guid("bfa73c09-d21d-49b7-88e6-319a9d18ea7a") },
                    { new Guid("63af4f57-d7e3-460d-b3c2-aee6b27408c5"), new Guid("62109b2a-e963-48f1-bd9c-7737e20b80a6"), new Guid("537f192a-4393-4f55-ab11-44e59cad4493") },
                    { new Guid("4c8f03c1-bc2a-4a24-b75d-b58d56a9d6cd"), new Guid("b25a1d3b-4d23-4154-b434-fc1ff1991421"), new Guid("32a26d42-365f-4085-b11e-9106a90973d5") },
                    { new Guid("4d7c68fc-af85-4ce1-8cc5-d2896a151b1b"), new Guid("10b4d9ce-65c1-4f6e-bfed-23d6c90801ab"), new Guid("87ca2582-0922-4415-8834-1ca113fd6e02") },
                    { new Guid("17c2e42e-648a-4ab2-89d5-c88e298e1728"), new Guid("d5c00bf4-e203-4456-bc36-749433303d49"), new Guid("0d0d5dd9-1c20-4224-860f-5ffedea2f964") },
                    { new Guid("210b4865-2e13-479a-a669-abba288e4603"), new Guid("d5c00bf4-e203-4456-bc36-749433303d49"), new Guid("8d5ecc98-c772-4990-aacf-b5a2da408e1b") },
                    { new Guid("8b4d1f4a-8fde-4fdd-a676-47d2fd02a18c"), new Guid("d5c00bf4-e203-4456-bc36-749433303d49"), new Guid("66525862-b295-4d9d-91cf-35dd09d0a270") },
                    { new Guid("4d7c68fc-af85-4ce1-8cc5-d2896a151b1b"), new Guid("d5c00bf4-e203-4456-bc36-749433303d49"), new Guid("0bf0f0d1-9f79-480a-80e6-a43be6aad5cb") },
                    { new Guid("fddcc624-2826-4bc4-8203-ffa388a83074"), new Guid("2a77fa7a-b9c5-400c-ad44-2e61e0f6fa90"), new Guid("2e2ef4bf-bf01-476f-bcd4-687a1af647d2") },
                    { new Guid("8b4d1f4a-8fde-4fdd-a676-47d2fd02a18c"), new Guid("10b4d9ce-65c1-4f6e-bfed-23d6c90801ab"), new Guid("1eba1fa3-cb88-42c5-acc2-2bb454ddecdf") },
                    { new Guid("20e2eb5e-a210-43f1-aa00-66b859a0de4a"), new Guid("2a77fa7a-b9c5-400c-ad44-2e61e0f6fa90"), new Guid("e6e4e3eb-477a-4089-907b-ab4555694def") },
                    { new Guid("af6aab50-75e9-4b99-91a5-10a6ffa50eb8"), new Guid("2a77fa7a-b9c5-400c-ad44-2e61e0f6fa90"), new Guid("3e688cbf-45c8-4ebc-b1b7-7eaf0513abc0") },
                    { new Guid("b6dfefd7-8b49-4558-ac21-3f496e732203"), new Guid("2a77fa7a-b9c5-400c-ad44-2e61e0f6fa90"), new Guid("55232af3-4ac8-4e7b-bb11-c8801726307b") },
                    { new Guid("e797ff74-eb01-405e-9ef0-e910bfd9c8e7"), new Guid("aa2504c2-0f5a-4517-bda8-adeb5c092061"), new Guid("7f1cd2d6-4e69-4200-b732-4107d80d1c2b") },
                    { new Guid("a840cf20-407b-419c-b1f3-9b3f65c19b43"), new Guid("aa2504c2-0f5a-4517-bda8-adeb5c092061"), new Guid("64c14e99-ee4f-4d4e-9478-df9690317179") },
                    { new Guid("d47920a6-c9f1-482a-b88a-63303c43a08c"), new Guid("b25a1d3b-4d23-4154-b434-fc1ff1991421"), new Guid("9b81be28-a0ca-4246-ac51-05a1ef4c51f2") },
                    { new Guid("64e4a04f-ec50-4ac4-a029-f2bed14d1c45"), new Guid("aa2504c2-0f5a-4517-bda8-adeb5c092061"), new Guid("f068a845-79ca-42ad-a9fd-0cc89634c120") },
                    { new Guid("b642df2f-896c-456a-a6c3-05d1d28538a9"), new Guid("2a77fa7a-b9c5-400c-ad44-2e61e0f6fa90"), new Guid("261dbb49-33f5-415e-8ada-6fe05a0b7b47") },
                    { new Guid("210b4865-2e13-479a-a669-abba288e4603"), new Guid("10b4d9ce-65c1-4f6e-bfed-23d6c90801ab"), new Guid("218bdaea-a6b9-460f-a302-5dfee2ee17f2") },
                    { new Guid("688ffcd1-7411-4b6c-94ce-f9a9a612578e"), new Guid("10b4d9ce-65c1-4f6e-bfed-23d6c90801ab"), new Guid("93c7806f-ca34-47d1-bd11-4c73590a681f") },
                    { new Guid("17c2e42e-648a-4ab2-89d5-c88e298e1728"), new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new Guid("01862dd9-2ec8-4c3c-8fe1-94504488a922") },
                    { new Guid("6b7d1039-3cd0-492d-8f8c-f44c4258433b"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("36f91e4d-547b-42d4-92bb-e4c306435fe1") },
                    { new Guid("b5b835bc-ac3e-4feb-aecd-7efbe905e506"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("aaa17ad6-0b9c-4bd0-aead-9be91d207b39") },
                    { new Guid("e16cf954-7f86-40d4-b53c-0025371b986e"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("c0bb3bb4-c31c-4dac-a825-9ff55fd78aba") },
                    { new Guid("57840dab-205c-44b3-afd2-c38c56e03378"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("60860527-8620-4897-8639-6cc116306a75") },
                    { new Guid("91db24af-ab97-44c9-90bd-5149cf4c4220"), new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new Guid("37d445ba-d392-460b-bf08-4a32bed63f66") },
                    { new Guid("6b7d1039-3cd0-492d-8f8c-f44c4258433b"), new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new Guid("b4b5ac0d-106b-413f-88cf-c57c3f2d93cb") },
                    { new Guid("04fbf285-0439-4e9d-b986-86d5386c83bb"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("5b111775-7320-4875-8ca5-d72aa9e6163d") },
                    { new Guid("04fbf285-0439-4e9d-b986-86d5386c83bb"), new Guid("81aeed67-9b3b-410b-baa6-706b47a5cc0e"), new Guid("64c0aa9e-47f8-43f5-bf45-fbf1e604616f") },
                    { new Guid("14c18a5b-94d4-4f5e-9d96-fffd77696b89"), new Guid("c5b310a8-5f6b-4fa4-ac36-c36734c5cabb"), new Guid("80eb5f49-79e7-48b7-8395-876dda0ca3b9") },
                    { new Guid("57c12229-5827-45c0-830c-2f4395f0232b"), new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new Guid("61876e77-6a1f-4e6f-8336-f8f2769a8b63") },
                    { new Guid("44a5d060-717e-4c83-988f-7f420f99db16"), new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new Guid("82a55c9f-eef3-49da-8262-e35f01bd3486") },
                    { new Guid("ba33b380-9dee-46b5-a35b-dcc7e12e6be4"), new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new Guid("f9169975-8026-44b6-9895-261d542164a9") },
                    { new Guid("da8282c2-3d62-4841-8e98-4e00940370bc"), new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new Guid("98233009-3fca-44b8-8206-2678d12bc7e7") },
                    { new Guid("f6cfdb5f-2cf6-497b-9232-c4c8bc55e744"), new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new Guid("f3a7e6d4-5fdd-4c9c-a456-b06a522d3d22") },
                    { new Guid("aff5c7f9-9c94-44ff-9331-b64b6c9d608d"), new Guid("d805e0dc-2ecc-44d0-8974-0171c3468df6"), new Guid("37562570-96e2-4c32-892e-54bc7af53097") },
                    { new Guid("7aded8f4-3446-4aed-847a-939016790e21"), new Guid("fdff5ec3-e510-48d7-b10c-bfeca06f152d"), new Guid("33882a34-2dda-46d1-a52b-a4bca6045ccb") },
                    { new Guid("263a8faf-e96a-43db-bd89-9934340c0759"), new Guid("fdff5ec3-e510-48d7-b10c-bfeca06f152d"), new Guid("61aa1940-c286-4cc8-a9e9-8b527437475d") },
                    { new Guid("da59d8f9-e03d-4458-8d90-ea0a9e5aea8a"), new Guid("aa2504c2-0f5a-4517-bda8-adeb5c092061"), new Guid("bb5cf5c5-20c1-40c2-b99a-aabac075f715") },
                    { new Guid("9ddcbde3-d1d9-40d6-9b84-83ab88baa962"), new Guid("72f09b3b-6e1c-483a-99f9-56dc9a72ff76"), new Guid("3a51b2cf-c98e-451f-a2d1-f13d0f5fb68d") },
                    { new Guid("487ad4fd-7f0f-46c6-8971-1dc54e070b61"), new Guid("11228834-5692-4149-a8ad-514430a106a1"), new Guid("7122b9fd-394c-4e25-98b7-c4c20f0cb17b") },
                    { new Guid("01269a45-82ad-41d9-b85d-ecd8bff454d8"), new Guid("fdff5ec3-e510-48d7-b10c-bfeca06f152d"), new Guid("d972839f-a207-4a5c-95c0-a8efdaa08c37") },
                    { new Guid("df1c7d32-311a-4924-8e38-018e70be9842"), new Guid("39bcf484-8eb9-4987-939b-2073bac0d7f4"), new Guid("6b17573a-a83e-4911-ab36-cf3940e806ab") },
                    { new Guid("da8282c2-3d62-4841-8e98-4e00940370bc"), new Guid("f25c8852-2558-4d4d-956b-bdee6a94a972"), new Guid("5e3f656b-c75c-4256-abec-19b3e5d46986") },
                    { new Guid("aff5c7f9-9c94-44ff-9331-b64b6c9d608d"), new Guid("f25c8852-2558-4d4d-956b-bdee6a94a972"), new Guid("41c2c298-0852-4035-976a-30c55fd5dda7") },
                    { new Guid("17c2e42e-648a-4ab2-89d5-c88e298e1728"), new Guid("f25c8852-2558-4d4d-956b-bdee6a94a972"), new Guid("5b749113-85d8-4525-bd33-fb0458246f52") },
                    { new Guid("1ae599b7-118b-4e43-ac58-aec6fd3cece5"), new Guid("11228834-5692-4149-a8ad-514430a106a1"), new Guid("2c09be2c-da1e-469c-b9d8-3b0c4ceddbe9") },
                    { new Guid("5ac3840a-1cef-4466-83fb-5bf8984dc94a"), new Guid("e8182736-f6a1-47e8-bd35-97142087e025"), new Guid("efe7473b-4d41-4113-96e1-a6bc93076e4f") },
                    { new Guid("b5a32da5-4376-4e13-bcf0-5b22d105c652"), new Guid("e8182736-f6a1-47e8-bd35-97142087e025"), new Guid("66dba2bb-5ce7-41a2-af2c-d1d199162ed5") },
                    { new Guid("e2cf3321-e586-4fbc-ad71-6d294468aadc"), new Guid("e8182736-f6a1-47e8-bd35-97142087e025"), new Guid("aa8f7997-c0ca-4f1a-aa24-63c1b91c2d3e") },
                    { new Guid("a3f6348b-9311-46a9-b986-f7d56e465791"), new Guid("b25a1d3b-4d23-4154-b434-fc1ff1991421"), new Guid("73e285ae-cf18-4b49-bb66-386afd39b80c") },
                    { new Guid("ec1895ee-5696-4225-bb04-011181fe1a7a"), new Guid("b25a1d3b-4d23-4154-b434-fc1ff1991421"), new Guid("d53f8d11-f2db-43b1-8631-d8e3cb3a26f2") },
                    { new Guid("7c26279c-047a-4ad6-9a7b-0291381b9dbc"), new Guid("b25a1d3b-4d23-4154-b434-fc1ff1991421"), new Guid("3184a4c7-e449-407f-9e0a-3f852c118c3a") },
                    { new Guid("1b95eaa2-8c1c-42d7-8963-9dff52138d58"), new Guid("b25a1d3b-4d23-4154-b434-fc1ff1991421"), new Guid("2cd0dcf2-b056-40f9-9515-8005e949fa5c") },
                    { new Guid("355e777e-99ca-45bc-8d4a-a899eea8a536"), new Guid("e8182736-f6a1-47e8-bd35-97142087e025"), new Guid("d42f43dd-7f96-4625-be9c-030f830635ae") },
                    { new Guid("b53d120b-c5f7-4234-beb1-6b3b5c34e544"), new Guid("45fb724c-d736-45f2-82c1-db6945a46677"), new Guid("5f1700fd-0e29-47ec-ada7-4fc33673662a") },
                    { new Guid("4e475c0f-cbee-4fd3-822a-3c97171f95fe"), new Guid("11228834-5692-4149-a8ad-514430a106a1"), new Guid("e15c505c-e645-4204-b061-86384a491e5d") },
                    { new Guid("2cd3eb2b-edd2-45ea-b77e-31bfdcd1fcaf"), new Guid("45fb724c-d736-45f2-82c1-db6945a46677"), new Guid("5a9fc489-f9d5-4d91-9fc8-a604873490c7") },
                    { new Guid("ad591242-9816-45ee-8178-847f8adab6e5"), new Guid("72f09b3b-6e1c-483a-99f9-56dc9a72ff76"), new Guid("748a1539-2c4a-4b0b-9cb9-32cd24f7e21b") },
                    { new Guid("9d01c5bf-7f74-4509-a335-f73632fe4408"), new Guid("72f09b3b-6e1c-483a-99f9-56dc9a72ff76"), new Guid("a47bedd2-2898-4fd1-8799-0801c4136974") },
                    { new Guid("9cf381f0-896a-4d43-a4fc-bdaf9dbe4a78"), new Guid("72f09b3b-6e1c-483a-99f9-56dc9a72ff76"), new Guid("5269bb2d-d87d-4dc7-81bd-340ff0345947") },
                    { new Guid("7074375a-0b21-42b5-bbc5-c6a035e259a4"), new Guid("45fb724c-d736-45f2-82c1-db6945a46677"), new Guid("22898553-1727-4612-b703-16c865368fa2") },
                    { new Guid("b486d799-d61a-40e3-bed1-fa6e283090ca"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("4cb4e6b9-5ced-4c56-aacb-8d13e5d2bb31") },
                    { new Guid("fb70406f-4ef7-435d-9986-a33f04d3e39c"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("df7052bc-8b61-4d8a-838d-4dd10535682b") },
                    { new Guid("e9f53078-24d3-4ae3-974a-33b93e76da09"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("0a746186-838d-41e3-b93d-832e1ae3ae30") },
                    { new Guid("339f6fdf-fe4f-41d9-ab89-799ce4f56b7c"), new Guid("72f09b3b-6e1c-483a-99f9-56dc9a72ff76"), new Guid("e0713a97-d318-4f63-85f3-a09457221ddd") },
                    { new Guid("cff58552-b392-4eab-a7aa-928e51d8b14f"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("3be4adb9-8cac-470b-ba16-6e2e1b5fb23e") },
                    { new Guid("1f7db9e6-d640-49bd-8e7d-aefab5550d5a"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("fc2f3792-8b6f-48aa-b338-f66bd2d3674e") },
                    { new Guid("4fe8df6a-7364-468e-940d-e70dc8f94150"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("90341a41-066c-4c43-a9cc-3f48cc9814b3") },
                    { new Guid("bbcdd396-f115-4204-8d28-1ac338ef6c86"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("00a53d01-7222-4350-967b-468007411acd") },
                    { new Guid("22c8df61-db25-4b81-9c82-9adc3d106ca9"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("4a97f4a1-7827-4b72-bcd5-0dfa9680a582") },
                    { new Guid("e7a571b7-75f6-4fc3-9692-95be76e546c6"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("6e05152f-40be-410d-8491-fc5a797de517") },
                    { new Guid("14736895-fb4d-40a5-be91-b0458c344d97"), new Guid("269b9c3d-fdf8-42b9-ba79-50a08a59a939"), new Guid("3bc12c73-f30b-4054-b710-283aa1e087c6") }
                });

            migrationBuilder.InsertData(
                table: "QuestionKeyFact",
                columns: new[] { "QuestionId", "KeyFactId", "Id" },
                values: new object[,]
                {
                    { new Guid("e59feaf8-9813-4b77-b34a-2fc379e5e59a"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("e6a6ec0d-1b94-44da-be39-56f3e37a52dd") },
                    { new Guid("3c5f06e0-e33f-40fb-a43e-4224addd1671"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("5395c249-02c9-4953-af0e-ebb50d1f7f42") },
                    { new Guid("4b72b1b6-f14b-43a0-8cee-b3824114eb35"), new Guid("4c338983-e027-4b32-9b37-19f9aa088174"), new Guid("9a1c2469-5679-427c-bec3-7381e5168a0f") },
                    { new Guid("b6fd88b0-0f5e-4b4b-ad4c-c45410d0379b"), new Guid("a414a9d7-836d-451e-8b11-950ff2d8f8ba"), new Guid("b381ecdb-a5e8-40d5-971b-e5b9a7708b5a") },
                    { new Guid("68a5f73d-89d3-4eae-a229-c34670362963"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("6e2cff77-2519-4130-abdd-d4f96668df2b") },
                    { new Guid("1e0db6a4-c93e-41a9-97cf-8cb0b47e24db"), new Guid("d86f8287-40e6-4343-819f-adeb0104546c"), new Guid("9e37dca9-8c46-4597-a910-fbacb2642428") },
                    { new Guid("4d1db6bb-a66f-4711-9225-4cbeeff08249"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("f71a58fc-af1d-4145-a208-a46ecc976fa5") },
                    { new Guid("c1d6ceb7-313d-42a3-91d5-780aeb12dfca"), new Guid("b8776aa6-31b4-4125-8bfe-0a4e07d45d1b"), new Guid("6c8a9e19-f515-4b3a-9a10-dcadf4cb6ae2") }
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
