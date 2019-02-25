namespace HouseholdFinances.Services.DataServices
{
    using AutoMapper;
    using FamilyIncomeExpences.Data.Models.Capital;
    using HouseholdFinances.Data;
    using HouseholdFinances.Services.DataServices.Contracts;
    using HouseholdFinances.Services.DataServices.Models.Capital;
    using Microsoft.EntityFrameworkCore;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    public class CapitalService : ICapitalService
    {
        private readonly IMapper _mapper;
        private readonly HouseholdFinancesContext _context;

        public CapitalService(IMapper mapper, HouseholdFinancesContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public async Task<IEnumerable<CapitalDto>> GetAllAsync()
        {
            return await this._context.Capitals
                .Select(c => this._mapper.Map<CapitalDto>(c))
                .OrderBy(c => c.CreatedOn)
                .ToListAsync();
        }

        public async Task<CapitalDto> GetByIdAsync(int id)
        {
            return await this._context.Capitals
                .Where(c => c.Id.Equals(id))
                .Select(c => this._mapper.Map<CapitalDto>(c))
                .FirstOrDefaultAsync();
        }

        public void AddCapital(CapitalDto capitalDto)
        {
            var capital = this._mapper.Map<Capital>(capitalDto);
            _context.Capitals.AddAsync(capital);
            _context.SaveChangesAsync();
        }
    }
}
