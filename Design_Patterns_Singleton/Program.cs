using static testAppConsol.Program;

internal class Program
{
    private static void Main(string[] args)
    {
        var config = AppConfig.Instance;
        Console.WriteLine(config.ConnectionString);
    }
}