namespace Live2D.Cubism.Core.Unmanaged;

[DefaultMember("Item")]
public sealed class CubismUnmanagedUshortArrayView
{
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private UInt16* <UnmanagedFixedAddress>k__BackingField; //Field offset: 0xC

	public bool IsValid
	{
		 get { } //Length: 25
	}

	public ushort Item
	{
		 get { } //Length: 18
		 set { } //Length: 22
	}

	public private int Length
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private UInt16* UnmanagedFixedAddress
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CubismUnmanagedUshortArrayView(UInt16* address, int length) { }

	public CubismUnmanagedUshortArrayView(IntPtr address, int length) { }

	public bool get_IsValid() { }

	public ushort get_Item(int index) { }

	[CompilerGenerated]
	public int get_Length() { }

	[CompilerGenerated]
	private UInt16* get_UnmanagedFixedAddress() { }

	public void Read(UInt16[] buffer) { }

	public void set_Item(int index, ushort value) { }

	[CompilerGenerated]
	private void set_Length(int value) { }

	[CompilerGenerated]
	private void set_UnmanagedFixedAddress(UInt16* value) { }

	public void Write(UInt16[] buffer) { }

}

