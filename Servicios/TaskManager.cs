using Practica5.Interfaz;

namespace Practica5.Servicios
{
    public class TaskManager : ITaskManager
    {
        private readonly ITaskRepository taskRepository;
        private readonly List<IObserver<Models.Task>> observers = new List<IObserver<Models.Task>>();

        public TaskManager(ITaskRepository taskRepository)
        {
            this.taskRepository = taskRepository;
        }

        public IDisposable Subscribe(IObserver<Models.Task> observer)
        {
            if (!observers.Contains(observer))
            {
                observers.Add(observer);
            }
            return new Unsubscribed(observers, observer);
        }

        Models.Task ITaskManager.CreateTask(string title, string description)
        {
            var newTask = new Models.Task
            {
                Id = taskRepository.GetNextTaskId(),
                Title = title,
                Description = description
            };

            taskRepository.SaveTask(newTask);

            NotifyObservers(newTask);

            return newTask;
        }

        public void EditTask(int taskId, string title, string description)
        {
            var task = taskRepository.GetTask(taskId);

            if (task != null)
            {
                task.Title = title;
                task.Description = description;

                taskRepository.SaveTask(task);
                NotifyObservers(task);
            }
        }

        public void DeleteTask(int taskId)
        {
            var task = taskRepository.GetTask(taskId);

            if (task != null)
            {
                taskRepository.DeleteTask(task);
                NotifyObservers(task);
            }
        }

        List<Models.Task> ITaskManager.GetAllTasks()
        {
            return taskRepository.GetAllTasks();
        }

        List<Models.Task> ITaskManager.SearchTasks(string keyword)
        {
            return taskRepository.SearchTasks(keyword);
        }

        public void AssignTask(int taskId, int userId)
        {
            var task = taskRepository.GetTask(taskId);

            if (task != null && !task.Assigned)
            {
                task.Assigned = true;
                task.AssignedUserId = userId;

                taskRepository.SaveTask(task);
                NotifyObservers(task);
            }
        }

        private void NotifyObservers(Models.Task task)
        {
            foreach (var observer in observers)
            {
                observer.OnNext(task);
            }
        }
    }
}
