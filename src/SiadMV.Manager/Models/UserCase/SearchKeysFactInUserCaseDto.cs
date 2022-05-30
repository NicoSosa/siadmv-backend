using SiadMV.Manager.SeedWork;


namespace SiadMV.Manager.Models.UserCase
{
    public class SearchKeysFactInUserCaseDto : IManagerContract
    {
        public string Description { get; set; }
        public string[] KeysFact { get; set; }
    }
}
