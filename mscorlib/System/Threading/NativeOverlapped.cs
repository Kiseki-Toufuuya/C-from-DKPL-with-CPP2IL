namespace System.Threading;

public struct NativeOverlapped
{
	public IntPtr InternalLow; //Field offset: 0x0
	public IntPtr InternalHigh; //Field offset: 0x4
	public int OffsetLow; //Field offset: 0x8
	public int OffsetHigh; //Field offset: 0xC
	public IntPtr EventHandle; //Field offset: 0x10

}

