using Shared.Models;

namespace ApplicationLayer;

public interface IDatabaseStructureService
{
    Task<DatabaseStructure> GetDatabaseStructureAsync();
    Task<TablesStructure> GetTablesStructureAsync();
}
