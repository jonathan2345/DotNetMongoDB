namespace MVCMongoDB.Models
{
    public class LogSettings : ILogSettings
    {
        public string Server { get; set; }

        public string Database { get; set; }

        public string Collection { get; set; }
    }

    public interface ILogSettings
    {
        string Server { get; set; }

        string Database { get; set; }

        string Collection { get; set; }
    }
}
