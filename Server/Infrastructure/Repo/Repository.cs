using Dapper;
using Infrastructure.DbContext;
using Shared.Models;

namespace Infrastructure.Repo;

public class Repository : IRepository
{
    private readonly Context _dbContext;

    public Repository(Context dbContext)
    {
        _dbContext = dbContext;
    }

    public async Task<DatabaseStructure> GetDatabaseStructureAsync()
    {
        string tableQuery = @"
            SELECT TABLE_NAME
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_TYPE = 'BASE TABLE'";

        string viewQuery = @"
            SELECT TABLE_NAME
            FROM INFORMATION_SCHEMA.VIEWS";

        using var connection = _dbContext.CreateConnection();

        var tables = await connection.QueryAsync<string>(tableQuery);
        var views = await connection.QueryAsync<string>(viewQuery);

        return new DatabaseStructure
        {
            TableList = tables.ToList(),
            ViewList = views.ToList()
        };
    }

    public async Task<TablesStructure> GetTablesStructureAsync()
    {
        string columnsQuery = @"
            SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE
            FROM INFORMATION_SCHEMA.COLUMNS";

        string tablesQuery = @"
            SELECT TABLE_NAME, TABLE_TYPE
            FROM INFORMATION_SCHEMA.TABLES";

        using var connection = _dbContext.CreateConnection();

        var columnsData = await connection.QueryAsync<dynamic>(columnsQuery);
        var tablesData = await connection.QueryAsync<dynamic>(tablesQuery);

        var groupedColumns = columnsData
            .GroupBy(
                row => (string)row.TABLE_NAME,
                row => new Column
                {
                    Name = (string)row.COLUMN_NAME,
                    Type = row.DATA_TYPE
                });

        var tableTypeMap = tablesData
            .ToDictionary(
                row => (string)row.TABLE_NAME,
                row => (string)row.TABLE_TYPE
            );

        var tables = groupedColumns
            .Where(g => tableTypeMap.TryGetValue(g.Key, out var type) && type == "BASE TABLE")
            .Select(g => new Table
            {
                Name = g.Key,
                Columns = g.ToList()
            })
            .ToList();

        var views = groupedColumns
            .Where(g => tableTypeMap.TryGetValue(g.Key, out var type) && type == "VIEW")
            .Select(g => new Table
            {
                Name = g.Key,
                Columns = g.ToList()
            })
            .ToList();

        return new TablesStructure
        {
            Tables = tables,
            Views = views
        };
    }
}
