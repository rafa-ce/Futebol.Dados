using Futebol.Dados.Api.Models;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Futebol.Dados.Api.Repositories
{
    public class JogoRepository
    {
        private readonly IMongoCollection<Jogo> _jogos;

        public JogoRepository(IFutebolDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _jogos = database.GetCollection<Jogo>(settings.JogosCollectionName);
        }

        public List<Jogo> JogosAnoRodada(int ano, int rodada)
        {
            return _jogos.Find<Jogo>(jogo => jogo.Ano == ano && jogo.Rodada == rodada).ToList();
        }
    }
}
