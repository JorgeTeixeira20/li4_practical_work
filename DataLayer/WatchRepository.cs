﻿// WatchRepository.cs
using DataLayer;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace demo.Features.Home
{
    public class WatchRepository : IWatchRepository
    {
        private readonly ISqlDataAccess _db;

        public WatchRepository(ISqlDataAccess db)
        {
            _db = db;
        }

        public async Task<List<WatchModel>> GetAllClocksAsync()
        {
            string sql = "SELECT * FROM watches";
            return await _db.LoadData<WatchModel, dynamic>(sql, new { });
        }

        public async Task AddClockAsync(WatchModel watch)
        {
            string sql = "INSERT INTO watches (Modelo, NumeroSerie, Descricao, Imagem, Marca, EstadoConservacao, TemCaixaOriginal, AnoFabrico, RelogioFunciona, PrecoBase, DataHoraInicio, DataHoraFecho) " +
                         "VALUES (@Modelo, @NumeroSerie, @Descricao, @Imagem, @Marca, @EstadoConservacao, @TemCaixaOriginal, @AnoFabrico, @RelogioFunciona, @PrecoBase, @DataHoraInicio, @DataHoraFecho)";

            await _db.SaveData(sql, new
            {
                watch.Modelo,
                watch.NumeroSerie,
                watch.Descricao,
                watch.Imagem,
                watch.Marca,
                watch.EstadoConservacao,
                watch.TemCaixaOriginal,
                watch.AnoFabrico,
                watch.RelogioFunciona,
                watch.PrecoBase,
                watch.DataHoraInicio,
                watch.DataHoraFecho
            });
        }
    }
}