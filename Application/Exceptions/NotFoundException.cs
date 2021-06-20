using System;

namespace Application.Exceptions
{
    public class NotFoundException : Exception
    {
        /// <summary>
        /// Исключение для 404
        /// </summary>
        /// <param name="name"> Наименование типа объекта </param>
        /// <param name="key"> Параметр объекта </param>
        /// <param name="detail"> Текст ошибки </param>
        public NotFoundException(string name, object key, string detail)
            : base($"Object \"{name}\" ({key}) was not found.")
        {
            Detail = detail;
        }

        public NotFoundException(string name, object key)
            : base($"Object \"{name}\" ({key}) was not found.")
        {
            Detail = "Запрашиваемый объект не найден";
        }

        /// <summary>
        /// Детали ошибки для вывода на фронте
        /// </summary>
        public string Detail { get; }
    }
}
