using System.Collections.Generic;
using Futebol.Dados.Api.Models;
using MongoDB.Driver;

namespace Futebol.Dados.Api.Services
{
    public class JogoService
    {
        private readonly IMongoCollection<Jogo> _jogos;

        public JogoService(IFutebolDatabaseSettings settings)
        {
            var client = new MongoClient(settings.ConnectionString);
            var database = client.GetDatabase(settings.DatabaseName);

            _jogos = database.GetCollection<Jogo>(settings.JogosCollectionName);
        }
    }
}