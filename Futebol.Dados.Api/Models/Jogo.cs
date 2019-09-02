using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace Futebol.Dados.Api.Models
{
    public class Jogo
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string Id { get; set; }
        
        [BsonElement("rodada")]
        public int Rodada { get; set; }

        [BsonElement("diaDaSemana")]
        public string DiaDaSemana { get; set; }

        [BsonElement("data")]
        public string Data { get; set; }

        [BsonElement("hora")]
        public string Hora { get; set; }

        [BsonElement("numero")]
        public int Numero { get; set; }
        
        [BsonElement("times")]
        public Time Times { get; set; }

        [BsonElement("gols")]
        public Gol Gols { get; set; }
        
        [BsonElement("local")]
        public Local Local { get; set; }

        [BsonElement("ano")]
        public int Ano { get; set; }
    }
}