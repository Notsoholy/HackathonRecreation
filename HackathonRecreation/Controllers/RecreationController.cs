using Application.Usecases.Commands;
using Application.Usecases.Queries.CommonViewModels;
using Application.Usecases.Queries.GetAdditionalServices;
using Application.Usecases.Queries.GetDiseases;
using Application.Usecases.Queries.GetHealingMethods;
using Application.Usecases.Queries.GetLocations;
using Application.Usecases.Queries.GetRecreationObject;
using Application.Usecases.Queries.GetRecreationObjects;
using Application.Usecases.Queries.GetUser;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HackathonRecreation.Controllers
{
    public class RecreationController : AppController
    {
        [HttpPost("/api/[controller]/signup")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> Register([FromBody] RegisterUserCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpPost("/api/[controller]/{id}/login")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        public async Task<IActionResult> Login(string id)
        {
            await Mediator.Send(new LoginUserCommand(id));

            return Ok();
        }

        [HttpPost("/api/[controller]/recreationObjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ICollection<RecreationObjectViewModel>> GetRecreationObjects([FromBody] GetRecreationObjectsQuery query)
        {
            return await Mediator.Send(query);
        }

        [HttpPost("/api/[controller]/userMessage")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        public async Task<IActionResult> SendUserMessage([FromBody] SendUserMessageCommand command)
        {
            await Mediator.Send(command);

            return NoContent();
        }

        [HttpGet("/api/[controller]/diseases")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ICollection<DiseaseViewModel>> GetDiseases()
        {
            return await Mediator.Send(new GetDiseasesQuery());
        }

        [HttpGet("/api/[controller]/healingMethods")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ICollection<HealingMethodViewModel>> GetHealingMethods()
        {
            return await Mediator.Send(new GetHealingMethodsQuery());
        }

        [HttpGet("/api/[controller]/locations")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ICollection<LocationViewModel>> GetLocations()
        {
            return await Mediator.Send(new GetLocationsQuery());
        }

        [HttpGet("/api/[controller]/additionalServices")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ICollection<AdditionalServiceViewModel>> GetAdditionalServices()
        {
            return await Mediator.Send(new GetAdditionalServicesQuery());
        }

        [HttpGet("/api/[controller]/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<RecreationObjectViewModel> GetRecreationObject(Guid id)
        {
            return await Mediator.Send(new GetRecreationObjectQuery(id));
        }

        [HttpGet("/api/[controller]/user/{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<UserViewModel> GetUser(string id)
        {
            return await Mediator.Send(new GetUserQuery(id));
        }
    }
}
