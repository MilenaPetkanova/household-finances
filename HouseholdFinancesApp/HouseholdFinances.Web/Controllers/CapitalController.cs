namespace FamilyIncomeExpences.Controllers
{
    using FamilyIncomeExpences.Data.Models.Capital;
    using HouseholdFinances.Services.DataServices.Contracts;
    using HouseholdFinances.Services.DataServices.Models.Capital;
    using Microsoft.AspNetCore.Mvc;
    using System.Collections.Generic;
    using System.Linq;

    [Route("api/[controller]")]
    public class CapitalController : Controller
    {
        private readonly ICapitalService _capitalService;

        public CapitalController(ICapitalService capitalService)
        {
            this._capitalService = capitalService;
        }

        [HttpGet("[action]")]
        public IEnumerable<CapitalDto> All()
        {
            //return Enumerable.Range(1, 5).Select(index => new Capital
            //{
            //    Cash = 15,
            //    DebitCardFirst = 25,
            //    DebitCardSecond = 35,
            //    DebitCardThird = 45,
            //});

            return this._capitalService.GetAll();
        }


    }
}

