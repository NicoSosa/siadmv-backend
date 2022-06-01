using Microsoft.EntityFrameworkCore;
using SiadMV.DataAccess.Models.SiadMVDb;
using SiadMV.DataAccess.Seeds.Constants;
using System;

namespace SiadMV.DataAccess.Seeds
{
    public static class SiadMVModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            // USER CASE
            modelBuilder.Entity<UserCase>().HasData(
                new UserCase
                {
                    Id = Guid.Parse(UserCaseConst.First.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = UserCaseConst.First.Description
                },
                new UserCase
                {
                    Id = Guid.Parse(UserCaseConst.Second.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = UserCaseConst.Second.Description
                },
                new UserCase
                {
                    Id = Guid.Parse(UserCaseConst.Third.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = UserCaseConst.Third.Description
                });


            // KEY FACT
            modelBuilder.Entity<KeyFact>().HasData(
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.Autenticacion.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.Autenticacion.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.Sql.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.Sql.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.Autorizacion.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.Autorizacion.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.Procesamiento.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.Procesamiento.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.Ram.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.Ram.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.DotNet.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.DotNet.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.Framework.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.Framework.Description
                });

            // QUESTION
            modelBuilder.Entity<Question>().HasData(
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Autenticacion1.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Autenticacion1.Description
                },
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Autenticacion2.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Autenticacion2.Description
                },
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Autorizacion.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Autorizacion.Description
                },
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Sql1.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Sql1.Description
                },
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Sql2.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Sql2.Description
                },
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Procesamiento1.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Procesamiento1.Description
                },
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Procesamiento2.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Procesamiento2.Description
                },
                new Question
                {
                    Id = Guid.Parse(QuestionSeedConstants.Procesamiento3.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = QuestionSeedConstants.Procesamiento3.Description
                });

            // COMMON EXPRESSION
            modelBuilder.Entity<CommonExpression>().HasData(
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.BaseDeDatos.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.BaseDeDatos.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Mysql.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Mysql.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Usuario.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Usuario.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Autenticacion.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Autenticacion.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Almacenamiento.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Almacenamiento.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Rapido.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Rapido.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Backend.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Backend.Description
                });
            
            // RELATIONS QUESTION - KEYFACT
            modelBuilder.Entity<QuestionKeyFact>().HasData(
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Autenticacion.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Autenticacion1.Id)
                },
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Autenticacion.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Autenticacion2.Id)
                },
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Autorizacion.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Autorizacion.Id)
                },
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Sql.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Sql1.Id)
                },
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Sql.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Sql2.Id)
                },
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Procesamiento.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Procesamiento1.Id)
                },
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Procesamiento.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Procesamiento2.Id)
                },
                new QuestionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Procesamiento.Id),
                    QuestionId = Guid.Parse(QuestionSeedConstants.Procesamiento3.Id)
                });

            // RELATIONS COMMON EXPRESSION - KEYFACT
            modelBuilder.Entity<CommonExpressionKeyFact>().HasData(
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Autenticacion.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Autenticacion.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Autenticacion.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Usuario.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Sql.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.BaseDeDatos.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Sql.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Mysql.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Sql.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Almacenamiento.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Autorizacion.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Autenticacion.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Autorizacion.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Usuario.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Procesamiento.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Rapido.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Ram.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Rapido.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.DotNet.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Backend.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.Framework.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Backend.Id)
                });
        }
    }
}
