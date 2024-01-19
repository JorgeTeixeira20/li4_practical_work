using System.Data;
using System.Data.SqlClient;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace DataLayer;

public class SqlDataAccess : ISqlDataAccess
{
    private readonly IConfiguration _config;
    public string ConnectionStringName { get; set; } = "Default";
    public SqlDataAccess(IConfiguration config)
    {
        _config = config;
    }
    public async Task<List<T>> LoadData<T, U>(string sql, U parameters)
    {
        try
        {
            Console.WriteLine("[Antes de _cfg.GetConnString]Entrei em LoadData: " + sql);
            string? connectionString = _config.GetConnectionString(ConnectionStringName);
            Console.WriteLine("[Depois de string? connectionString][antes de using IDBConnection]");
            Console.WriteLine($"Connection string: {connectionString}");
            using IDbConnection connection = new SqlConnection(connectionString);
            Console.WriteLine($"SQL Query: {sql}");
            Console.WriteLine($"Parameters: {parameters}");
            var data = await connection.QueryAsync<T>(sql, parameters);
            Console.WriteLine("Antes do return de LaodDta em SQLDataAccess!");
            return data.ToList();

        }
        catch (Exception ex)

        {
            Console.WriteLine(ex.ToString());
            return new List<T>();
        }
    }
    public async Task SaveData<T>(string sql, T parameters)
    {
        string? connectionString = _config.GetConnectionString(ConnectionStringName);
        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            await connection.ExecuteAsync(sql, parameters);
        }
    }

    public async Task<int> SaveDataGetId<T>(string sql, T parameters)
    {
        string? connectionString = _config.GetConnectionString(ConnectionStringName);
        using (IDbConnection connection = new SqlConnection(connectionString))
        {
            return await connection.ExecuteScalarAsync<int>(sql, parameters);
        }
    }
}