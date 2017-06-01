using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace vssummit2017_api_02
{
    public class HomeController : Controller
    {
        [HttpGet("api/")]
        public IActionResult Get()
        {
            var result = new List<Presentations>();
            result.Add(new Presentations { Title = "Micro Serviços", Date = DateTime.Now });
            result.Add(new Presentations { Title = "Cloud Computing", Date = DateTime.Now });
            result.Add(new Presentations { Title = "Excel Avançado", Date = DateTime.Now });
            return Ok(result);
        }
    }

    public class Presentations
    {
        public string Title { get; set; }
        public DateTime Date { get; set; }
    }
}