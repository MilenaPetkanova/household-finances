namespace HouseholdFinances.Data.Models.Capital
{
    public abstract class BaseCapital
    {
        public abstract decimal Cash { get; set; }

        public abstract decimal DebitCardFirst { get; set; }

        public abstract decimal DebitCardSecond { get; set; }

        public abstract decimal DebitCardThird { get; set; }
    }
}
