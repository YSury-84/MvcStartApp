using Microsoft.EntityFrameworkCore;
using MvcStartApp.Models.Context;
using MvcStartApp.Models.Db;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repository
{
    public class LogRepository : ILogRepository
    {
        private readonly LogContext _context;

        // Метод-конструктор для инициализации
        public LogRepository(LogContext context)
        {
            _context = context;
        }

        public async Task AddLogs(Request request)
        {
            // Добавление пользователя
            var entry = _context.Entry(request);
            if (entry.State == EntityState.Detached)
                await _context.Requests.AddAsync(request);

            // Сохранение изенений
            await _context.SaveChangesAsync();
        }

        public async Task<Request[]> GetLogs()
        {
            return await _context.Requests.ToArrayAsync();
        }

    }
}
