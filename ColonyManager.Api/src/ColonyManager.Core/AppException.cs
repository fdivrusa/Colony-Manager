using System;
using System.Globalization;
using System.Runtime.Serialization;

namespace ColonyManager.Core
{

    [Serializable]
    public class AppException : Exception
    {
        public AppException() : base()
        {

        }

        public AppException(string message) : base(message)
        {

        }

        public AppException(string message, params object[] args) : base(string.Format(CultureInfo.CurrentCulture, message, args))
        {

        }

        public AppException(SerializationInfo serializationInfo, StreamingContext streamingContext) : base(serializationInfo, streamingContext)
        {

        }
    }
}
