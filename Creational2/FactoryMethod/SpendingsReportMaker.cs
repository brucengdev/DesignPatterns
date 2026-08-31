namespace FactoryMethod;
public abstract class SpendingsReportMaker
{
    public void WriteReport(List<Spending> spendings)
    {
        var writer = CreateWriter();
        var spendingsByCategory = new Dictionary<string, float>();
        foreach(var spending in spendings)
        {
            if(!spendingsByCategory.TryGetValue(spending.Category, out var catSpendings))
            {
                spendingsByCategory[spending.Category] = 0;
            }
            spendingsByCategory[spending.Category] = catSpendings + spending.Amount;
        }
        float total = 0;
        foreach(var category in spendingsByCategory.Keys)
        {
            var categorySpendings = spendingsByCategory[category];
            total += spendingsByCategory[category];
            writer.Write($"{category}: {categorySpendings}{Environment.NewLine}");
        }
        writer.Write($"Total: {total}");
    }

    protected abstract IWriter CreateWriter();
}