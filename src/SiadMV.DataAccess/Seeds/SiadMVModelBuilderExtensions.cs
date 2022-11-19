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
                    Id = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.ContainerizedEnvironment.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.LegacyApps.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.LegacyApps.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.LegacyServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.LegacyServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.ProxyCaching.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.ProxyCaching.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.LogAggregator.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.LogAggregator.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.UseExternalMicroservices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.UseExternalMicroservices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.MicroserviceArchitecture.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.MicroserviceArchitecture.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.NetworkingServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.MonitoringServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.MonitoringServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.MultiFrameworksServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.MultiFrameworksServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.MultiLenguajesServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.MultiLenguajesServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.MultiHandleContainer.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.MultiHandleContainer.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.CrossCuttingConcern.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.CrossCuttingConcern.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.ReduceNetworkOverflow.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.ReduceNetworkOverflow.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.MultiServicesHost.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.MultiServicesHost.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.AutenticationServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.AutenticationServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.AuthorizationServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.AuthorizationServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.ClusterSupport.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.ClusterSupport.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.SupportServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.SupportServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.HighSecurity.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.HighSecurity.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.CloudSupport.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.CloudSupport.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.CriticalLatency.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.CriticalLatency.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.SincronousResponses.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.SincronousResponses.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.MinimumArquitecture.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.MinimumArquitecture.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.StandaloneServicesScalability.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.StandaloneServicesScalability.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.IndividualConnectivityFeatures.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.IndividualConnectivityFeatures.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.SingleFrameworkServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.SingleFrameworkServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.SingleLanguageServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.SingleLanguageServices.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.DeeperIntegration.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.DeeperIntegration.Description
                },
                new KeyFact
                {
                    Id = Guid.Parse(KeyFactSeedConstants.ComplexConectivityIntegration.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = KeyFactSeedConstants.ComplexConectivityIntegration.Description
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
                    Id = Guid.Parse(CommonExpressionSeedConstants.ExternalAPI.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ExternalAPI.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ThirdPartyAPI.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ThirdPartyAPI.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LegacySystem.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LegacySystem.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.HttpRequest.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.HttpRequest.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ContainerizedEnvironment.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ContainerizedEnvironment.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Container.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Container.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ContainersEs.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ContainersEs.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Containers.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Containers.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.VirtualizedSO.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.VirtualizedSO.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Kubernetes.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Kubernetes.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Docker.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Docker.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LegacyApp.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LegacyApp.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LegacySystem2.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LegacySystem2.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LegacyApp2.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LegacyApp2.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ProxyCache.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ProxyCache.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ProxiesCache.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ProxiesCache.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ThrottleBandwidth.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ThrottleBandwidth.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.SaveCache.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.SaveCache.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ServeStaticContent.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ServeStaticContent.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.RecordAgregator.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.RecordAgregator.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LogAggreation.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LogAggreation.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LogsCentralizing.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LogsCentralizing.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LogsPersistence.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LogsPersistence.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.CentralizedLogs.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.CentralizedLogs.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ExternalMicroservices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ExternalMicroservices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ThirdPartyMicroservices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ThirdPartyMicroservices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.DistributedApplication.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.DistributedApplication.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Microservices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Microservices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ScalableArchitecture.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ScalableArchitecture.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.FlexibleArchitecture.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.FlexibleArchitecture.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.DistributedArchitecture.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.DistributedArchitecture.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Api.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Api.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NetworkServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NetworkServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NetworkInfrastructure.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NetworkInfrastructure.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NetworkConectivity.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NetworkConectivity.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NetworkSharedResources.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NetworkSharedResources.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Lan.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Lan.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Wan.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Wan.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LocalAreaNetwork.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LocalAreaNetwork.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Dhcp.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Dhcp.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Dns.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Dns.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Ftp.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Ftp.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ControlServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ControlServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MonitoringServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MonitoringServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MaaS.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MaaS.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MultiFrameworksServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MultiFrameworksServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.UseMultiFrameworks.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.UseMultiFrameworks.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.DescentralizedMicroservices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.DescentralizedMicroservices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.UseMultiLanguages.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.UseMultiLanguages.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ReduceNetworkOverflow.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ReduceNetworkOverflow.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NetworkOverflow.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NetworkOverflow.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NetworkBufferOverflow.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NetworkBufferOverflow.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.OverflowByRequests.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.OverflowByRequests.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Overflow.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Overflow.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.SeveralContinuosRequests.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.SeveralContinuosRequests.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.CrossCuttingConcern.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.CrossCuttingConcern.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.IntegrationMicroservice.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.IntegrationMicroservice.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.IntegrationService.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.IntegrationService.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.CrossCuttingMicroservice.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.CrossCuttingMicroservice.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.DistributedBackend.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.DistributedBackend.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Login.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Login.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.UserLogged.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.UserLogged.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.UserPermissions.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.UserPermissions.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.BeLogged.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.BeLogged.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.UserRoles.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.UserRoles.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.BusinessLogic.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.BusinessLogic.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.InternalProcessing.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.InternalProcessing.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Payment.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Payment.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Pay.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Pay.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.HighSecurity.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.HighSecurity.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.SensitiveData.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.SensitiveData.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.DataEncript.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.DataEncript.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.CloudServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.CloudServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Aws.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Aws.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.WebServicesEs.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.WebServicesEs.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.WebServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.WebServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.CloudFunctions.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.CloudFunctions.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.CloudFunctionsES.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.CloudFunctionsES.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.OwnedServers.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.OwnedServers.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Cluster.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Cluster.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ClusterServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ClusterServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.RemoteServers.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.RemoteServers.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ExternalServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ExternalServices.Description
                },
                                new CommonExpression
                                {
                                    Id = Guid.Parse(CommonExpressionSeedConstants.QuickResponse.Id),
                                    CreationDate = DateTime.Now,
                                    LastUpdateDate = null,
                                    Description = CommonExpressionSeedConstants.QuickResponse.Description
                                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ResponseVelocity.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ResponseVelocity.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.FaultTolerance.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.FaultTolerance.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.HandleOverflow.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.HandleOverflow.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.SynchronousLogic.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.SynchronousLogic.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.SynchronousDependency.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.SynchronousDependency.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NotAsynchronous.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NotAsynchronous.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.RealTimeProcessing.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.RealTimeProcessing.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.RealTimeResponses.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.RealTimeResponses.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LowerCostImplementation.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LowerCostImplementation.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.LowBudget.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.LowBudget.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.SmallArchitecture.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.SmallArchitecture.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.WithoutMicroservices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.WithoutMicroservices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MonolithicSystem.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MonolithicSystem.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.OwnMicroservices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.OwnMicroservices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.ScalingServices.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.ScalingServices.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.InternalLogic.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.InternalLogic.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.CentralizedLogic.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.CentralizedLogic.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.IndividualConectivity.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.IndividualConectivity.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.OnlyOneConection.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.OnlyOneConection.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.Monolith.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.Monolith.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.OnlyOneLanguage.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.OnlyOneLanguage.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MultipleFrameworks.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MultipleFrameworks.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MultipleLanguages.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MultipleLanguages.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MultipleFrameworks2.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MultipleFrameworks2.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.MultipleLanguages2.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.MultipleLanguages2.Description
                },
                new CommonExpression
                {
                    Id = Guid.Parse(CommonExpressionSeedConstants.NotMonolithic.Id),
                    CreationDate = DateTime.Now,
                    LastUpdateDate = null,
                    Description = CommonExpressionSeedConstants.NotMonolithic.Description
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
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ContainerizedEnvironment.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Container.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ContainersEs.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Containers.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.VirtualizedSO.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Kubernetes.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ContainerizedEnvironment.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Docker.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyApps.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacySystem.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyApps.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacyApp.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyApps.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacySystem2.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyApps.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacyApp2.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Docker.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacyApp.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacySystem2.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LegacyServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacyApp2.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ProxyCaching.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ProxyCache.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ProxyCaching.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ProxiesCache.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ProxyCaching.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ThrottleBandwidth.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ProxyCaching.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.SaveCache.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ProxyCaching.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ServeStaticContent.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LogAggregator.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.RecordAgregator.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LogAggregator.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LogAggreation.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LogAggregator.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LogsCentralizing.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.LogAggregator.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LogsPersistence.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.UseExternalMicroservices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ExternalMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.UseExternalMicroservices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ThirdPartyMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.UseExternalMicroservices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.DistributedApplication.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MicroserviceArchitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Microservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MicroserviceArchitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ScalableArchitecture.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MicroserviceArchitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.FlexibleArchitecture.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MicroserviceArchitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.DistributedArchitecture.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MicroserviceArchitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Api.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NetworkServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NetworkInfrastructure.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NetworkConectivity.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NetworkSharedResources.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Lan.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Wan.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LocalAreaNetwork.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Dhcp.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Dns.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.NetworkingServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Ftp.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MonitoringServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ControlServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MonitoringServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MonitoringServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MonitoringServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MaaS.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiFrameworksServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MultiFrameworksServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiFrameworksServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.UseMultiFrameworks.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiFrameworksServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.DescentralizedMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiLenguajesServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.UseMultiLanguages.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiHandleContainer.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Containers.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiHandleContainer.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Kubernetes.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiHandleContainer.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Docker.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ReduceNetworkOverflow.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ReduceNetworkOverflow.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ReduceNetworkOverflow.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NetworkOverflow.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ReduceNetworkOverflow.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NetworkBufferOverflow.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ReduceNetworkOverflow.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.OverflowByRequests.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ReduceNetworkOverflow.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Overflow.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ReduceNetworkOverflow.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.SeveralContinuosRequests.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CrossCuttingConcern.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CrossCuttingConcern.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CrossCuttingConcern.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.IntegrationMicroservice.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CrossCuttingConcern.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.IntegrationService.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CrossCuttingConcern.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CrossCuttingMicroservice.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiServicesHost.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.DescentralizedMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiServicesHost.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ExternalMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiServicesHost.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ThirdPartyMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MultiServicesHost.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.DistributedBackend.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.AutenticationServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Login.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.AutenticationServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.UserLogged.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.AutenticationServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.UserPermissions.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.AuthorizationServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.BeLogged.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.AuthorizationServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.UserRoles.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.AuthorizationServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.UserPermissions.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SupportServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.IntegrationMicroservice.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SupportServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.DescentralizedMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SupportServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.BusinessLogic.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SupportServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.InternalProcessing.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.HighSecurity.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Payment.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.HighSecurity.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Pay.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.HighSecurity.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.HighSecurity.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.HighSecurity.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.SensitiveData.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.HighSecurity.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.DataEncript.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CloudSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CloudServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CloudSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Aws.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CloudSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.WebServicesEs.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CloudSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.WebServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CloudSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CloudFunctions.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CloudSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CloudFunctionsES.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ClusterSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.OwnedServers.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ClusterSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Cluster.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ClusterSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ClusterServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ClusterSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.InternalProcessing.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ClusterSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.RemoteServers.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ClusterSupport.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ExternalServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CriticalLatency.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.QuickResponse.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CriticalLatency.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ResponseVelocity.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CriticalLatency.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.FaultTolerance.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.CriticalLatency.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.HandleOverflow.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SincronousResponses.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.SynchronousLogic.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SincronousResponses.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.SynchronousDependency.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SincronousResponses.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NotAsynchronous.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SincronousResponses.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.RealTimeProcessing.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SincronousResponses.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.RealTimeResponses.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MinimumArquitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LowerCostImplementation.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MinimumArquitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LowBudget.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MinimumArquitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.SmallArchitecture.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MinimumArquitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.WithoutMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.MinimumArquitecture.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MonolithicSystem.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.StandaloneServicesScalability.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.OwnMicroservices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.StandaloneServicesScalability.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.ScalingServices.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.StandaloneServicesScalability.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.InternalLogic.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.StandaloneServicesScalability.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.OwnedServers.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.StandaloneServicesScalability.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CentralizedLogic.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.IndividualConnectivityFeatures.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.IndividualConectivity.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.IndividualConnectivityFeatures.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.OnlyOneConection.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.IndividualConnectivityFeatures.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Monolith.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.IndividualConnectivityFeatures.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MonolithicSystem.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SingleFrameworkServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MonolithicSystem.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SingleFrameworkServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Monolith.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SingleFrameworkServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CentralizedLogic.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SingleLanguageServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MonolithicSystem.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SingleLanguageServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Monolith.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.SingleLanguageServices.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.CentralizedLogic.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.DeeperIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.IndividualConectivity.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.DeeperIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.OnlyOneConection.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.DeeperIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.OnlyOneLanguage.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.DeeperIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.LegacySystem.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ComplexConectivityIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.NotMonolithic.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ComplexConectivityIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.Api.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ComplexConectivityIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MultipleFrameworks.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ComplexConectivityIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MultipleLanguages.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ComplexConectivityIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MultipleFrameworks2.Id)
                },
                new CommonExpressionKeyFact
                {
                    Id = Guid.NewGuid(),
                    KeyFactId = Guid.Parse(KeyFactSeedConstants.ComplexConectivityIntegration.Id),
                    CommonExpressionId = Guid.Parse(CommonExpressionSeedConstants.MultipleLanguages2.Id)
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
