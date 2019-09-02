using MongoDB.Bson.Serialization.Attributes;

namespace Futebol.Dados.Api.Models
{
    public class Time
    {
        [BsonElement("casa")]
        public string Casa { get; set; }

        [BsonElement("fora")]
        public string Fora { get; set; }
    }
}