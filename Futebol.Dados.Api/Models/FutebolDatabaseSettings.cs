namespace Futebol.Dados.Api.Models
{
    public class FutebolDatabaseSettings : IFutebolDatabaseSettings
    {
        public string JogosCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }

    public interface IFutebolDatabaseSettings
    {
        string JogosCollectionName { get; set; }
        string ConnectionString { get; set; }
        string DatabaseName { get; set; }
    }
}