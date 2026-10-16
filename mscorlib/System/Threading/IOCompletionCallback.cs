namespace System.Threading;

[CLSCompliant(False)]
[ComVisible(True)]
public sealed class IOCompletionCallback : MulticastDelegate
{

	public IOCompletionCallback(object object, IntPtr method) { }

	public override void Invoke(uint errorCode, uint numBytes, NativeOverlapped* pOVERLAP) { }

}

