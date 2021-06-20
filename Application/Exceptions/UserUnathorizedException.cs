using System;

namespace Application.Exceptions
{
    public class UserUnathorizedException : Exception
    {
        /// <summary>
        /// Исключение для 401
        /// </summary>
        /// <param name="message"> Message исключения </param>
        public UserUnathorizedException(string message) : base(message)
        {
            Detail = message;
        }

        /// <summary>
        /// Исключение для 401
        /// </summary>
        /// <param name="message"> Message исключения </param>
        /// <param name="detail"> Описание ошибки для вывода на фронте </param>
        public UserUnathorizedException(string message, string detail) : base(message)
        {
            Detail = detail;
        }

        /// <summary>
        /// Детали ошибки для вывода на фронте
        /// </summary>
        public string Detail { get; }
    }
}
