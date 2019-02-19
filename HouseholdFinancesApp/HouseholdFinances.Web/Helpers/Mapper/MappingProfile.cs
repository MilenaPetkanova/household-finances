namespace HouseholdFinances.Web.Helpers.Mapper
{
    using AutoMapper;
    using FamilyIncomeExpences.Data.Models.Capital;
    using HouseholdFinances.Services.DataServices.Models.Capital;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Capital, CapitalDto>();
            CreateMap<CapitalDto, Capital>();
        }
    }
}