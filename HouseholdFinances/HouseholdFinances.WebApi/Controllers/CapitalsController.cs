namespace HouseholdFinances.WebApi.Controllers
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using AutoMapper;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using HouseholdFinances.Data;
    using HouseholdFinances.Services.DataServices.Contracts;
    using HouseholdFinances.Services.DataServices.Models.Capital;

    [Route("api/[controller]")]
    [ApiController]
    public class CapitalsController : ControllerBase
    {
        private readonly ICapitalService _capitalService;
        private readonly IMapper _mapper;
        private readonly HouseholdFinancesContext _context;

        public CapitalsController(ICapitalService capitalService, HouseholdFinancesContext context, IMapper mapper)
        {
            this._capitalService = capitalService;
            this._context = context;
            this._mapper = mapper;
        }

        // GET: api/Capitals
        [HttpGet]
        public async Task<IEnumerable<CapitalDto>> GetAllCapitalItems()
        {
            var allCapitalDtos = await this._capitalService.GetAllAsync();

            return allCapitalDtos;
        }

        // GET: api/Capitals/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CapitalDto>> GetCapitalItem(int id)
        {
            var capitalDto = await this._capitalService.GetByIdAsync(id);

            if (capitalDto == null)
            {
                return NotFound();
            }

            return capitalDto;
        }

        // POST: api/Capitals
        [HttpPost]
        public async Task<ActionResult<CapitalDto>> CreateCapitalItem(CapitalDto capitalDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            await Task.Run(() => this._capitalService.AddCapital(capitalDto));

            return CreatedAtAction(nameof(GetCapitalItem), new { id = capitalDto.Id }, capitalDto);
        }

        // PUT: api/Capitals/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCapitalItem(int id, CapitalDto capitalDto)
        {
            if (id != capitalDto.Id)
            {
                return BadRequest();
            }

            _context.Entry(capitalDto).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // DELETE: api/Capitals/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCapitalItem(int id)
        {
            var capitalItem = await _context.Capitals.FindAsync(id);

            if (capitalItem == null)
            {
                return NotFound();
            }

            _context.Capitals.Remove(capitalItem);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
