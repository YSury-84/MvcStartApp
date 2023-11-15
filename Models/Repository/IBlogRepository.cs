using MvcStartApp.Models.Db;
using System.Threading.Tasks;

namespace MvcStartApp.Models.Repository
{
    public interface IBlogRepository
    {
        Task AddUser(User user);
    }

}
