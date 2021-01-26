using ColonyManager.Global;
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

        protected static HttpClient HttpClient
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

        private static HttpClient GenerateHttpClient()
        {
            HttpClient httpClient = new HttpClient
            {
                BaseAddress = new Uri(LocalSettings.ColonyManagerApiUrl)
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
                if (_httpClient != null)
                {
                    _httpClient.Dispose();
                }

                _httpClient = null;
            }
        }
    }
}
