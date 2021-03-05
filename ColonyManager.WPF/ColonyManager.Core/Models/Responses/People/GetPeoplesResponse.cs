using ColonyManager.Provider.Responses;
using System.Collections.Generic;

namespace ColonyManager.Core.Models.Responses
{
    public class GetPeoplesResponse : ResponseBase
    {

        public GetPeoplesResponse()
        {
            Peoples = new List<PeopleDto>();
        }

        public IEnumerable<PeopleDto> Peoples { get; set; }
    }

}
