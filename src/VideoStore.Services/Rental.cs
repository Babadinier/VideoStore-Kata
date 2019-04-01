namespace VideoStore.Services
{
    public class Rental
    {
        public Movie Movie { get; }
        public int DaysRented { get; }

        public Rental(Movie movie, int daysRented)
        {
            Movie = movie;
            DaysRented = daysRented;
        }

        public decimal CalculateAmount() => Movie.Type.CalculateAmount(DaysRented);

        public int CalculateFrequentRenterPoints() => Movie.Type.CalculateFrequentRenterPoint(DaysRented);
    }
}
