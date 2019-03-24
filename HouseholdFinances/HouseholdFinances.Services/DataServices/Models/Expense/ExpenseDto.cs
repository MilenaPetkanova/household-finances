namespace HouseholdFinances.Services.DataServices.Models.Expense
{
    using System;

    public class ExpenseDto
    {
        public int Id { get; set; }

        public decimal Food { get; set; }

        public decimal PinMoney { get; set; }

        public decimal Transport { get; set; }

        public decimal Bills { get; set; }

        public decimal Others { get; set; }

        public decimal Total { get; set; }

        public DateTime Date { get; set; }

        public DateTime DateFormatted { get; set; }
    }
}
