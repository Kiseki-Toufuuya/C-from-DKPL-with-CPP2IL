namespace Live2D.Cubism.Rendering.Masking;

internal sealed class CubismMaskRenderer
{
	[CompilerGenerated]
	private MaterialPropertyBlock <MaskProperties>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private CubismRenderer <MainRenderer>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private Material <MaskMaterial>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private Material <MaskCullingMaterial>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <IsCulling>k__BackingField; //Field offset: 0x18

	private bool IsCulling
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private CubismRenderer MainRenderer
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private Material MaskCullingMaterial
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private Material MaskMaterial
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private MaterialPropertyBlock MaskProperties
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	internal Bounds MeshBounds
	{
		internal get { } //Length: 89
	}

	public CubismMaskRenderer() { }

	internal void AddToCommandBuffer(CommandBuffer buffer) { }

	[CompilerGenerated]
	private bool get_IsCulling() { }

	[CompilerGenerated]
	private CubismRenderer get_MainRenderer() { }

	[CompilerGenerated]
	private Material get_MaskCullingMaterial() { }

	[CompilerGenerated]
	private Material get_MaskMaterial() { }

	[CompilerGenerated]
	private MaterialPropertyBlock get_MaskProperties() { }

	internal Bounds get_MeshBounds() { }

	[CompilerGenerated]
	private void set_IsCulling(bool value) { }

	[CompilerGenerated]
	private void set_MainRenderer(CubismRenderer value) { }

	[CompilerGenerated]
	private void set_MaskCullingMaterial(Material value) { }

	[CompilerGenerated]
	private void set_MaskMaterial(Material value) { }

	[CompilerGenerated]
	private void set_MaskProperties(MaterialPropertyBlock value) { }

	internal CubismMaskRenderer SetMainRenderer(CubismRenderer value) { }

	internal CubismMaskRenderer SetMaskTile(CubismMaskTile value) { }

	internal CubismMaskRenderer SetMaskTransform(CubismMaskTransform value) { }

}

