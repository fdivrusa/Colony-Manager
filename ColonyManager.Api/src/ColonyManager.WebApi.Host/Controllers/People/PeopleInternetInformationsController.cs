﻿using ColonyManager.Domain.Interfaces.Services;
using ColonyManager.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ColonyManager.WebApi.Host.Controllers.People
{

    [ApiController]
    [Route("api/[controller]")]
    public class PeopleInternetInformationsController : BaseController
    {
        private readonly IPeopleInternetInformationService _peopleInternetInformationService;

        public PeopleInternetInformationsController(IPeopleInternetInformationService peopleInternetInformationService)
        {
            _peopleInternetInformationService = peopleInternetInformationService;
        }

        [HttpGet]
        [Route("peopleId/{peopleId}")]
        public async Task<IEnumerable<PeopleInternetInformationDto>> GetPeopleInternetInformationsAsync(int peopleId)
        {
            return await _peopleInternetInformationService.GetPeopleInternetInformationsAsync(peopleId);
        }

        [HttpPost]
        public async Task<PeopleInternetInformationDto> AddPeopleInternetInformationAsync(AddPeopleInternetInformationRequestDto request)
        {
            return await _peopleInternetInformationService.AddPeopleInternetInformationAsync(request, Account?.FullName);
        }

        [HttpPut]
        public async Task<PeopleInternetInformationDto> UpdatePeoppleInternetInformationAsync(UpdatePeopleInternetInformationRequestDto request)
        {
            return await _peopleInternetInformationService.UpdatePeopleInternetInformationAsync(request, Account?.FullName);
        }
    }
}
