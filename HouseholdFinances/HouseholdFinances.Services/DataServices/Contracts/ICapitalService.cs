using HouseholdFinances.Services.DataServices.Models.Capital;
using System.Collections.Generic;

namespace HouseholdFinances.Services.DataServices.Contracts
{
    public interface ICapitalService
    {
        IEnumerable<CapitalDto> GetAll();

        CapitalDto GetById(int id);

        void AddCapital(decimal cash, decimal debitCardFirst, decimal debitCardSecond, decimal debitCardThird);
    }
}
