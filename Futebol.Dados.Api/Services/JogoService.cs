using System;
using System.Collections.Generic;
using Futebol.Dados.Api.Models;
using Futebol.Dados.Api.Repositories;
using MongoDB.Driver;

namespace Futebol.Dados.Api.Services
{
    public class JogoService
    {
        private readonly JogoRepository _jogosRepository;

        public JogoService(JogoRepository jogoRepository)
        {
            _jogosRepository = jogoRepository;
        }

        public List<Jogo> Jogos(int ano, int rodada)
        {
            return _jogosRepository.JogosAnoRodada(ano, rodada);
        }
    }
}