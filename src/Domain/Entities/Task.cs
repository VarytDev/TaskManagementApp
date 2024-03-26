namespace TaskManagementApp.Domain.Entities;
internal class Task
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Description { get; set; } = null!;
    public int TaskListId { get; set; }
    public TaskList List { get; set; } = null!;
}
