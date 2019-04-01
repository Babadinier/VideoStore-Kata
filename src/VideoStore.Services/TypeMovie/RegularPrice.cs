namespace VideoStore.Services.TypeMovie
{
    public class RegularTypeMovie : ITypeMovie
    {
        public decimal CalculateAmount(int daysRented)
        {
            var amountForRental = 2m;
            if (daysRented > 2)
            {
                amountForRental += (daysRented - 2) * 1.5m;
            }
            return amountForRental;
        }

        public int CalculateFrequentRenterPoint(int daysRented)
        {
            return 1;
        }
    }
}
