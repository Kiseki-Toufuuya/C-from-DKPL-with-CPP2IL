namespace Live2D.Cubism.Core.Unmanaged;

public sealed class CubismUnmanagedMoc
{
	[CompilerGenerated]
	private IntPtr <Ptr>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private uint <MocVersion>k__BackingField; //Field offset: 0xC

	public private uint MocVersion
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private IntPtr Ptr
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private CubismUnmanagedMoc(Byte[] bytes) { }

	public static CubismUnmanagedMoc FromBytes(Byte[] bytes) { }

	[CompilerGenerated]
	public uint get_MocVersion() { }

	[CompilerGenerated]
	public IntPtr get_Ptr() { }

	public static bool HasMocConsistency(Byte[] bytes) { }

	public void Release() { }

	[CompilerGenerated]
	private void set_MocVersion(uint value) { }

	[CompilerGenerated]
	private void set_Ptr(IntPtr value) { }

}

