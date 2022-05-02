using SiadMV.Manager.SeedWork;

namespace SiadMV.Manager.Models.UserCase
{
    public class CreateUserCaseDto : IManagerContract
    {
        public string Description { get; set; }
    }
}
