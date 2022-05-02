using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.UserCase
{
    public class UserCaseDto : IManagerResponse
    {
        public Guid UserCaseId { get; set; }
        public string Description { get; set; }
    }
}
