namespace Fiap.FourGrams.Lib.Core.Messages;

public abstract class Event : Message
{
    public DateTime Timestamp { get; private set; }

    protected Event()
    {
        Timestamp = DateTime.Now;
    }
}
