namespace UnityEngine.UIElements;

internal class EventCallbackListPool
{
	private readonly Stack<EventCallbackList> m_Stack; //Field offset: 0x8

	public EventCallbackListPool() { }

	public EventCallbackList Get(EventCallbackList initializer) { }

	public void Release(EventCallbackList element) { }

}

