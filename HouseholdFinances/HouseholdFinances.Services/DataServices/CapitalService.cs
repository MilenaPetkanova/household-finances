namespace HouseholdFinances.Services.DataServices
{
    using AutoMapper;
    using FamilyIncomeExpences.Data.Models.Capital;
    using HouseholdFinances.Data;
    using HouseholdFinances.Services.DataServices.Contracts;
    using HouseholdFinances.Services.DataServices.Models.Capital;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class CapitalService : ICapitalService
    {
        private readonly IMapper _mapper;
        private readonly HouseholdFinancesContext _context;

        public CapitalService(IMapper mapper, HouseholdFinancesContext context)
        {
            this._mapper = mapper;
            this._context = context;
        }

        public IEnumerable<CapitalDto> GetAll()
        {
            return this._context.Capitals
                .Select(c => this._mapper.Map<CapitalDto>(c));
        }

        public CapitalDto GetById(int id)
        {
            return this._context.Capitals
                .Where(c => c.Id.Equals(id))
                .Select(c => this._mapper.Map<CapitalDto>(c))
                .FirstOrDefault();
        }

        public void AddCapital(decimal cash, decimal debitCardFirst, decimal debitCardSecond, decimal debitCardThird)
        {
            
        }
    }
}
