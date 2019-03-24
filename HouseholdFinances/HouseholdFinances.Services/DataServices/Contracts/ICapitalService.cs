namespace HouseholdFinances.Services.DataServices.Contracts
{
    using System.Collections.Generic;
    using System.Threading.Tasks;
    using HouseholdFinances.Services.DataServices.Models.Capital;

    public interface ICapitalService
    {
        Task<IEnumerable<CapitalDto>> GetAllAsync();

        Task<CapitalDto> GetByIdAsync(int id);

        void AddCapital(CapitalDto capitalDto);
    }
}
