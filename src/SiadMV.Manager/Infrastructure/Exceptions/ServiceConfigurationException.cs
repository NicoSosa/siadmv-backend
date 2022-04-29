using SiadMV.ServiceBase.Infrastructure.Exceptions;
using System;
using System.Runtime.Serialization;

namespace SiadMV.Manager.Infrastructure.Exceptions
{
    [Serializable]
    public class ServiceConfigurationException : BaseException
    {
        protected ServiceConfigurationException(SerializationInfo info, StreamingContext context)
            : base(info, context)
        {
        }

        /// <summary>
        /// Exception for not found or wrong configuration parameter
        /// </summary>
        /// <param name="message">Message to show in response</param>
        /// <param name="details">Details to show in response</param>
        public ServiceConfigurationException(string message, string details)
            : base(message, details)
        {
        }
    }
}
