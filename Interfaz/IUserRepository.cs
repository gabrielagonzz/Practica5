using Practica5.Models;

namespace Practica5.Interfaz
{
    public interface IUserRepository
    {
        User GetUser(int userId);
        List<User> GetAllUsers();
        List<User> SearchUsers(string keyword);
    }
}
