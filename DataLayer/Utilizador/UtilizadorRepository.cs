namespace DataLayer.Utilizador;

public class UtilizadorRepository : IUtilizadorRepository
{
    private ISqlDataAccess _db; 
    public UtilizadorRepository(ISqlDataAccess db)
    {
        _db = db;
    }

    public UtilizadorModel Find(int id)
    {
        string sql = "select * from Utilizador where idUtilizador = @Id";
        List<UtilizadorModel> utiRes = _db.LoadData<UtilizadorModel, dynamic>(sql, new { Id = id }).Result;
        return utiRes.First();
    }

    public Task<List<UtilizadorModel>> FindAll()
    {
        string sql = "select * from Utilizador";
        return _db.LoadData<UtilizadorModel, dynamic>(sql, new { });
    }

    public async Task Create(UtilizadorModel user)
    {
        string sql = "INSERT INTO Utilizador (username, password, avaliacaoMedia, numeroDeLeiloesFeitos, dataDeRegisto)" +
                     "VALUES (@username, @password, @avaliacaoMedia, @numeroDeLeiloesFeitos, @dataDeRegisto)";

        await _db.SaveData(sql, new 
        {
            user.username,
            user.password,
            user.avaliacaoMedia,
            user.numeroDeLeiloesFeitos,
            user.dataDeRegisto
        });
    }

    public Task<UtilizadorModel> Update(UtilizadorModel user)
    {
        //string sql = "UPDATE Utilizador SET ";
        throw new NotImplementedException();
    }

    public Task Remove(int code)
    {
        throw new NotImplementedException();
    }
}