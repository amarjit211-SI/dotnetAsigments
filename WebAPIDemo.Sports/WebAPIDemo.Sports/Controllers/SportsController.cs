using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebAPIDemo.Sports.Interfaces;
using WebAPIDemo.Sports.Models;

namespace WebAPIDemo.Sports.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SportsController : ControllerBase
    {
        private readonly ISportRepository _sportRepository;

        public SportsController(ISportRepository sportRepository)
        {
            _sportRepository = sportRepository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Sport>> GetAllSports()
        {
            var sports = _sportRepository.GetAllSports();
            return Ok(sports);
        }

        [HttpGet("{id}")]
        public ActionResult<Sport> GetSportById(int id)
        {
            var sport = _sportRepository.GetSportById(id);
            if (sport == null)
            {
                return NotFound();
            }
            return Ok(sport);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateTeamCount(int id, [FromBody] int newTeamCount)
        {
            _sportRepository.UpdateTeamCount(id, newTeamCount);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSport(int id)
        {
            _sportRepository.DeleteSport(id);
            return NoContent();
        }

        [HttpGet("search/{teamCount}")]
        public ActionResult<IEnumerable<Sport>> SearchSportsByTeamCount(int teamCount)
        {
            var sports = _sportRepository.SearchSportsByTeamCount(teamCount);
            return Ok(sports);
        }
    }

}
