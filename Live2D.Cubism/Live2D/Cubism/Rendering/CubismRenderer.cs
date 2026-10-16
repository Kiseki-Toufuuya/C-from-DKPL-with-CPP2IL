namespace Live2D.Cubism.Rendering;

[ExecuteInEditMode]
[RequireComponent(typeof(MeshFilter), typeof(MeshRenderer))]
public sealed class CubismRenderer : MonoBehaviour
{
	private struct SwapInfo
	{
		[CompilerGenerated]
		private bool <NewVertexPositions>k__BackingField; //Field offset: 0x0
		[CompilerGenerated]
		private bool <NewVertexColors>k__BackingField; //Field offset: 0x1
		[CompilerGenerated]
		private bool <DidBecomeVisible>k__BackingField; //Field offset: 0x2
		[CompilerGenerated]
		private bool <DidBecomeInvisible>k__BackingField; //Field offset: 0x3
		[CompilerGenerated]
		private bool <NewRenderOrder>k__BackingField; //Field offset: 0x4

		public bool DidBecomeInvisible
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool DidBecomeVisible
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool NewRenderOrder
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool NewVertexColors
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public bool NewVertexPositions
		{
			[CompilerGenerated]
			[IsReadOnly]
			 get { } //Length: 10
			[CompilerGenerated]
			 set { } //Length: 13
		}

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_DidBecomeInvisible() { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_DidBecomeVisible() { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_NewRenderOrder() { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_NewVertexColors() { }

		[CompilerGenerated]
		[IsReadOnly]
		public bool get_NewVertexPositions() { }

		[CompilerGenerated]
		public void set_DidBecomeInvisible(bool value) { }

		[CompilerGenerated]
		public void set_DidBecomeVisible(bool value) { }

		[CompilerGenerated]
		public void set_NewRenderOrder(bool value) { }

		[CompilerGenerated]
		public void set_NewVertexColors(bool value) { }

		[CompilerGenerated]
		public void set_NewVertexPositions(bool value) { }

	}

	private static MaterialPropertyBlock _sharedPropertyBlock; //Field offset: 0x0
	[HideInInspector]
	[SerializeField]
	private int _localSortingOrder; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private Color _color; //Field offset: 0x14
	[HideInInspector]
	[SerializeField]
	private bool _isOverriddenDrawableMultiplyColors; //Field offset: 0x24
	[CompilerGenerated]
	private bool <LastIsUseUserMultiplyColor>k__BackingField; //Field offset: 0x25
	[HideInInspector]
	[SerializeField]
	private bool _isOverriddenDrawableScreenColors; //Field offset: 0x26
	[CompilerGenerated]
	private bool <LastIsUseUserScreenColors>k__BackingField; //Field offset: 0x27
	[HideInInspector]
	[SerializeField]
	private Color _multiplyColor; //Field offset: 0x28
	[CompilerGenerated]
	private Color <LastMultiplyColor>k__BackingField; //Field offset: 0x38
	[HideInInspector]
	[SerializeField]
	private Color _screenColor; //Field offset: 0x48
	[CompilerGenerated]
	private Color <LastScreenColor>k__BackingField; //Field offset: 0x58
	[HideInInspector]
	[SerializeField]
	private Texture2D _mainTexture; //Field offset: 0x68
	[CompilerGenerated]
	private Mesh[] <Meshes>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private int <FrontMesh>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private int <BackMesh>k__BackingField; //Field offset: 0x74
	private MeshFilter _meshFilter; //Field offset: 0x78
	private MeshRenderer _meshRenderer; //Field offset: 0x7C
	[CompilerGenerated]
	private CubismDrawable <Drawable>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private CubismRenderController <RenderController>k__BackingField; //Field offset: 0x84
	[HideInInspector]
	[SerializeField]
	private CubismSortingMode _sortingMode; //Field offset: 0x88
	[HideInInspector]
	[SerializeField]
	private int _sortingOrder; //Field offset: 0x8C
	[HideInInspector]
	[SerializeField]
	private int _renderOrder; //Field offset: 0x90
	[HideInInspector]
	[SerializeField]
	private float _depthOffset; //Field offset: 0x94
	[HideInInspector]
	[SerializeField]
	private float _opacity; //Field offset: 0x98
	[CompilerGenerated]
	private Color[] <VertexColors>k__BackingField; //Field offset: 0x9C
	[CompilerGenerated]
	private SwapInfo <LastSwap>k__BackingField; //Field offset: 0xA0
	[CompilerGenerated]
	private SwapInfo <ThisSwap>k__BackingField; //Field offset: 0xA5

	private int BackMesh
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public Color Color
	{
		 get { } //Length: 18
		 set { } //Length: 126
	}

	private float DepthOffset
	{
		private get { } //Length: 14
		private set { } //Length: 21
	}

	private CubismDrawable Drawable
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private int FrontMesh
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public bool LastIsUseUserMultiplyColor
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool LastIsUseUserScreenColors
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public Color LastMultiplyColor
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	public Color LastScreenColor
	{
		[CompilerGenerated]
		 get { } //Length: 18
		[CompilerGenerated]
		 set { } //Length: 16
	}

	private SwapInfo LastSwap
	{
		[CompilerGenerated]
		private get { } //Length: 28
		[CompilerGenerated]
		private set { } //Length: 26
	}

	public int LocalSortingOrder
	{
		 get { } //Length: 11
		 set { } //Length: 30
	}

	public Texture2D MainTexture
	{
		 get { } //Length: 11
		 set { } //Length: 198
	}

	public Material Material
	{
		 get { } //Length: 47
		 set { } //Length: 47
	}

	public Mesh Mesh
	{
		 get { } //Length: 36
	}

	private Mesh[] Meshes
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public MeshFilter MeshFilter
	{
		 get { } //Length: 11
	}

	public MeshRenderer MeshRenderer
	{
		 get { } //Length: 24
	}

	public Color MultiplyColor
	{
		 get { } //Length: 88
		 set { } //Length: 115
	}

	private float Opacity
	{
		private get { } //Length: 14
		private set { } //Length: 21
	}

	public bool OverrideFlagForDrawableMultiplyColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool OverrideFlagForDrawableScreenColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool OverwriteFlagForDrawableMultiplyColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool OverwriteFlagForDrawableScreenColors
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	private CubismRenderController RenderController
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	private int RenderOrder
	{
		private get { } //Length: 14
		private set { } //Length: 17
	}

	public Color ScreenColor
	{
		 get { } //Length: 88
		 set { } //Length: 115
	}

	private static MaterialPropertyBlock SharedPropertyBlock
	{
		private get { } //Length: 115
	}

	private CubismSortingMode SortingMode
	{
		private get { } //Length: 14
		private set { } //Length: 17
	}

	private int SortingOrder
	{
		private get { } //Length: 14
		private set { } //Length: 17
	}

	private SwapInfo ThisSwap
	{
		[CompilerGenerated]
		private get { } //Length: 28
		[CompilerGenerated]
		private set { } //Length: 26
	}

	private Color[] VertexColors
	{
		[CompilerGenerated]
		private get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public CubismRenderer() { }

	private void ApplyMainTexture() { }

	public void ApplyMultiplyColor() { }

	public void ApplyScreenColor() { }

	private void ApplySorting() { }

	public void ApplyVertexColors() { }

	private void BecomeInvisible() { }

	private void BecomeVisible() { }

	[CompilerGenerated]
	private int get_BackMesh() { }

	public Color get_Color() { }

	private float get_DepthOffset() { }

	[CompilerGenerated]
	private CubismDrawable get_Drawable() { }

	[CompilerGenerated]
	private int get_FrontMesh() { }

	[CompilerGenerated]
	public bool get_LastIsUseUserMultiplyColor() { }

	[CompilerGenerated]
	public bool get_LastIsUseUserScreenColors() { }

	[CompilerGenerated]
	public Color get_LastMultiplyColor() { }

	[CompilerGenerated]
	public Color get_LastScreenColor() { }

	[CompilerGenerated]
	private SwapInfo get_LastSwap() { }

	public int get_LocalSortingOrder() { }

	public Texture2D get_MainTexture() { }

	public Material get_Material() { }

	public Mesh get_Mesh() { }

	[CompilerGenerated]
	private Mesh[] get_Meshes() { }

	public MeshFilter get_MeshFilter() { }

	public MeshRenderer get_MeshRenderer() { }

	public Color get_MultiplyColor() { }

	private float get_Opacity() { }

	public bool get_OverrideFlagForDrawableMultiplyColors() { }

	public bool get_OverrideFlagForDrawableScreenColors() { }

	public bool get_OverwriteFlagForDrawableMultiplyColors() { }

	public bool get_OverwriteFlagForDrawableScreenColors() { }

	[CompilerGenerated]
	private CubismRenderController get_RenderController() { }

	private int get_RenderOrder() { }

	public Color get_ScreenColor() { }

	private static MaterialPropertyBlock get_SharedPropertyBlock() { }

	private CubismSortingMode get_SortingMode() { }

	private int get_SortingOrder() { }

	[CompilerGenerated]
	private SwapInfo get_ThisSwap() { }

	[CompilerGenerated]
	private Color[] get_VertexColors() { }

	internal void OnControllerDepthOffsetDidChange(float newDepthOffset) { }

	internal void OnControllerSortingLayerDidChange(int newSortingLayer) { }

	internal void OnControllerSortingModeDidChange(CubismSortingMode newSortingMode) { }

	internal void OnControllerSortingOrderDidChange(int newSortingOrder) { }

	private void OnDestroy() { }

	internal void OnDrawableOpacityDidChange(float newOpacity) { }

	internal void OnDrawableRenderOrderDidChange(int newRenderOrder) { }

	internal void OnDrawableVertexPositionsDidChange(Vector3[] newVertexPositions) { }

	internal void OnDrawableVisiblityDidChange(bool newVisibility) { }

	internal void OnMaskPropertiesDidChange(CubismMaskProperties newMaskProperties) { }

	internal void OnModelOpacityDidChange(float newModelOpacity) { }

	private void ResetRenderOrderFlag() { }

	private void ResetSwapInfoFlags() { }

	private void ResetVisibilityFlags() { }

	[CompilerGenerated]
	private void set_BackMesh(int value) { }

	public void set_Color(Color value) { }

	private void set_DepthOffset(float value) { }

	[CompilerGenerated]
	private void set_Drawable(CubismDrawable value) { }

	[CompilerGenerated]
	private void set_FrontMesh(int value) { }

	[CompilerGenerated]
	public void set_LastIsUseUserMultiplyColor(bool value) { }

	[CompilerGenerated]
	public void set_LastIsUseUserScreenColors(bool value) { }

	[CompilerGenerated]
	public void set_LastMultiplyColor(Color value) { }

	[CompilerGenerated]
	public void set_LastScreenColor(Color value) { }

	[CompilerGenerated]
	private void set_LastSwap(SwapInfo value) { }

	public void set_LocalSortingOrder(int value) { }

	public void set_MainTexture(Texture2D value) { }

	public void set_Material(Material value) { }

	[CompilerGenerated]
	private void set_Meshes(Mesh[] value) { }

	public void set_MultiplyColor(Color value) { }

	private void set_Opacity(float value) { }

	public void set_OverrideFlagForDrawableMultiplyColors(bool value) { }

	public void set_OverrideFlagForDrawableScreenColors(bool value) { }

	public void set_OverwriteFlagForDrawableMultiplyColors(bool value) { }

	public void set_OverwriteFlagForDrawableScreenColors(bool value) { }

	[CompilerGenerated]
	private void set_RenderController(CubismRenderController value) { }

	private void set_RenderOrder(int value) { }

	public void set_ScreenColor(Color value) { }

	private void set_SortingMode(CubismSortingMode value) { }

	private void set_SortingOrder(int value) { }

	[CompilerGenerated]
	private void set_ThisSwap(SwapInfo value) { }

	[CompilerGenerated]
	private void set_VertexColors(Color[] value) { }

	private void SetNewRenderOrder() { }

	private void SetNewVertexColors() { }

	private void SetNewVertexPositions() { }

	public void SwapMeshes() { }

	public void TryInitialize(CubismRenderController renderController) { }

	private void TryInitializeMainTexture() { }

	private void TryInitializeMesh() { }

	private void TryInitializeMeshFilter() { }

	private void TryInitializeMeshRenderer() { }

	private void TryInitializeMultiplyColor() { }

	private void TryInitializeScreenColor() { }

	private void TryInitializeVertexColor() { }

	public void UpdateRenderOrder() { }

	public void UpdateVisibility() { }

}

