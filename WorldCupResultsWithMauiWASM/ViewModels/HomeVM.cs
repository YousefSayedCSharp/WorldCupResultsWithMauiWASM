using WorldCupResultsWithMauiWASM.Models;

namespace WorldCupResultsWithMauiWASM.ViewModels;

public partial class HomeVM : BaseVM
{
    public HomeVM()
    {
        Run();
    }

    public async void Run()
    {
        try
        {
            var ms = await new Services.MatchService().GetTodayMatches();
            if (ms != null)
            {
                matches = ms.matches;
                if (matches.Count < 1)
                    lblMatches = "لا توجد مباريات اليوم!";
                else
                    lblMatches = "مباريات اليوم";
            }
            Group = await ShowGroup();
            await Task.Delay(20000);
            Run();
        }
        catch(Exception)
        {
            await Task.Delay(20000);
            Run();
        }
    }

    public async Task<List<ColectionViewGroup>> ShowGroup()
    {
        List<ColectionViewGroup> list = new List<ColectionViewGroup>();
        var standings = await new Services.MatchService().GetStandings();
        if (standings == null)
            return list;
        foreach (var item in standings.standings)
        {
            ColectionViewGroup h = new ColectionViewGroup(item.group);
            foreach (var i in item.table)
            {
                //string s1 = i.team.crest;
                //i.team.crest = i.team.tla +" | "+ s1;
                //txt += i.team.tla + ", ";
                h.Add(i);
            }
            list.Add(h);
        }
        return list;
    }

    private string _lblMatches;
    public string lblMatches
    {
        get { return _lblMatches; }
        set { SetValue(ref _lblMatches, value); }
    }

}
