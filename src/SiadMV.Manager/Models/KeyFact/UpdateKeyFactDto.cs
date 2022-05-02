using SiadMV.Manager.SeedWork;
using System;

namespace SiadMV.Manager.Models.KeyFact
{
    public class UpdateKeyFactDto : IManagerContract
    {
        public Guid KeyFactId { get; set; }
        public string Description { get; set; }
    }
}
