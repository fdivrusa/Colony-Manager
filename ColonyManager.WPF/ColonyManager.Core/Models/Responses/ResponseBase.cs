using System;
using System.Collections.Generic;
using System.Text;

namespace ColonyManager.Provider.Responses
{
    public class ResponseBase
    {
        public bool Success { get; set; }

        public string Message { get; set; }
    }
}
