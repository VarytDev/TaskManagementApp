namespace TaskManagementApp.Domain.Entities;
internal class TaskList
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public int BoardId { get; set; }
    public Board Board { get; set; } = null!;
    public ICollection<Task> Tasks { get; set; } = null!;
}
