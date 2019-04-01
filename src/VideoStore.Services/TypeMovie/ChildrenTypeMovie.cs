namespace VideoStore.Services.TypeMovie
{
    public class ChildrenTypeMovie : ITypeMovie
    {
        public decimal CalculateAmount(int daysRented)
        {
            var amountForRental = 1.5m;
            if (daysRented > 3)
            {
                amountForRental += (daysRented - 3) * 1.5m;
            }
            return amountForRental;
        }

        public int CalculateFrequentRenterPoint(int daysRented)
        {
            return 1;
        }
    }
}
