namespace System.Threading;

[ComVisible(True)]
public sealed class RegisteredWaitHandle : MarshalByRefObject
{
	private WaitHandle _waitObject; //Field offset: 0xC
	private WaitOrTimerCallback _callback; //Field offset: 0x10
	private object _state; //Field offset: 0x14
	private WaitHandle _finalEvent; //Field offset: 0x18
	private ManualResetEvent _cancelEvent; //Field offset: 0x1C
	private TimeSpan _timeout; //Field offset: 0x20
	private int _callsInProcess; //Field offset: 0x28
	private bool _executeOnlyOnce; //Field offset: 0x2C
	private bool _unregistered; //Field offset: 0x2D

	internal RegisteredWaitHandle(WaitHandle waitObject, WaitOrTimerCallback callback, object state, TimeSpan timeout, bool executeOnlyOnce) { }

	private void DoCallBack(object timedOut) { }

	[ComVisible(True)]
	public bool Unregister(WaitHandle waitObject) { }

	internal void Wait(object state) { }

}

