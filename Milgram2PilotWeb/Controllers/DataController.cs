using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milgram2PilotWeb.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;
        private readonly SurveyDbContext _db;

        public DataController(ILogger<DataController> logger, SurveyDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        [HttpGet]                   // GET /api/data/
        public JsonResult Get()
        {
            var total = _db.Responses.Count();
            return new JsonResult(new { total = total });
        }

        [HttpPost("create")]        // POST /api/data/create
        public async Task<JsonResult> PostCreateResponse([FromBody] System.Text.Json.JsonElement jsonResponse)
        {
            var record = new SurveyResponse
            {
                ResponseTime = DateTime.Now,
                ResponseJson = jsonResponse.ToString()
            };
            _db.Add(record);
            await _db.SaveChangesAsync();

            return new JsonResult(new { result = "ok" });
        }
    }
}
