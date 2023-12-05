using E_Commerce_WebApi.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace E_Commerce_WebApi.UI.Controllers
{
    public class ColorController : ControllerBase
    {
        private readonly IUoWService _uoWService;

        public ColorController(IUoWService uoWService)
        {
            _uoWService = uoWService;
        }


        public async Task<IActionResult> Index()
        {
            var color = _uoWService.Colors.GetAllAsync().Result;
            return Ok();
        }
    }
}
