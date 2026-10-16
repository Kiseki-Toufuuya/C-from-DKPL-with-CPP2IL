namespace Live2D.Cubism.Rendering.Masking;

internal sealed class CubismMaskMaskedJunction
{
	[CompilerGenerated]
	private static CubismMaskProperties <SharedMaskProperties>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private CubismMaskRenderer[] <Masks>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private CubismRenderer[] <Maskeds>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private CubismMaskTexture <MaskTexture>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private CubismMaskTile <MaskTile>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private CubismMaskTransform <MaskTransform>k__BackingField; //Field offset: 0x30

	private CubismRenderer[] Maskeds
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismMaskRenderer[] Masks
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismMaskTexture MaskTexture
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private CubismMaskTile MaskTile
	{
		[CompilerGenerated]
		private get { } //Length: 34
		[CompilerGenerated]
		private set { } //Length: 32
	}

	private CubismMaskTransform MaskTransform
	{
		[CompilerGenerated]
		private get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	private static CubismMaskProperties SharedMaskProperties
	{
		[CompilerGenerated]
		private get { } //Length: 40
		[CompilerGenerated]
		private set { } //Length: 64
	}

	public CubismMaskMaskedJunction() { }

	public void AddToCommandBuffer(CommandBuffer buffer, bool isUsingMultipleBuffer, int renderTextureIndex) { }

	[CompilerGenerated]
	private CubismRenderer[] get_Maskeds() { }

	[CompilerGenerated]
	private CubismMaskRenderer[] get_Masks() { }

	[CompilerGenerated]
	private CubismMaskTexture get_MaskTexture() { }

	[CompilerGenerated]
	private CubismMaskTile get_MaskTile() { }

	[CompilerGenerated]
	private CubismMaskTransform get_MaskTransform() { }

	[CompilerGenerated]
	private static CubismMaskProperties get_SharedMaskProperties() { }

	private void RecalculateMaskTransform() { }

	[CompilerGenerated]
	private void set_Maskeds(CubismRenderer[] value) { }

	[CompilerGenerated]
	private void set_Masks(CubismMaskRenderer[] value) { }

	[CompilerGenerated]
	private void set_MaskTexture(CubismMaskTexture value) { }

	[CompilerGenerated]
	private void set_MaskTile(CubismMaskTile value) { }

	[CompilerGenerated]
	private void set_MaskTransform(CubismMaskTransform value) { }

	[CompilerGenerated]
	private static void set_SharedMaskProperties(CubismMaskProperties value) { }

	public CubismMaskMaskedJunction SetMaskeds(CubismRenderer[] value) { }

	public CubismMaskMaskedJunction SetMasks(CubismMaskRenderer[] value) { }

	public CubismMaskMaskedJunction SetMaskTexture(CubismMaskTexture value) { }

	public CubismMaskMaskedJunction SetMaskTile(CubismMaskTile value) { }

	internal void Update() { }

}

