namespace Live2D.Cubism.Rendering.Masking;

[CubismDontMoveOnReimport]
[ExecuteInEditMode]
public sealed class CubismMaskController : MonoBehaviour, ICubismMaskTextureCommandSource, ICubismMaskCommandSource, ICubismUpdatable
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Predicate<CubismDrawable> <>9__15_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <ForceRevive>b__15_0(CubismDrawable mask) { }

	}

	private struct MasksMaskedsPair
	{
		public CubismRenderer[] Masks; //Field offset: 0x0
		public List<CubismRenderer> Maskeds; //Field offset: 0x4

	}

	private class MasksMaskedsPairs
	{
		public List<MasksMaskedsPair> Entries; //Field offset: 0x8

		public MasksMaskedsPairs() { }

		public void Add(CubismDrawable masked, CubismDrawable[] masks) { }

	}

	[HideInInspector]
	[SerializeField]
	private CubismMaskTexture _maskTexture; //Field offset: 0x10
	[CompilerGenerated]
	private CubismMaskMaskedJunction[] <Junctions>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private bool <HasUpdateController>k__BackingField; //Field offset: 0x18

	public override int CountOfCommandBuffers
	{
		 get { } //Length: 30
	}

	public override int ExecutionOrder
	{
		 get { } //Length: 61
	}

	[HideInInspector]
	public override bool HasUpdateController
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	private bool IsRevived
	{
		private get { } //Length: 15
	}

	private CubismMaskMaskedJunction[] Junctions
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismMaskTexture MaskTexture
	{
		 get { } //Length: 156
		 set { } //Length: 486
	}

	public override bool NeedsUpdateOnEditing
	{
		 get { } //Length: 3
	}

	public CubismMaskController() { }

	private void ForceRevive() { }

	public override int get_CountOfCommandBuffers() { }

	public override int get_ExecutionOrder() { }

	[CompilerGenerated]
	public override bool get_HasUpdateController() { }

	private bool get_IsRevived() { }

	[CompilerGenerated]
	private CubismMaskMaskedJunction[] get_Junctions() { }

	public CubismMaskTexture get_MaskTexture() { }

	public override bool get_NeedsUpdateOnEditing() { }

	private void LateUpdate() { }

	private override void Live2D.Cubism.Rendering.Masking.ICubismMaskCommandSource.AddToCommandBuffer(CommandBuffer buffer, bool isUsingMultipleBuffer, int bufferIndex) { }

	private override int Live2D.Cubism.Rendering.Masking.ICubismMaskTextureCommandSource.GetNecessaryTileCount() { }

	private override void Live2D.Cubism.Rendering.Masking.ICubismMaskTextureCommandSource.SetTiles(CubismMaskTile[] value) { }

	private void OnDestroy() { }

	public override void OnLateUpdate() { }

	[CompilerGenerated]
	public override void set_HasUpdateController(bool value) { }

	[CompilerGenerated]
	private void set_Junctions(CubismMaskMaskedJunction[] value) { }

	public void set_MaskTexture(CubismMaskTexture value) { }

	private void Start() { }

	private void TryRevive() { }

}

