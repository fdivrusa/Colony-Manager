using ColonyManager.Core.Models.Responses;
using ColonyManager.Core.Services.Interfaces;
using ColonyManager.Global;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace ColonyManager.Core.Services
{
    public class PeopleService : BaseService, IPeopleService
    {
        public PeopleService(IOptions<AppSettings> appSettings) : base(appSettings)
        {

        }

        public async Task<GetPeoplesResponse> GetPeoplesList()
        {
            GetPeoplesResponse getPeoplesResponse = new GetPeoplesResponse();
            try
            {
                var response = await HttpClient.GetAsync("peoples");
                getPeoplesResponse.Peoples = JsonConvert.DeserializeObject<IEnumerable<PeopleDto>>(await response.Content.ReadAsStringAsync());
                getPeoplesResponse.Success = response.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                getPeoplesResponse.Success = false;
                getPeoplesResponse.ErrorMessage = ex.Message;
            }
            return getPeoplesResponse;
        }
    }
}
