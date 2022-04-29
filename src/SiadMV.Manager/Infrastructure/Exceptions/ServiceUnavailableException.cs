using SiadMV.ServiceBase.Infrastructure.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SiadMV.Manager.Infrastructure.Exceptions
{
    [Serializable]
    public class ServiceUnavailableException : BaseException
    {
        protected ServiceUnavailableException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Exception for not found issues
        /// </summary>
        /// <param name="message">Message to show in response</param>
        /// <param name="details">Details to show in response</param>
        public ServiceUnavailableException(string message, string details)
            : base(message, details)
        {
        }
    }
}
