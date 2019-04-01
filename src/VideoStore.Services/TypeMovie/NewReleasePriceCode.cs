namespace VideoStore.Services.TypeMovie
{
    public class NewReleaseTypeMovie : ITypeMovie
    {
        public decimal CalculateAmount(int daysRented)
        {
            return daysRented * 3;
        }

        public int CalculateFrequentRenterPoint(int daysRented)
        {
            var frequentRenterPoints = 1;
            if (daysRented > 1)
            {
                frequentRenterPoints++;
            }
            return frequentRenterPoints;
        }
    }
}
