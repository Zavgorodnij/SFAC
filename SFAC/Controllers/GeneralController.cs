using Microsoft.AspNetCore.Mvc;
using SFAC.Models.Core;
using SFAC.Models.Room;
using Microsoft.EntityFrameworkCore;

namespace SFAC.Controllers
{
    public class GeneralController : Controller
    {
        public readonly LiteContext _context;
        public GeneralController(LiteContext context) 
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> Event(Guid ID)
        {
            var check_room = await _context.room_Models.Select(ps => ps.id).FirstOrDefaultAsync(p => p == ID);
            return View();
        }

        public async Task<IActionResult> Create_Room()
        {
            var New_Room = new Room_Model();
            await _context.AddAsync(New_Room);
            return RedirectToAction(nameof(Event),new {ID = New_Room.id });
        }

        public async Task<IActionResult> Policy()
        {
            return View();
        }

        public async Task<IActionResult> Connect_Room(int Code)
        {
            return View();
        }
    }
}
