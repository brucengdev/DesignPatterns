namespace Builder.Models;

public enum InvestmentCategory
{
    Gold,
    Stocks,
    RealEstate
}

public class Investment: Entry
{
    public InvestmentCategory Category {get; set;}
    public float Amount { get; set; }
}