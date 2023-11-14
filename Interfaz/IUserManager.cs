using Practica5.Models;

namespace Practica5.Interfaz
{
    public interface IUserManager
    {
        List<User> GetAllUsers();
        List<User> SearchUsers(string keyword);
        void FollowTask(int userId, int taskId);
        void UnfollowTask(int userId, int taskId);
    }
}
