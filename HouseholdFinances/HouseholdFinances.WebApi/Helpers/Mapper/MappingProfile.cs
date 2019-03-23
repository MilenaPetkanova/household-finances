namespace HouseholdFinances.Web.Helpers.Mapper
{
    using HouseholdFinances.Data.Models.Capital;
    using HouseholdFinances.Services.DataServices.Models.Capital;
    using AutoMapper;

    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Capital, CapitalDto>().ReverseMap();
        }
    }
}