namespace Live2D.Cubism.Core;

public sealed class CubismDynamicDrawableData
{
	[CompilerGenerated]
	private byte <Flags>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private float <Opacity>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private int <DrawOrder>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <RenderOrder>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private Vector3[] <VertexPositions>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private Color <MultiplyColor>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private Color <ScreenColor>k__BackingField; //Field offset: 0x2C

	public bool AreVertexPositionsDirty
	{
		 get { } //Length: 27
	}

	public internal int DrawOrder
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	internal byte Flags
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public bool IsAnyDirty
	{
		 get { } //Length: 15
	}

	public bool IsBlendColorDirty
	{
		 get { } //Length: 27
	}

	public bool IsDrawOrderDirty
	{
		 get { } //Length: 27
	}

	public bool IsOpacityDirty
	{
		 get { } //Length: 27
	}

	public bool IsRenderOrderDirty
	{
		 get { } //Length: 27
	}

	public bool IsVisibilityDirty
	{
		 get { } //Length: 27
	}

	public bool IsVisible
	{
		 get { } //Length: 27
	}

	public internal Color MultiplyColor
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		internal set { } //Length: 16
	}

	public internal float Opacity
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 18
	}

	public internal int RenderOrder
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	public internal Color ScreenColor
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		internal set { } //Length: 141
	}

	public internal Vector3[] VertexPositions
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public CubismDynamicDrawableData() { }

	internal static CubismDynamicDrawableData[] CreateData(CubismUnmanagedModel unmanagedModel) { }

	public bool get_AreVertexPositionsDirty() { }

	[CompilerGenerated]
	public int get_DrawOrder() { }

	[CompilerGenerated]
	private byte get_Flags() { }

	public bool get_IsAnyDirty() { }

	public bool get_IsBlendColorDirty() { }

	public bool get_IsDrawOrderDirty() { }

	public bool get_IsOpacityDirty() { }

	public bool get_IsRenderOrderDirty() { }

	public bool get_IsVisibilityDirty() { }

	public bool get_IsVisible() { }

	[CompilerGenerated]
	public Color get_MultiplyColor() { }

	[CompilerGenerated]
	public float get_Opacity() { }

	[CompilerGenerated]
	public int get_RenderOrder() { }

	[CompilerGenerated]
	public Color get_ScreenColor() { }

	[CompilerGenerated]
	public Vector3[] get_VertexPositions() { }

	[CompilerGenerated]
	internal void set_DrawOrder(int value) { }

	[CompilerGenerated]
	internal void set_Flags(byte value) { }

	[CompilerGenerated]
	internal void set_MultiplyColor(Color value) { }

	[CompilerGenerated]
	internal void set_Opacity(float value) { }

	[CompilerGenerated]
	internal void set_RenderOrder(int value) { }

	[CompilerGenerated]
	internal void set_ScreenColor(Color value) { }

	[CompilerGenerated]
	internal void set_VertexPositions(Vector3[] value) { }

}

