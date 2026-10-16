namespace D4L.DomainEvents;

public interface ICallbackContainer
{

	public IDisposable Add(Delegate callback) { }

	public IEnumerable<Action`1<TEvent>> Callbacks() { }

}

