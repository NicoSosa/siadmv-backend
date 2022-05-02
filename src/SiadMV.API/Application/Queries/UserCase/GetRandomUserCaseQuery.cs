using SiadMV.API.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.UserCase
{
    public class GetRandomUserCaseQuery : QueryBase<UserCaseViewModel>
    {
    }
}
