using HouseholdFinances.Services.DataServices.Models.Capital;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HouseholdFinances.Services.DataServices.Contracts
{
    public interface ICapitalService
    {
        Task<IEnumerable<CapitalDto>> GetAllAsync();

        Task<CapitalDto> GetByIdAsync(int id);

        void AddCapital(CapitalDto capitalDto);
    }
}
