using System.ComponentModel.DataAnnotations;

namespace FutureValue.Models
{
    public class FutureValueModel
    {
        [Required(ErrorMessage = "Please enter a 'monthly investment' amount")]
        public decimal? MonthlyInvestment { get; set; }
        [Required(ErrorMessage = "Please enter a 'yearly interest rate' amount")]
        public decimal? YearlyInterestRate { get; set; }
        [Required (ErrorMessage = "Please enter a number of years")]
        public int? Years { get; set; }

        public decimal? CalculateFutureValue()
        {
            int? months = Years * 12;
            decimal? monthlyInterestRate = YearlyInterestRate / 12 / 100;
            decimal? futureValue = 0;

            for (int i = 0; i < months; i++)
            {
                futureValue = (futureValue + MonthlyInvestment) * (1 + monthlyInterestRate);
            }

            return futureValue;
        }
    }
}