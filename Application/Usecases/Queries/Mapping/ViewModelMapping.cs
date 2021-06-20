using Application.Usecases.Queries.CommonViewModels;
using Application.Usecases.Queries.GetRecreationObjects;
using Application.Usecases.Queries.GetUser;
using Domain.Entities;
using System.Linq;

namespace Application.Usecases.Queries.Mapping
{
    public static class ViewModelMapping
    {
        public static DiseaseViewModel Map(this Disease disease)
        {
            return new()
            {
                Id = disease.Id,
                Name = disease.Name
            };
        }

        public static HealingMethodViewModel Map(this HealingMethod healingMethod)
        {
            return new()
            {
                Id = healingMethod.Id,
                Name = healingMethod.Name
            };
        }

        public static AdditionalServiceViewModel Map(this AdditionalService additionalService)
        {
            return new()
            {
                Id = additionalService.Id,
                Name = additionalService.Name
            };
        }

        public static ContactsViewModel Map(this Contacts contacts)
        {
            return new()
            {
                Address = contacts.Address,
                Email = contacts.Email,
                Phone = contacts.Phone,
                Website = contacts.Website
            };
        }

        public static LocationViewModel Map(this Location location)
        {
            return new()
            {
                Id = location.Id,
                Name = location.Name
            };
        }

        public static RecreationObjectViewModel Map(this RecreationObject recreationObject)
        {
            return new()
            {
                Description = recreationObject.Description,
                Id = recreationObject.Id,
                Name = recreationObject.Name,
                Stars = recreationObject.Stars,
                AdditionalServices = recreationObject.AdditionalServices.Select(x => x.Map()).ToList(),
                Contacts = recreationObject.Contacts.Map(),
                Diseases = recreationObject.Diseases.Select(x => x.Map()).ToList(),
                HealingMethods = recreationObject.HealingMethods.Select(x => x.Map()).ToList(),
                Location = recreationObject.Location.Map(),
                ImageLink = recreationObject.ImageLinks
            };
        }

        public static UserViewModel Map(this User user)
        {
            return new()
            {
                Email = user.Email,
                FirstName = user.FirstName,
                LastName = user.LastName,
                Patronymic = user.Patronymic,
                Phone = user.Phone,
                UserMessages = user.UserMessages.Select(x => x.Map()).ToList(),
                UserUid = user.UserUid,
                Id = user.Id
            };
        }

        public static UserMessageViewModel Map(this UserMessage userMessage)
        {
            return new()
            {
                Id = userMessage.Id,
                MessageText = userMessage.MessageText,
                RecreationEmail = userMessage.RecreationEmail
            };
        }
    }
}
