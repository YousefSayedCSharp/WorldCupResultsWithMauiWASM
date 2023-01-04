using System.Net.Http.Json;
using WorldCupResultsWithMauiWASM.Models;

namespace WorldCupResultsWithMauiWASM.Services;

public class MatchService : IMatchService
{
    private readonly HttpClient _http;
    private readonly string _baseUrl = "https://api.football-data.org/v4";

    public MatchService()
    {
        _http = new HttpClient();
        _http.DefaultRequestHeaders.Add("X-Auth-Token", "7e1f0a70c45d4247ab99c2433ae1cc05");
    }

    public async Task<StandingsResponseDto?> GetStandings()
    {
        return await _http.GetFromJsonAsync<StandingsResponseDto>($"{_baseUrl}//competitions/WC/standings");
    }

    public async Task<MatchesResponseDto?> GetTodayMatches()
    {
        try
        {
            var date = DateTime.Today.ToString("yyyy-MM-dd");
            return await _http.GetFromJsonAsync<MatchesResponseDto>($"{_baseUrl}//competitions/WC/matches?dateFrom={date}&dateTo={date}");
        }
        catch (Exception)
        {
            return null;
        }
    }
}