using System.Text;

namespace StatePattern;

public abstract class NetworkState
{
    public virtual void Open(NetworkConnection networkConnection)
    {
    }

    public virtual void Send(NetworkConnection conn, string data)
    {
    }

    public virtual void Close(NetworkConnection networkConnection)
    {
    }
}