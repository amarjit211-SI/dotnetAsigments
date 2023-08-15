using WebAPIDemo.Sports.Models;

namespace WebAPIDemo.Sports.Interfaces
{
    public interface ISportRepository
    {
        IEnumerable<Sport> GetAllSports();
        Sport GetSportById(int sportId);
        void UpdateTeamCount(int sportId, int newTeamCount);
        void DeleteSport(int sportId);
        IEnumerable<Sport> SearchSportsByTeamCount(int teamCount);
    }
}
