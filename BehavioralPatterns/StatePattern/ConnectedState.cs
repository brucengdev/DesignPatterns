using System.Text;

namespace StatePattern;

public class ConnectedState: NetworkState
{
    public override void Close(NetworkConnection networkConnection)
    {
        networkConnection._outputStream.Write("Closing connection.\n"u8);
        networkConnection.ChangeState(new IdleState());
    }

    public override void Send(NetworkConnection conn, string data)
    {
        var msg = $"{data} transmitted.\n";
        conn._outputStream.Write(Encoding.UTF8.GetBytes(msg));
    }
}