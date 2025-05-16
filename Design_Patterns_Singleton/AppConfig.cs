namespace testAppConsol
{
    internal partial class Program
    {

        public sealed class AppConfig
        {
            public string ConnectionString { get; set; }
            public int OrdersCount { get; set; }

            private static readonly AppConfig? _instance = new();
            private AppConfig()
            {
                ConnectionString = " ConnectionString ";
                OrdersCount = 1;

            }
            public static AppConfig Instance => _instance;
        }
    }

}