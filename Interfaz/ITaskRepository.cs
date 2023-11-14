namespace Practica5.Interfaz
{
    public interface ITaskRepository
    {
        Models.Task GetTask(int taskId);
        void SaveTask(Models.Task task);
        void DeleteTask(Models.Task task);
        List<Models.Task> GetAllTasks();
        List<Models.Task> SearchTasks(string keyword);
        int GetNextTaskId();
    }
}
