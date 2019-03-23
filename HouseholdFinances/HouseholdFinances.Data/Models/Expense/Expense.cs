namespace HouseholdFinances.Data.Models.Expense
{
    using System;

    public class Expense : BaseModel
    {
        public decimal Food { get; set; }

        public decimal PinMoney { get; set; }

        public decimal Transport { get; set; }

        public decimal Bills { get; set; }

        public decimal Others { get; set; }

        public DateTime Date { get; set; }
    }
}
