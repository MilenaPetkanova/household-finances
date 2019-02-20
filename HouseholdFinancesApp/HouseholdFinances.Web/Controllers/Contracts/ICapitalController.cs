using HouseholdFinances.Services.DataServices.Models.Capital;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseholdFinances.Web.Controllers.Contracts
{
    public interface ICapitalController
    {
        IEnumerable<CapitalDto> All();


    }
}
