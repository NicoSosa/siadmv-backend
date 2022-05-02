using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.UserCase
{
    public class UpdateUserCaseDto : IManagerContract
    {
        public Guid UserCaseId { get; set; }
        public string Description { get; set; }
    }
}
