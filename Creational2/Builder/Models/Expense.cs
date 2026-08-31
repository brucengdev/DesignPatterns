namespace Builder.Models;

public class Expense: Entry
{
    public string Description { get; set; } = "";
    public float Amount {get; set;}
}