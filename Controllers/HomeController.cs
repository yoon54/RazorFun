using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Http;

namespace RazorFun.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        [Route("")]

        public ViewResult Home()
        {
            return View();
        }
    }
}