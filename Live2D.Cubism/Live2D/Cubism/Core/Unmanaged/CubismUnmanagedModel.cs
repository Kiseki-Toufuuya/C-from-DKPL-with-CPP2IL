namespace Live2D.Cubism.Core.Unmanaged;

public sealed class CubismUnmanagedModel
{
	[CompilerGenerated]
	private CubismUnmanagedParameters <Parameters>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private CubismUnmanagedParts <Parts>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private CubismUnmanagedDrawables <Drawables>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private CubismUnmanagedCanvasInformation <CanvasInformation>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private IntPtr <Ptr>k__BackingField; //Field offset: 0x18

	public private CubismUnmanagedCanvasInformation CanvasInformation
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private CubismUnmanagedDrawables Drawables
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private CubismUnmanagedParameters Parameters
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private CubismUnmanagedParts Parts
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private IntPtr Ptr
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private CubismUnmanagedModel(CubismUnmanagedMoc moc) { }

	public static CubismUnmanagedModel FromMoc(CubismUnmanagedMoc moc) { }

	[CompilerGenerated]
	public CubismUnmanagedCanvasInformation get_CanvasInformation() { }

	[CompilerGenerated]
	public CubismUnmanagedDrawables get_Drawables() { }

	[CompilerGenerated]
	public CubismUnmanagedParameters get_Parameters() { }

	[CompilerGenerated]
	public CubismUnmanagedParts get_Parts() { }

	[CompilerGenerated]
	public IntPtr get_Ptr() { }

	public void Release() { }

	[CompilerGenerated]
	private void set_CanvasInformation(CubismUnmanagedCanvasInformation value) { }

	[CompilerGenerated]
	private void set_Drawables(CubismUnmanagedDrawables value) { }

	[CompilerGenerated]
	private void set_Parameters(CubismUnmanagedParameters value) { }

	[CompilerGenerated]
	private void set_Parts(CubismUnmanagedParts value) { }

	[CompilerGenerated]
	private void set_Ptr(IntPtr value) { }

	public void Update() { }

}

