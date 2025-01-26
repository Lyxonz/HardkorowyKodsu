using Shared.Models;

namespace Infrastructure.Repo;

public interface IRepository
{
    Task<DatabaseStructure> GetDatabaseStructureAsync();
    Task<IEnumerable<Table>> GetTablesStructureAsync();
}
