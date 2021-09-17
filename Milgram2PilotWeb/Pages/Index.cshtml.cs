using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milgram2PilotWeb.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly SurveyDbContext _db;

        public IndexModel(ILogger<IndexModel> logger, SurveyDbContext db)
        {
            _logger = logger;
            _db = db;
        }

        public void OnGet()
        {

        }
    }
}
