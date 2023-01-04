using WorldCupResultsWithMauiWASM.Models;

namespace WorldCupResultsWithMauiWASM.ViewModels;

public class ColectionViewGroup : List<TableItemDto>
{
    public string groupName { get; set; }
    public ColectionViewGroup(string groupName)
    {
        this.groupName = groupName;
    }
}
