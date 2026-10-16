namespace Live2D.Cubism.Core.Unmanaged;

[DefaultMember("Item")]
public sealed class CubismUnmanagedIntArrayView
{
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Int32* <UnmanagedFixedAddress>k__BackingField; //Field offset: 0xC

	public bool IsValid
	{
		 get { } //Length: 25
	}

	public int Item
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

	private Int32* UnmanagedFixedAddress
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CubismUnmanagedIntArrayView(Int32* address, int length) { }

	public CubismUnmanagedIntArrayView(IntPtr address, int length) { }

	public bool get_IsValid() { }

	public int get_Item(int index) { }

	[CompilerGenerated]
	public int get_Length() { }

	[CompilerGenerated]
	private Int32* get_UnmanagedFixedAddress() { }

	public void Read(Int32[] buffer) { }

	public void set_Item(int index, int value) { }

	[CompilerGenerated]
	private void set_Length(int value) { }

	[CompilerGenerated]
	private void set_UnmanagedFixedAddress(Int32* value) { }

	public void Write(Int32[] buffer) { }

}

