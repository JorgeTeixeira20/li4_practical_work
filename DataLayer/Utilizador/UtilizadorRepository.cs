namespace DataLayer.Utilizador;

public class UtilizadorRepository : IUtilizadorRepository
{
    private ISqlDataAccess _db; 
    public UtilizadorRepository(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<UtilizadorModel> Find(string username)
    {
        Console.WriteLine($"Entrei em Find Utilizador Movel com username: {username}!");
        string sql = $"select * from Utilizador where username = '{username}'";
        List<UtilizadorModel> utiRes = await _db.LoadData<UtilizadorModel, dynamic>(sql, new { Username = username });
        Console.WriteLine("depois de _db.LoadData");
        if (utiRes != null && utiRes.Count > 0)
        {
            Console.WriteLine($"Encontrei {utiRes.Count}");
            return utiRes.First();
        }
        else
        {
            Console.WriteLine("Utilizador encontrou null");
            return null;
        }
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