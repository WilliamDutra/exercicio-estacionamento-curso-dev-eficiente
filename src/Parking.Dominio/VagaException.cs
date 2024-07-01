using System;
using System.Runtime.Serialization;

namespace Parking.Dominio
{
    public class VagaException : Exception
    {
        public VagaException()
        {

        }

        public VagaException(string message) : base(message)
        {

        }

        public VagaException(string message, Exception innerException) : base(message, innerException)
        {

        }

        protected VagaException(SerializationInfo info, StreamingContext context) : base(info, context)
        {

        }
    }
}
