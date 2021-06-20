using System;

namespace Domain.Entities
{
    public class UserMessage
    {
        public Guid Id { get; set; }

        public string RecreationEmail { get; set; }

        /// <summary>
        /// В теле письма ФИО юзера, почта юзера, телефон юзера, выбранные болезни, методы лечения/процедуры, доп услуги
        /// </summary>

        public string MessageText { get; set; }

        public Guid UserId { get; set; }
    }
}
