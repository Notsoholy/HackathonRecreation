using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class User
    {
        public Guid Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Patronymic { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string UserUid { get; set; }

        public ICollection<UserMessage> UserMessages { get; set; }
    }
}
