using SiadMV.API.Models.UserCase;
using SiadMV.ServiceBase.CQRS.Queries;
using System;

namespace SiadMV.API.Application.Queries.UserCase
{
    public class GetUserCaseByIdQuery : QueryBase<UserCaseViewModel>
    {
        public Guid UserCaseId { get; }

        public GetUserCaseByIdQuery(Guid userCaseId)
        {
            UserCaseId = userCaseId;
        }
    } 
}
