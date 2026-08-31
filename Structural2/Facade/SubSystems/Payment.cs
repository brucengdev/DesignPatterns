namespace Facade;

public class Payment
{
    private List<Card> _cards = new();
    public void AddCard(Card card)
    {
        _cards.Add(card);
    }

    public Card? GetCard(string name)
    {
        return _cards.FirstOrDefault(c => c.Name == name);
    }

    public void Charge(string customer, int amount)
    {
        var card = GetCard(customer);
        if (card == null)
        {
            return;
        }

        card.Balance -= amount;
    }
}