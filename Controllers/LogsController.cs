using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MvcStartApp.Models.Db;
using MvcStartApp.Models.Repository;
using MvcStartApp.Models;
using System.Diagnostics;
using System.Threading.Tasks;
using System;

namespace MvcStartApp.Controllers
{
    public class LogsController : Controller
    {
        // ссылка на репозиторий
        public readonly ILogRepository _repo;
        private readonly ILogger<LogsController> _logger;

        // Также добавим инициализацию в конструктор
        public LogsController(ILogger<LogsController> logger, ILogRepository repo)
        {
            _logger = logger;
            _repo = repo;
        }

        // Сделаем метод асинхронным
        public async Task<IActionResult> Index()
        {
            var sLogs = await _repo.GetLogs();

            return View(sLogs);
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
    }
}
