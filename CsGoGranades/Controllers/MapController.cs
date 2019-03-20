using System.Linq;
using CsGoGranades.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace CsGoGranades.Controllers
{
    public class MapController : Controller
    {
        private readonly DatabaseContext _context;

        public MapController(DatabaseContext context)
        {
            _context = context;
        }

        [Route("Map/{name}")]
        [Route("Map/Index/{name}")]
        public IActionResult Index(string name)
        {
            var map = _context.Maps.Include(x => x.GranadeSpots).FirstOrDefault(x => x.Name.Equals(name));
            if (map == null)
            {
                return BadRequest();
            }
            return View(map);
        }
    }
}