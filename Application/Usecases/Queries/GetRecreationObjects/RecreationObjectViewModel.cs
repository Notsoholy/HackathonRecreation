using Application.Usecases.Queries.CommonViewModels;
using System;
using System.Collections.Generic;

namespace Application.Usecases.Queries.GetRecreationObjects
{
    public class RecreationObjectViewModel
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public LocationViewModel Location { get; set; }

        public int Stars { get; set; }

        public ICollection<DiseaseViewModel> Diseases { get; set; }

        public ICollection<HealingMethodViewModel> HealingMethods { get; set; }

        public ICollection<AdditionalServiceViewModel> AdditionalServices { get; set; }

        public ContactsViewModel Contacts { get; set; }

        public string[] ImageLink { get; set; }
    }
}
