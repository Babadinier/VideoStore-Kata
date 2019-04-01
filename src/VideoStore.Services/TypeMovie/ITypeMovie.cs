namespace VideoStore.Services.TypeMovie
{
    public interface ITypeMovie
    {
        decimal CalculateAmount(int daysRented);
        int CalculateFrequentRenterPoint(int daysRented);
    }
}
