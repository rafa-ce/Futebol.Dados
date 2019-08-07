using MongoDB.Bson.Serialization.Attributes;

namespace Futebol.Dados.Api.Models
{
    public class Gol
    {
        [BsonElement("casa")]
        public int Casa { get; set; }

        [BsonElement("fora")]
        public int Fora { get; set; }
    }
}