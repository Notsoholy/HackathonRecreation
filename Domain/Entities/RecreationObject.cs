using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class RecreationObject
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public Location Location { get; set; }

        public int Stars { get; set; }

        public ICollection<Disease> Diseases { get; set; }

        public ICollection<HealingMethod> HealingMethods { get; set; }

        public ICollection<AdditionalService> AdditionalServices { get; set; }

        public Contacts Contacts { get; set; }

        public ICollection<UserMessage> UserMessages { get; set; }

        public string[] ImageLinks { get; set; }
    }
}
