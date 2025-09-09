namespace StatePattern;

public class NetworkConnection
{
    private NetworkState _state = new IdleState();
    public Stream _outputStream;

    public NetworkConnection(Stream outputStream)
    {
        _outputStream = outputStream;
    }

    public void Open()
    {
        _state.Open(this);
    }

    public void Close()
    {
        _state.Close(this);
    }

    public void Send(string data)
    {
        _state.Send(this, data);
    }

    public void ChangeState(NetworkState newState)
    {
        _state = newState;
    }
}