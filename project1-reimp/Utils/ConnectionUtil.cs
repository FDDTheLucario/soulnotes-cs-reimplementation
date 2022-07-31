
namespace Dev.Richard.Utils;
using Npgsql;

public sealed class ConnectionUtil
{
    private static ConnectionUtil? _connectionUtil;
    public static ConnectionUtil Instance
    {
        get { return _connectionUtil ??= new ConnectionUtil(); }
    }

    public NpgsqlConnection Connection =>
        new("Host=localhost:5432;Username=postgres;Password=revature;Database=postgres;Search Path=soulnotes;Include Error Detail=true");
}