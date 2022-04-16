namespace Task_List.Models
{
    public class TaskModel
    {
        public int IdTask { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public bool IsDone { get; set; }
    }
}
