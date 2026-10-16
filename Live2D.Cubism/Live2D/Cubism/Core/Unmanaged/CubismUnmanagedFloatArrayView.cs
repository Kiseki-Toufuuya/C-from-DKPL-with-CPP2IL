namespace Live2D.Cubism.Core.Unmanaged;

[DefaultMember("Item")]
public sealed class CubismUnmanagedFloatArrayView
{
	[CompilerGenerated]
	private int <Length>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private Single* <UnmanagedFixedAddress>k__BackingField; //Field offset: 0xC

	public bool IsValid
	{
		 get { } //Length: 25
	}

	public float Item
	{
		 get { } //Length: 17
		 set { } //Length: 24
	}

	public private int Length
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private Single* UnmanagedFixedAddress
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public CubismUnmanagedFloatArrayView(Single* address, int length) { }

	public CubismUnmanagedFloatArrayView(IntPtr address, int length) { }

	public bool get_IsValid() { }

	public float get_Item(int index) { }

	[CompilerGenerated]
	public int get_Length() { }

	[CompilerGenerated]
	private Single* get_UnmanagedFixedAddress() { }

	public void Read(Single[] buffer) { }

	public void set_Item(int index, float value) { }

	[CompilerGenerated]
	private void set_Length(int value) { }

	[CompilerGenerated]
	private void set_UnmanagedFixedAddress(Single* value) { }

	public void Write(Single[] buffer) { }

}

