using System;

namespace FamilyIncomeExpences.Data.Models.Capital
{
    public class Capital : BaseCapital
    {
        public int Id { get; set; }

        public override decimal Cash { get; set; }

        public override decimal DebitCardFirst { get; set; }

        public override decimal DebitCardSecond { get; set; }

        public override decimal DebitCardThird { get; set; }

        public DateTime CreatedOn { get; set; }
    }
}
