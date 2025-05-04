namespace SinemaArsivSitesi.Services.Movie
{
    public interface IMovieService
    {
        Task<bool> AddMovie(string title, string description, string genre, DateTime releaseDate, string director, string cast);
        Task<bool> UpdateMovie(int id, string title, string description, string genre, DateTime releaseDate, string director, string cast);
        Task<bool> DeleteMovie(int id);
        Task<List<Models.Movie>> GetAllMovies();
        Task<Models.Movie> GetMovieById(int id);
    }
}
