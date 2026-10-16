namespace System.Threading;

[ComVisible(True)]
public class Overlapped
{
	private int offsetL; //Field offset: 0x8
	private int offsetH; //Field offset: 0xC
	private IntPtr evt_ptr; //Field offset: 0x10

	public Overlapped() { }

	[CLSCompliant(False)]
	public static void Free(NativeOverlapped* nativeOverlappedPtr) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	[MonoTODO("handle userData")]
	public NativeOverlapped* Pack(IOCompletionCallback iocb, object userData) { }

	[CLSCompliant(False)]
	[ComVisible(False)]
	public NativeOverlapped* UnsafePack(IOCompletionCallback iocb, object userData) { }

}

