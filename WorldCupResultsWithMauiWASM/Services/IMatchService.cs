using WorldCupResultsWithMauiWASM.Models;

namespace WorldCupResultsWithMauiWASM.Services;

public interface IMatchService
{
    Task<StandingsResponseDto?> GetStandings();
    Task<MatchesResponseDto?> GetTodayMatches();
}