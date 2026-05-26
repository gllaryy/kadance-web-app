using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using KAdanceAPI.data;
using KAdanceAPI.models;

namespace KAdanceAPI.controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly AppDbContext _db;

        public RegistrationController(AppDbContext db)
        {
            _db = db;
        }

        [HttpPost]
        public async Task<IActionResult> Register([FromBody] RegistrationRequest request)
        {
            if (string.IsNullOrWhiteSpace(request.Name) || string.IsNullOrWhiteSpace(request.Surname))
                return BadRequest("Ім'я та прізвище обов'язкові");

            if (request.ClassIds == null || request.ClassIds.Count == 0)
                return BadRequest("Оберіть хоча б одне заняття");

            var existingClient = await _db.Clients
                .FirstOrDefaultAsync(c => c.Name == request.Name && c.Surname == request.Surname);

            if (existingClient != null)
            {
                var existingIds = await _db.Registrations
                    .Where(r => r.ClientId == existingClient.Id)
                    .Select(r => r.DanceClassId)
                    .ToListAsync();

                var duplicates = request.ClassIds.Intersect(existingIds).ToList();

                if (duplicates.Count > 0)
                    return BadRequest("Ви вже записані на деякі з обраних занять");

                
                foreach (var classId in request.ClassIds)
                {
                    var exists = await _db.DanceClasses.AnyAsync(c => c.Id == classId);
                    if (!exists) continue;

                    _db.Registrations.Add(new Registration
                    {
                        ClientId = existingClient.Id,
                        DanceClassId = classId
                    });
                }
                await _db.SaveChangesAsync();
                return Ok(new { message = "Запис успішний!", clientId = existingClient.Id });
            }

            var client = new Client { Name = request.Name, Surname = request.Surname, Phone = request.Phone };
            _db.Clients.Add(client);
            await _db.SaveChangesAsync();

            foreach (var classId in request.ClassIds)
            {
                var exists = await _db.DanceClasses.AnyAsync(c => c.Id == classId);
                if (!exists) continue;

                _db.Registrations.Add(new Registration
                {
                    ClientId = client.Id,
                    DanceClassId = classId
                });
            }
            await _db.SaveChangesAsync();

            return Ok(new { message = "Запис успішний!", clientId = client.Id });
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var registrations = await _db.Registrations
                .Include(r => r.Client)
                .Include(r => r.DanceClass)
                .Select(r => new {
                    r.Id,
                    ClientName = r.Client.Name + " " + r.Client.Surname,
                    Phone = r.Client.Phone,
                    Class = r.DanceClass.Name,
                    Day = r.DanceClass.DayOfWeek,
                    Time = r.DanceClass.TimeStart + " - " + r.DanceClass.TimeEnd,
                    Trainer = r.DanceClass.Trainer,
                    r.CreatedAt
                })
                .ToListAsync();

            return Ok(registrations);
        }

        [HttpGet("classes")]
        public async Task<IActionResult> GetClasses()
        {
            var classes = await _db.DanceClasses
                .OrderBy(c => c.Id)
                .ToListAsync();
            return Ok(classes);
        }
    }

    public class RegistrationRequest
    {
        public string Name { get; set; } = string.Empty;
        public string Surname { get; set; } = string.Empty;
        public string Phone { get; set; } = string.Empty;   
        public List<int> ClassIds { get; set; } = new();
    }
}
