namespace HouseholdFinances.WebApi.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using HouseholdFinances.Services.DataServices.Contracts;
    using HouseholdFinances.Services.DataServices.Models.Capital;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;

    [Route("api/[controller]")]
    [ApiController]
    public class CapitalsController : ControllerBase
    {
        private readonly ICapitalService _capitalService;

        public CapitalsController(ICapitalService capitalService)
        {
            this._capitalService = capitalService;
        }

        // GET: api/Capitals
        [HttpGet]
        public IEnumerable<CapitalDto> Get()
        {
            return this._capitalService.GetAll();
        }

        // GET: api/Capitals/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Capitals
        //[HttpPost]
        //public void Post([FromBody] string value)
        //{
        //}

        // POST: api/Capitals
        [HttpPost]
        public CapitalDto Create(CapitalDto capital)
        {
             this._capitalService.AddCapital();
        }

        // PUT: api/Capitals/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
