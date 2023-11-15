using MvcStartApp.Models.Db;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repository
{
    public interface ILogRepository
    {
        Task AddLogs(Request request);

        Task<Request[]> GetLogs();
    }
}
