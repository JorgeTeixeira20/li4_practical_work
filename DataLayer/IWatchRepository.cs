// IWatchRepository.cs
using DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace demo.Features.Home
{
	public interface IWatchRepository
	{
		Task<List<WatchModel>> GetAllClocksAsync();
		Task AddClockAsync(WatchModel watch);
	}
}