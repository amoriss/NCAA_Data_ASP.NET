using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using NCAA_Data;

namespace NCAA_Data_ASP.NET.Controllers
{
    public class PlayerController : Controller
    {
        // GET: /<controller>/
        public async Task<IActionResult> Index(Base someBase)
        {
            //PlayerStatistics playerStatistics = new PlayerStatistics();
            var apiCall = await PlayerStats.GetPlayerStats(someBase.Year, someBase.Conference, someBase.Season, someBase.StatCat);

            return View(apiCall);
        }
    }
}

