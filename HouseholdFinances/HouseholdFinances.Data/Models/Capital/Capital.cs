namespace FamilyIncomeExpences.Data.Models.Capital
{
    using HouseholdFinances.Data.Models.Capital;
    using System;

    public class Capital : BaseCapital
    {
        public int Id { get; set; }

        public override decimal Cash { get; set; }

        public override decimal DebitCardFirst { get; set; }

        public override decimal DebitCardSecond { get; set; }

        public override decimal DebitCardThird { get; set; }

        public decimal Total { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
