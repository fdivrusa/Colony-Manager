using ColonyManager.Global;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace ColonyManager.Core.Services
{
    public class BaseService : IDisposable
    {
        private static readonly object _locker = new object();
        private static volatile HttpClient _httpClient;
        private readonly AppSettings _appSettings;

        public BaseService(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
        }

        protected HttpClient HttpClient
        {
            get
            {
                if(_httpClient == null)
                {
                    lock (_locker)
                    {
                        if(_httpClient == null)
                        {
                            _httpClient = GenerateHttpClient();
                        }
                    }
                }
                return _httpClient;
            }
        }

        private HttpClient GenerateHttpClient()
        {
            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(_appSettings.ColonyManagerApiUrl)
            };
            httpClient.DefaultRequestHeaders.Add("User-Agent", "ColonyManager.Provider");
            return httpClient;
        }


        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (_httpClient == null)
                {
                    return;
                }
                _httpClient.Dispose();
            }
        }
    }
}
