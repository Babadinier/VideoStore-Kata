using System.Collections.Generic;
using System.Globalization;

namespace VideoStore.Services
{
    public class Customer
    {
        private readonly List<Rental> _rentals = new List<Rental>();
        public string Name { get; }
        public int RenterPoints { get; set; }
        public decimal TotalAmount { get; set; }

        public Customer(string name)
        {
            Name = name;
        }

        public void AddRental(Rental rental)
        {
            _rentals.Add(rental);
        }

        //todo : create object statement or other name and move to it
        public string GetStatement()
        {
            var statement = $"Rental Record for {Name}\n";
            foreach (var rental in _rentals)
            {

                RenterPoints += rental.CalculateFrequentRenterPoints();
                var amount = rental.CalculateAmount();

                statement += "\t" + rental.Movie.Title + "\t" + amount.ToString("0.0", CultureInfo.InvariantCulture) + "\n";
                TotalAmount += amount;
            }

            statement += $"You owed {TotalAmount.ToString("0.0", CultureInfo.InvariantCulture)}\n";
            statement += $"You earned {RenterPoints.ToString()} frequent renter points \n";

            return statement;
        }
    }
}
