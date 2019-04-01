namespace VideoStore.Services.TypeMovie
{
    public class RegularTypeMovie : ITypeMovie
    {
        private readonly int _daysRented;
        public RegularTypeMovie(int daysRented)
        {
            _daysRented = daysRented;
        }

        public decimal Amount => GetAmount();
        public int RenterPoint => 1;

        public decimal GetAmount()
        {
            var amountForRental = 2m;
            if (_daysRented > 2)
            {
                amountForRental += (_daysRented - 2) * 1.5m;
            }
            return amountForRental;
        }
    }
}
