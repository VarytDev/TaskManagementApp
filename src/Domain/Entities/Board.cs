namespace TaskManagementApp.Domain.Entities;
internal class Board
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public ICollection<TaskList> TaskLists { get; set; } = new List<TaskList>();
}
