namespace StatePattern;

public class IdleState: NetworkState
{
    public override void Open(NetworkConnection networkConnection)
    {
        networkConnection._outputStream.Write("Connection opened.\n"u8);
        networkConnection.ChangeState(new ConnectedState());
    }
}