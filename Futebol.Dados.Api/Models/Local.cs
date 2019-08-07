using MongoDB.Bson.Serialization.Attributes;

namespace Futebol.Dados.Api.Models
{
    public class Local
    {
        [BsonElement("estadio")]
        public string Estadio { get; set; }

        [BsonElement("cidade")]
        public string Cidade { get; set; }

        [BsonElement("estado")]
        public string Estado { get; set; }
    }
}