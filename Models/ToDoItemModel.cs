namespace mvc_m1.Models;

public class ToDoItem
{
    public int Id { get; set; } 
    public string Task { get; set; } = string.Empty;
    public bool IsCompleted { get; set; }
}