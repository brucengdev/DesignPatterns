namespace Flyweight;

public class CharacterFactory
{
    private Dictionary<char, Character> Flyweights;

    public CharacterFactory()
    {
        Flyweights = new();
        Flyweights['A'] = new CharacterA();
        Flyweights['B'] = new CharacterB();
        Flyweights['C'] = new CharacterC();
        Flyweights['D'] = new CharacterD();
    }
    
    public Character GetCharacter(char ch)
    {
        return Flyweights[ch];
    }
}