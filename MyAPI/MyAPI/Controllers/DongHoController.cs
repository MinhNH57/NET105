using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Header;
using MyAPI.Model;
using MyAPI.Repository;
using System.Security.Cryptography.X509Certificates;

namespace MyAPI.Controllers
{
    public class DongHoController : Controller
    {
        private readonly IWatchRepository _watchrepo;

        public DongHoController(IWatchRepository _repo)
        {
            _watchrepo = _repo;
        }

        [HttpGet("api/dongho")]
        public async Task<IActionResult> Index()
        {
            try
            {
                return Ok(await _watchrepo.GetAllWatchAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetByiD(Guid id)
        {
            var w = await _watchrepo.GetWatchByIdAsync(id);
            if (w == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(w);
            }
        }

        [HttpPost("Create")]
        public async Task<IActionResult> Create(WatchModel model)
        {
            var newWatch = await _watchrepo.CreateWatchAsync(model);
            return CreatedAtAction(nameof(GetByiD), new { id = newWatch.ID }, newWatch);
        }

        [HttpPut("{id}")]
        [Authorize]
        public async Task<IActionResult> Update(Guid id,WatchModel watch)
        {
            await _watchrepo.UpdateWatchAsync(id, watch);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            await _watchrepo.DeleteWatchAsync(id);
            return Ok();
        }
    }
}
