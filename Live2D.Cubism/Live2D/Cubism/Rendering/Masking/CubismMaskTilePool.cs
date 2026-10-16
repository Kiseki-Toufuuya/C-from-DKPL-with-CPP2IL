namespace Live2D.Cubism.Rendering.Masking;

internal sealed class CubismMaskTilePool
{
	private struct LayoutContext
	{
		public int RenderTextureIndex; //Field offset: 0x0
		public int Channel; //Field offset: 0x4
		public int LayoutCount; //Field offset: 0x8
		public int LayoutContextIndex; //Field offset: 0xC

	}

	private readonly int ClippingMaskMaxCountOnDefault; //Field offset: 0x8
	private readonly int ClippingMaskMaxCountOnMultiRenderTexture; //Field offset: 0xC
	[CompilerGenerated]
	private int <Subdivisions>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Boolean[] <Slots>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private int <RenderTextureCount>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <IsUsingHighPrecisionMask>k__BackingField; //Field offset: 0x1C
	[CompilerGenerated]
	private int <UseClippingMaskMaxCount>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private int <ColorChannelCount>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private int <UsedMaskCount>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private LayoutContext[] <LayoutContexts>k__BackingField; //Field offset: 0x2C
	private LayoutContext[] _headOfChannels; //Field offset: 0x30

	private int ColorChannelCount
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private LayoutContext[] HeadOfChannels
	{
		private get { } //Length: 11
		private set { } //Length: 27
	}

	private bool IsUsingHighPrecisionMask
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private LayoutContext[] LayoutContexts
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private int RenderTextureCount
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private Boolean[] Slots
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private int Subdivisions
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private int UseClippingMaskMaxCount
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public int UsedMaskCount
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public CubismMaskTilePool(int subdivisions, int channels, int renderTextureCount = -1) { }

	public CubismMaskTile[] AcquireTiles(int count) { }

	[CompilerGenerated]
	private int get_ColorChannelCount() { }

	private LayoutContext[] get_HeadOfChannels() { }

	[CompilerGenerated]
	private bool get_IsUsingHighPrecisionMask() { }

	[CompilerGenerated]
	private LayoutContext[] get_LayoutContexts() { }

	[CompilerGenerated]
	private int get_RenderTextureCount() { }

	[CompilerGenerated]
	private Boolean[] get_Slots() { }

	[CompilerGenerated]
	private int get_Subdivisions() { }

	[CompilerGenerated]
	private int get_UseClippingMaskMaxCount() { }

	[CompilerGenerated]
	public int get_UsedMaskCount() { }

	public void ResetTiles() { }

	[Obsolete("ReturnTiles() is not used.", False)]
	public void ReturnTiles(CubismMaskTile[] tiles) { }

	[CompilerGenerated]
	private void set_ColorChannelCount(int value) { }

	private void set_HeadOfChannels(LayoutContext[] value) { }

	[CompilerGenerated]
	private void set_IsUsingHighPrecisionMask(bool value) { }

	[CompilerGenerated]
	private void set_LayoutContexts(LayoutContext[] value) { }

	[CompilerGenerated]
	private void set_RenderTextureCount(int value) { }

	[CompilerGenerated]
	private void set_Slots(Boolean[] value) { }

	[CompilerGenerated]
	private void set_Subdivisions(int value) { }

	[CompilerGenerated]
	private void set_UseClippingMaskMaxCount(int value) { }

	[CompilerGenerated]
	public void set_UsedMaskCount(int value) { }

	[Obsolete("ToIndex() is not used.", False)]
	private int ToIndex(CubismMaskTile tile) { }

	private CubismMaskTile ToTile(int index) { }

}

