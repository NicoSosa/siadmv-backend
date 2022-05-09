using SiadMV.DataAccess.Models.SiadMVDb;
using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace SiadMV.DataAccess.Migrations.Seed
{
    public static class UsersCasesInitializer
    {
        // User Cases Id
        private static readonly Guid FirstUserCaseId = Guid.Parse("6B29127B-E08B-4BCB-8792-64C903A80CC3");
        private static readonly Guid SecondUserCaseId = Guid.Parse("0AF0FED0-8FB6-497E-8996-D95F11181B5D");
        private static readonly Guid ThirdUserCaseId = Guid.Parse("F6DA63CA-630D-438F-863E-7F32C9A6ECAA");

        // User Cases Descriptions
        private static readonly string FirstDescription = "hola mundo";
        private static readonly string SecondDescription = "Chau mundo";
        private static readonly string ThirdDescription = "Mira de quien te burlaste";


        public static void SeedInitial(MigrationBuilder migrationBuilder)
        {
            // Add UserCases
            migrationBuilder.InsertData(
                nameof(UserCase),
                new[]
                {
                    nameof(UserCase.Id),
                    nameof(UserCase.CreationDate),
                    nameof(UserCase.LastUpdateDate),
                    nameof(UserCase.Description)
                },
                new object[,]
                {
                    { FirstUserCaseId, DateTime.Now, null, FirstDescription },
                    { SecondUserCaseId, DateTime.Now, null, SecondDescription },
                    { ThirdUserCaseId, DateTime.Now, null, ThirdDescription },
                });

        }
        public static void RollbackInitial(MigrationBuilder migrationBuilder)
        {
            // Delete User Cases
            migrationBuilder.DeleteData(
                nameof(UserCase),
                nameof(UserCase.Id),
                new object[]
                {
                    FirstUserCaseId,
                    SecondUserCaseId,
                    ThirdUserCaseId
                });
        }

    }
}
