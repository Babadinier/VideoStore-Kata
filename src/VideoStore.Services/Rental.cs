namespace VideoStore.Services
{
    public class Rental
    {
        public Movie Movie { get; }

        public Rental(Movie movie)
        {
            Movie = movie;
        }
    }
}
