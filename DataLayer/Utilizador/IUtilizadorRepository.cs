namespace DataLayer.Utilizador
{
    public interface IUtilizadorRepository
    {
        public UtilizadorModel Find(int id);
        public Task<List<UtilizadorModel>> FindAll();
        public Task Create(UtilizadorModel card);
        public Task<UtilizadorModel> Update(UtilizadorModel user);
        public Task Remove(int code);
    }
}