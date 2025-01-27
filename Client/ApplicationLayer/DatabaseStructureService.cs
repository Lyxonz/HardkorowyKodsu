using Newtonsoft.Json;
using Shared.Models;

namespace ApplicationLayer;

public class DatabaseStructureService : IDatabaseStructureService
{
    private static string _baseAdress = "https://localhost:7059/";
    private readonly HttpClient _httpClient;

    public DatabaseStructureService()
    {
        _httpClient = new HttpClient { BaseAddress = new Uri(_baseAdress) };
    }

    public async Task<DatabaseStructure> GetDatabaseStructureAsync()
    {
        var response = await _httpClient.GetStringAsync("api/database/structure");
        return JsonConvert.DeserializeObject<DatabaseStructure>(response);
    }

    public async Task<TablesStructure> GetTablesStructureAsync()
    {
        var response = await _httpClient.GetStringAsync("api/database/tables");
        return JsonConvert.DeserializeObject<TablesStructure>(response);
    }
}
