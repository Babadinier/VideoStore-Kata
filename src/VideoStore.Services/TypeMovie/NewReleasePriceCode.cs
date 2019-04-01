namespace VideoStore.Services.TypeMovie
{
    public class NewReleaseTypeMovie : ITypeMovie
    {
        private int _daysRented;
        public NewReleaseTypeMovie(int daysRented)
        {
            _daysRented = daysRented;
        }

        public decimal Amount => _daysRented * 3;
        public int RenterPoint => GetFrequentRenterPoints();


        private int GetFrequentRenterPoints()
        {
            var frequentRenterPoints = 1;
            if (_daysRented > 1)
            {
                frequentRenterPoints++;
            }
            return frequentRenterPoints;
        }
    }
}
