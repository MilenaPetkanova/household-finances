using HouseholdFinances.Services.DataServices.Models.Capital;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseholdFinances.Services.DataServices.Contracts
{
    public interface ICapitalService
    {
        Task<IEnumerable<CapitalDto>> GetAll();

        Task<CapitalDto> GetById(int id);

        void AddCapital(decimal cash, decimal debitCardFirst, decimal debitCardSecond, decimal debitCardThird);
    }
}
