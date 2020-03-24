using System;
using System.Web.Mvc;

namespace WebApplication3.Controllers
{
    public class JasmineController : Controller
    {
        public ViewResult Run()
        {
            return sView("SpecRunner");
        }
    }
}
