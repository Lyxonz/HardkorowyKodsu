namespace Shared.Models;

public class Table
{
    public string Name { get; set; }
    public IEnumerable<Column> Columns{ get; set; }
}
