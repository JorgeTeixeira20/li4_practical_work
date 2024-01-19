using DataLayer.Watches;

namespace DataLayer.Leilao
{
    public interface ILeilaoRepository
    {
        public Task<LeilaoModel> Find(string username);
        public Task<List<LeilaoModel>> FindAll();
        public Task<WatchModel> FindWatch(int leilaoId);
        public Task Create(LeilaoModel card);
        public Task<LeilaoModel> Update(LeilaoModel user);
        public Task Remove(int code);
    }
}