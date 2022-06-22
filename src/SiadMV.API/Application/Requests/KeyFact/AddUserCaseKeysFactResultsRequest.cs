using MediatR;
using System.Collections.Generic;

namespace SiadMV.API.Application.Requests.KeyFact
{
    public class AddUserCaseKeysFactResultsRequest : IRequest
    {
        public IList<dynamic> NewCommonExpressions { get; set; }
        public IList<dynamic> NewKeysFact { get; set; }
        public IList<dynamic> ModifiedKeysFact { get; set; }
        public IList<dynamic> KeysFact { get; set; }
    }
}
