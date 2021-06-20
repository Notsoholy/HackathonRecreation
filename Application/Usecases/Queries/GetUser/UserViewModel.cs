using System;
using System.Collections.Generic;

namespace Application.Usecases.Queries.GetUser
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string UserUid { get; set; }

        public ICollection<UserMessageViewModel> UserMessages { get; set; }
    }
}
