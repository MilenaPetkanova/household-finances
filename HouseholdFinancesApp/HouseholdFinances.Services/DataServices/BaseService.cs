namespace HouseholdFinances.Services.DataServices
{
    using AutoMapper;

    public abstract class BaseService
    {
        public BaseService(IMapper mapper)
        {
            this.Mapper = mapper;
        }

        protected IMapper Mapper { get; }
    }
}
