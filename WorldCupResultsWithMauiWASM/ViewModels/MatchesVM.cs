using WorldCupResultsWithMauiWASM.Models;

namespace WorldCupResultsWithMauiWASM.ViewModels;

public partial class HomeVM
{
    private List<MatchDto> _matches;
    public List<MatchDto> matches
    {
        get { return _matches; }
        set { SetValue(ref _matches,value); }
    }

}
