using System;

namespace Exercicio145.Exceptions
{
    class AppException : ApplicationException
    {

        public AppException(string message) : base(message)
        {
        }
    }
}
