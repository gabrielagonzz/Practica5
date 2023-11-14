namespace Practica5.Models
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool Assigned { get; set; }
        public int AssignedUserId { get; set; }
        public List<int> Followers { get; set; } = new List<int>();

    }
}
