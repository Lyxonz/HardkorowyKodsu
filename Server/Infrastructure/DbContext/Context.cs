using Microsoft.Data.SqlClient;
using System.Data;

namespace Infrastructure.DbContext;

public class Context
{
    private readonly string _connectionString;

    public Context(string connectionString)
    {
        _connectionString = connectionString;
    }

    public IDbConnection CreateConnection()
    {
        return new SqlConnection(_connectionString);
    }
}
