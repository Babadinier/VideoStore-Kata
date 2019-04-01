using VideoStore.Services.TypeMovie;

namespace VideoStore.Services
{
    public class Movie
    {
        public ITypeMovie Type { get; }
        public virtual string Title { get; }

        public Movie(string title, ITypeMovie type)
        {
            Title = title;
            Type = type;
        }
    }
}
