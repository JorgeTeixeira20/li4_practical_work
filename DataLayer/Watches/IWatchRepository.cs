// IWatchRepository.cs
namespace DataLayer.Watches;

public interface IWatchRepository
{
    Task<List<WatchModel>> GetAllClocksAsync();
    Task AddClockAsync(WatchModel watch);
}