namespace TaskManagementApp.Domain.Entities;
internal class User
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Password { get; set; } = null!;
}
