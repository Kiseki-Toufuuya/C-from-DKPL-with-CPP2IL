namespace Live2D.Cubism.Core.Unmanaged;

[DefaultMember("Item")]
public sealed class CubismUnmanagedByteArrayView
{
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Byte* <UnmanagedFixedAddress>k__BackingField; //Field offset: 0xC

	public bool IsValid
	{
		 get { } //Length: 25
	}

	public byte Item
	{
		 get { } //Length: 17
		 set { } //Length: 20
	}

	public private int Length
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private Byte* UnmanagedFixedAddress
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CubismUnmanagedByteArrayView(Byte* address, int length) { }

	public CubismUnmanagedByteArrayView(IntPtr address, int length) { }

	public bool get_IsValid() { }

	public byte get_Item(int index) { }

	[CompilerGenerated]
	public int get_Length() { }

	[CompilerGenerated]
	private Byte* get_UnmanagedFixedAddress() { }

	public void Read(Byte[] buffer) { }

	public void set_Item(int index, byte value) { }

	[CompilerGenerated]
	private void set_Length(int value) { }

	[CompilerGenerated]
	private void set_UnmanagedFixedAddress(Byte* value) { }

	public void Write(Byte[] buffer) { }

}

