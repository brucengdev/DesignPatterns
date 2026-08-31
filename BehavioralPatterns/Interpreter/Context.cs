namespace Interpreter;

public class Context
{
    private readonly Dictionary<string, bool> _vars = new();
    public void Assign(string varName, bool value)
    {
        _vars[varName] = value;
    }

    public bool GetValue(string name)
    {
        if (_vars.TryGetValue(name, out bool value))
        {
            return value;
        }
        throw new ArgumentException("Could not find variable: " + name);
    }
}