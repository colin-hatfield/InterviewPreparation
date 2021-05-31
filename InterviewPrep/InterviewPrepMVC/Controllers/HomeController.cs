using InterviewPrepMVC.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace InterviewPrepMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        
        [HttpPost]
        public ActionResult ProcessForm(IFormCollection fc)
        {
            ViewBag.LongestUniqueStringLength = LongestNonRepeatingString(fc["longestStringLength"].ToString());
            return View("Index");
        }

        public static int LongestNonRepeatingString(string str)
        {
            Dictionary<char, int> cd = new Dictionary<char, int>();
            char[] ca = str.ToCharArray();
            int longest = 0;
            for (int i=0; i<ca.Length; i++)
            {
                if (cd.ContainsKey(ca[i]))
                {
                    int distance = (i - cd[ca[i]]);
                    if (distance > longest)
                    {
                        longest = distance;
                    }
                }
                cd[ca[i]] = i;
            }
            return longest;
        }
    }
}
