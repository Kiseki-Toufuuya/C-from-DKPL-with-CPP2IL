namespace FlatBuffers;

public abstract class ByteBufferAllocator
{
	[CompilerGenerated]
	private Byte[] <Buffer>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0xC

	public Byte[] Buffer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int Length
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	protected ByteBufferAllocator() { }

	[CompilerGenerated]
	public Byte[] get_Buffer() { }

	[CompilerGenerated]
	public int get_Length() { }

	public abstract void GrowFront(int newSize) { }

	[CompilerGenerated]
	protected void set_Buffer(Byte[] value) { }

	[CompilerGenerated]
	protected void set_Length(int value) { }

}

