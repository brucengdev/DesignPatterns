namespace Bridge.Models;

public enum IncomeCategory
{
    Salary,
    Gift,
    Business,
    Divident
}
public class Income
{
    public float Amount {get; set;}
    public IncomeCategory Category {get; set;} = IncomeCategory.Salary;
}