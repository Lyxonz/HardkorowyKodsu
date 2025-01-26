using Shared.Models;

namespace ApplicationLayer;

public class DatabaseStructureService : IDatabaseStructureService
{
    public Task<DatabaseStructure> GetDatabaseStructureAsync()
    {
        throw new NotImplementedException();
    }

    public Task<TablesStructure> GetTablesStructureAsync()
    {
        throw new NotImplementedException();
    }
}
