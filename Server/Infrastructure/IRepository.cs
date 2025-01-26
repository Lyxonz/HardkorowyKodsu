using Shared.Models;

namespace Infrastructure;

public interface IRepository
{
    Task<DatabaseStructure> GetDatabaseStructureAsync();
    Task<IEnumerable<Table>> GetTablesStructureAsync();
}
