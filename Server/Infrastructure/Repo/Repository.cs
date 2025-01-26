﻿using Dapper;
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
        const string tableQuery = @"
            SELECT TABLE_NAME
            FROM INFORMATION_SCHEMA.TABLES
            WHERE TABLE_TYPE = 'BASE TABLE'";

        const string viewQuery = @"
            SELECT TABLE_NAME
            FROM INFORMATION_SCHEMA.VIEWS";

        using var connection = _dbContext.CreateConnection();

        var tables = connection.QueryAsync<string>(tableQuery);
        var views = connection.QueryAsync<string>(viewQuery);

        await Task.WhenAll(tables, views);

        return new DatabaseStructure
        {
            TableList = tables.Result.ToList(),
            ViewList = views.Result.ToList()
        };
    }

    public async Task<IEnumerable<Table>> GetTablesStructureAsync()
    {
        const string columnsQuery = @"
            SELECT TABLE_NAME, COLUMN_NAME, DATA_TYPE, IS_NULLABLE
            FROM INFORMATION_SCHEMA.COLUMNS";

        using var connection = _dbContext.CreateConnection();

        var columnsData = await connection.QueryAsync<dynamic>(columnsQuery);

        var groupedColumns = columnsData
            .GroupBy(
                row => (string)row.TABLE_NAME,
                row => new Column
                {
                    Name = (string)row.COLUMN_NAME,
                    Properties = new List<string>
                    {
                        $"DataType: {row.DATA_TYPE}",
                        $"IsNullable: {row.IS_NULLABLE}"
                    }
                });

        return groupedColumns.Select(g => new Table
        {
            Name = g.Key,
            Columns = g.ToList()
        });
    }
}
