using Practica5.Models;

namespace Practica5.Interfaz
{
    public interface ITaskObserver
    {
        void Update(Models.Task task);
    }
}
