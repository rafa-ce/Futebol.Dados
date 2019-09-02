using System;
using System.Collections.Generic;
using AutoMapper;
using Futebol.Dados.Api.DTOs;
using Futebol.Dados.Api.Models;
using Futebol.Dados.Api.Repositories;
using MongoDB.Driver;

namespace Futebol.Dados.Api.Services
{
    public class JogoService
    {
        private readonly JogoRepository _jogosRepository;
        private readonly IMapper _mapper;

        public JogoService(JogoRepository jogoRepository, IMapper mapper)
        {
            _jogosRepository = jogoRepository;
            _mapper = mapper;
        }

        public List<JogoDTO> Jogos(int ano, int rodada)
        {
            var jogos = _jogosRepository.JogosAnoRodada(ano, rodada);

            return _mapper.Map<List<Jogo>, List<JogoDTO>>(jogos);
        }
    }
}