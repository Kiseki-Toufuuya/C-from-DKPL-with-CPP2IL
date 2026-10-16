namespace D4L.DomainEvents;

public class CallbackContainer : ICallbackContainer
{
	private class Disposer : IDisposable
	{
		private IList<Delegate> callbacks; //Field offset: 0x8
		private Delegate callback; //Field offset: 0xC

		public Disposer(IList<Delegate> callbacks, Delegate callback) { }

		public override void Dispose() { }

	}

	private Dictionary<Type, IList`1<Delegate>> callbacks; //Field offset: 0x8

	public CallbackContainer() { }

	public override IDisposable Add(Delegate callback) { }

	public override IEnumerable<Action`1<TEvent>> Callbacks() { }

}

