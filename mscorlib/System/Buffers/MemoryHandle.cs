namespace System.Buffers;

public struct MemoryHandle : IDisposable
{
	private Void* _pointer; //Field offset: 0x0
	private GCHandle _handle; //Field offset: 0x4
	private IPinnable _pinnable; //Field offset: 0x8

	[CLSCompliant(False)]
	public Void* Pointer
	{
		 get { } //Length: 10
	}

	[CLSCompliant(False)]
	public MemoryHandle(Void* pointer, GCHandle handle = null, IPinnable pinnable = null) { }

	public override void Dispose() { }

	public Void* get_Pointer() { }

}

