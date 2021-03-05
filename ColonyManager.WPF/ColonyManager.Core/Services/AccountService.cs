using ColonyManager.Core.Helpers;
using ColonyManager.Core.Models;
using ColonyManager.Core.Services.Interfaces;
using ColonyManager.Global;
using ColonyManager.Provider.Responses;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ColonyManager.Core.Services
{
    public class AccountService : BaseService, IAccountService
    {

        public AccountService(IOptions<AppSettings> appSettings) : base(appSettings)
        {
        }

        public async Task<AuthenticationResponse> AuthenticateAsync(LoginRequest request)
        {
            HttpResponseMessage httpResponseMessage = new HttpResponseMessage();
            AuthenticationResponse authenticationResponse = null;
            try
            {
                await SecurityHelper.DecryptSecureString(request.SecurePassword, async (password) =>
                {
                    request.Password = password;
                    string json = JsonConvert.SerializeObject(request);
                    var jsonRequest = new StringContent(json, Encoding.UTF8, "application/json");
                    httpResponseMessage = await HttpClient.PostAsync("accounts/authenticate", jsonRequest);
                });

                authenticationResponse = JsonConvert.DeserializeObject<AuthenticationResponse>(await httpResponseMessage.Content.ReadAsStringAsync());
                authenticationResponse.Success = httpResponseMessage.IsSuccessStatusCode;
            }
            catch (Exception ex)
            {
                authenticationResponse.Success = false;
                authenticationResponse.ErrorMessage = ex.Message;
            }
            return authenticationResponse;
        }
    }
}
