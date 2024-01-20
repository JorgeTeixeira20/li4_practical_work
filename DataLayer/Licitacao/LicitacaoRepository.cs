namespace DataLayer.Licitacao;

public class LicitacaoRepository : ILicitacaoRepository
{
    private ISqlDataAccess _db;
    public LicitacaoRepository(ISqlDataAccess db)
    {
        _db = db;
    }

    public async Task<LicitacaoModel> Find(string username)
    {
        Console.WriteLine($"Entrei em Find Licitacao Movel com username: {username}!");
        string sql = $"select * from Licitacao where username = '{username}'";
        List<LicitacaoModel> leiRes = await _db.LoadData<LicitacaoModel, dynamic>(sql, new { Username = username });
        Console.WriteLine("depois de _db.LoadData");
        if (leiRes != null && leiRes.Count > 0)
        {
            Console.WriteLine($"Encontrei {leiRes.Count}");
            return leiRes.First();
        }
        else
        {
            Console.WriteLine("Licitacao encontrou null");
            return null;
        }
    }

    public Task<List<LicitacaoModel>> FindAll()
    {
        string sql = "select * from Licitacao";
        return _db.LoadData<LicitacaoModel, dynamic>(sql, new { });
    }

    public async Task Create(LicitacaoModel licitacao)
    {
        string sql = "INSERT INTO Licitacao (username, valor, Data, Leilao_idUtilizador, Utilizador_idUtilizador)" +
                     "VALUES (@username, @valor, @Data, @Leilao_idUtilizador, @Utilizador_idUtilizador)";

        await _db.SaveData(sql, new
        {
            licitacao.username,
            licitacao.valor,
            licitacao.Data,
            licitacao.Leilao_idUtilizador,
            licitacao.Utilizador_idUtilizador
        });
    }

    public Task<LicitacaoModel> Update(LicitacaoModel licitacao)
    {
        //string sql = "UPDATE Utilizador SET ";
        throw new NotImplementedException();
    }

    public Task Remove(int code)
    {
        throw new NotImplementedException();
    }
}