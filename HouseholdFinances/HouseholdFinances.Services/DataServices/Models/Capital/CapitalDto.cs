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

        public decimal Total => this.Cash + this.DebitCardFirst + this.DebitCardSecond + this.DebitCardThird;
            
        public DateTime CreatedOn { get; set; }

        public string CreatedOnFormatted => this.CreatedOn.ToString("dd/MM/yyyy");
    }
}
