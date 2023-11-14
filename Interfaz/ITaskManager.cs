namespace Practica5.Interfaz
{
public interface ITaskManager : IObservable<Models.Task>
{
    Models.Task CreateTask(string title, string description);
    void EditTask(int taskId, string title, string description);
    void DeleteTask(int taskId);
    List<Models.Task> GetAllTasks();
    List<Models.Task> SearchTasks(string keyword);
    void AssignTask(int taskId, int userId);
}

}
