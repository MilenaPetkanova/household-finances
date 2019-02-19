using HouseholdFinances.Services.DataServices.Models.Capital;
using System.Collections.Generic;

namespace HouseholdFinances.Services.DataServices.Contracts
{
    public interface ICapitalService
    {
        IEnumerable<CapitalDto> GetAll();

        void AddCapital(decimal cash, decimal debitCardFirst, decimal debitCardSecond, decimal debitCardThird);
    }
}
