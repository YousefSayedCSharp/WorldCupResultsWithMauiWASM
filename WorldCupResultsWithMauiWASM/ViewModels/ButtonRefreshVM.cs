using System.Windows.Input;

namespace WorldCupResultsWithMauiWASM.ViewModels;
//Button Refresh
public partial class HomeVM
{
    public ICommand btnRefresh
    {
        get
        {
            return new Command(() =>
            {
                matches = null;
                //Group = null;
                Run();
            });
        }
    }
}
