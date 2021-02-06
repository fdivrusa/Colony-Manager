using ColonyManager.Core.Models;
using ColonyManager.Provider.Responses;
using System.Threading.Tasks;

namespace ColonyManager.Core.Services.Interfaces
{
    public interface IAccountService
    {
        /// <summary>
        /// Method to authenticate the user in the application
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        Task<AuthenticationResponse> AuthenticateAsync(LoginRequest request);
    }
}
