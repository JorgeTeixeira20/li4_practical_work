namespace DataLayer.Leilao
{
    public interface ILeilaoRepository
    {
        public Task<LeilaoModel> Find(string username);
        public Task<List<LeilaoModel>> FindAll();
        public Task Create(LeilaoModel card);
        public Task<LeilaoModel> Update(LeilaoModel user);
        public Task Remove(int code);
    }
}