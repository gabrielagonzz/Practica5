using Practica5.Interfaz;
using Practica5.Models;

namespace Practica5.Servicios
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository userRepository;
        private readonly ITaskRepository taskRepository;

        public UserManager(IUserRepository userRepository, ITaskRepository taskRepository)
        {
            this.userRepository = userRepository;
            this.taskRepository = taskRepository;
        }

        public List<User> GetAllUsers()
        {
            return userRepository.GetAllUsers();
        }

        public List<User> SearchUsers(string keyword)
        {
            return userRepository.SearchUsers(keyword);
        }

        public void FollowTask(int userId, int taskId)
        {
            var user = userRepository.GetUser(userId);
            var task = taskRepository.GetTask(taskId);

            if (user != null && task != null && !task.Followers.Contains(userId))
            {
                task.Followers.Add(userId);
                taskRepository.SaveTask(task);
            }
        }

        public void UnfollowTask(int userId, int taskId)
        {
            var task = taskRepository.GetTask(taskId);

            if (task != null && task.Followers.Contains(userId))
            {
                task.Followers.Remove(userId);
                taskRepository.SaveTask(task);
            }
        }
    }
}
