namespace DataLayer.Licitacao
{
    public interface ILicitacaoRepository
    {
        public Task<LicitacaoModel> Find(string username);
        public Task<List<LicitacaoModel>> FindAll();
        public Task Create(LicitacaoModel card);
        public Task<LicitacaoModel> Update(LicitacaoModel user);
        public Task Remove(int code);
    }
}