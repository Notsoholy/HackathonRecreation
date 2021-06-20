using System;

namespace Application.Usecases.Queries.GetUser
{
    public class UserMessageViewModel
    {
        public Guid Id { get; set; }

        public string RecreationEmail { get; set; }

        /// <summary>
        /// В теле письма ФИО юзера, почта юзера, телефон юзера, выбранные болезни, методы лечения/процедуры, доп услуги
        /// </summary>

        public string MessageText { get; set; }
    }
}
