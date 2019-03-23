namespace HouseholdFinances.Data.Models.Capital
{
    using System;

    public class Capital : BaseModel
    {
        public decimal Cash { get; set; }

        public decimal DebitCardFirst { get; set; }

        public decimal DebitCardSecond { get; set; }

        public decimal DebitCardThird { get; set; }

        public decimal Total { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
