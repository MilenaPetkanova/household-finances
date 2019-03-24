namespace HouseholdFinances.Web.Helpers.Mapper
{
    using AutoMapper;
    using HouseholdFinances.Data.Models.Capital;
    using HouseholdFinances.Services.DataServices.Models.Capital;
    using HouseholdFinances.Data.Models.Expense;
    using HouseholdFinances.Services.DataServices.Models.Expense;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Capital, CapitalDto>().ReverseMap();
            CreateMap<Expense, ExpenseDto>().ReverseMap();
        }
    }
}