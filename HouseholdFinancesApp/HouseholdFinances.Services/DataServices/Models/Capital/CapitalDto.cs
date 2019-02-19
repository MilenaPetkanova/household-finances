namespace HouseholdFinances.Services.DataServices.Models.Capital
{
    using System;

    public class CapitalDto
    {
        public int Id { get; set; }

        public decimal Cash { get; set; }

        public decimal DebitCardFirst { get; set; }

        public decimal DebitCardSecond { get; set; }

        public decimal DebitCardThird { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
