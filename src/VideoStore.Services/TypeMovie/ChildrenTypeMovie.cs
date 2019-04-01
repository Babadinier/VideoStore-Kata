namespace VideoStore.Services.TypeMovie
{
    public class ChildrenTypeMovie : ITypeMovie
    {
        private int _daysRented;
        public ChildrenTypeMovie(int daysRented)
        {
            _daysRented = daysRented;
        }

        public decimal Amount => GetAmount();
        public int RenterPoint => 1;

        public decimal GetAmount()
        {
            var amountForRental = 1.5m;
            if (_daysRented > 3)
            {
                amountForRental += (_daysRented - 3) * 1.5m;
            }
            return amountForRental;
        }
    }
}
