using System;
using System.Collections.Generic;

namespace Domain.Entities
{
    public class Disease
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public ICollection<RecreationObject> RecreationObjects { get; set; }
    }
}
