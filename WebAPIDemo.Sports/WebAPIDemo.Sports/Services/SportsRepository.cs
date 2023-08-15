using WebAPIDemo.Sports.Interfaces;
using WebAPIDemo.Sports.Models;

namespace WebAPIDemo.Sports.Services
{
    public class SportsRepository : ISportRepository
    {
        private List<Sport> _sports = new List<Sport>
    {
        new Sport { SportId = 1, SportName = "Football", TeamCount = 2, Description = "A team sport played with a ball" },
        new Sport { SportId = 2, SportName = "Basketball", TeamCount = 2, Description = "A sport played with a hoop and ball" },
        new Sport { SportId = 3, SportName = "Tennis", TeamCount = 1, Description = "A racket sport played on a rectangular court" },
        // Add more sample sports here
    };

        public IEnumerable<Sport> GetAllSports()
        {
            return _sports;
        }

        public Sport GetSportById(int sportId)
        {
            return _sports.FirstOrDefault(s => s.SportId == sportId);
        }

        public void UpdateTeamCount(int sportId, int newTeamCount)
        {
            Sport sportToUpdate = _sports.FirstOrDefault(s => s.SportId == sportId);
            if (sportToUpdate != null)
            {
                sportToUpdate.TeamCount = newTeamCount;
            }
        }

        public void DeleteSport(int sportId)
        {
            Sport sportToDelete = _sports.FirstOrDefault(s => s.SportId == sportId);
            if (sportToDelete != null)
            {
                _sports.Remove(sportToDelete);
            }
        }

        public IEnumerable<Sport> SearchSportsByTeamCount(int teamCount)
        {
            return _sports.Where(s => s.TeamCount == teamCount);
        }
    }

}
