using System;
using System.Collections.Generic;

namespace Practica5.Data
{
    public class JsonFileRepository
    {
        private const string TasksFilePath = "tasks.json";
        private const string UsersFilePath = "users.json";

        Entities.Task ITaskRepository.GetTask(int taskId)
        {
            throw new NotImplementedException();
        }

        public void SaveTask(Entities.Task task)
        {
            throw new NotImplementedException();
        }

        public void DeleteTask(Entities.Task task)
        {
            throw new NotImplementedException();
        }

        List<Entities.Task> ITaskRepository.GetAllTasks()
        {
            throw new NotImplementedException();
        }

        List<Entities.Task> ITaskRepository.SearchTasks(string keyword)
        {
            throw new NotImplementedException();
        }
        public int GetNextTaskId()
        {
            throw new NotImplementedException();
        }

        User IUserRepository.GetUser(int userId)
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.GetAllUsers()
        {
            throw new NotImplementedException();
        }

        List<User> IUserRepository.SearchUsers(string keyword)
        {
            throw new NotImplementedException();
        }
    }
}
