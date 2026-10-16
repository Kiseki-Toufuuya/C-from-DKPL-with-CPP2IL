namespace Live2D.Cubism.Rendering.Masking;

[CreateAssetMenu(menuName = "Live2D Cubism/Mask Texture")]
public sealed class CubismMaskTexture : ScriptableObject, ICubismMaskCommandSource
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass43_0
	{
		public ICubismMaskTextureCommandSource source; //Field offset: 0x8

		public <>c__DisplayClass43_0() { }

		internal bool <AddSource>b__0(ICubismMaskTextureCommandSource i) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass44_0
	{
		public ICubismMaskTextureCommandSource source; //Field offset: 0x8

		public <>c__DisplayClass44_0() { }

		internal bool <RemoveSource>b__0(SourcesItem i) { }

	}

	private struct SourcesItem
	{
		public ICubismMaskTextureCommandSource Source; //Field offset: 0x0
		public CubismMaskTile[] Tiles; //Field offset: 0x4

	}

	[HideInInspector]
	[SerializeField]
	private int _size; //Field offset: 0xC
	[HideInInspector]
	[SerializeField]
	private int _subdivisions; //Field offset: 0x10
	[HideInInspector]
	[SerializeField]
	private int _renderTextureCount; //Field offset: 0x14
	[CompilerGenerated]
	private CubismMaskTilePool <TilePool>k__BackingField; //Field offset: 0x18
	private RenderTexture _renderTexture; //Field offset: 0x1C
	private RenderTexture[] _renderTextures; //Field offset: 0x20
	[CompilerGenerated]
	private List<SourcesItem> <Sources>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private List<ICubismMaskTextureCommandSource> <CommandSources>k__BackingField; //Field offset: 0x28

	public int Channels
	{
		 get { } //Length: 6
	}

	private List<ICubismMaskTextureCommandSource> CommandSources
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	private bool ContainsSources
	{
		private get { } //Length: 57
	}

	public override int CountOfCommandBuffers
	{
		 get { } //Length: 11
	}

	public static CubismMaskTexture GlobalMaskTexture
	{
		 get { } //Length: 60
	}

	private bool IsRevived
	{
		private get { } //Length: 15
	}

	private RenderTexture RenderTexture
	{
		private get { } //Length: 95
		private set { } //Length: 27
	}

	public int RenderTextureCount
	{
		 get { } //Length: 11
		 set { } //Length: 53
	}

	public private RenderTexture[] RenderTextures
	{
		 get { } //Length: 30
		private set { } //Length: 27
	}

	public int Size
	{
		 get { } //Length: 11
		 set { } //Length: 113
	}

	private List<SourcesItem> Sources
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public int Subdivisions
	{
		 get { } //Length: 11
		 set { } //Length: 46
	}

	private CubismMaskTilePool TilePool
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public CubismMaskTexture() { }

	public void AddSource(ICubismMaskTextureCommandSource source) { }

	public int get_Channels() { }

	[CompilerGenerated]
	private List<ICubismMaskTextureCommandSource> get_CommandSources() { }

	private bool get_ContainsSources() { }

	public override int get_CountOfCommandBuffers() { }

	public static CubismMaskTexture get_GlobalMaskTexture() { }

	private bool get_IsRevived() { }

	private RenderTexture get_RenderTexture() { }

	public int get_RenderTextureCount() { }

	public RenderTexture[] get_RenderTextures() { }

	public int get_Size() { }

	[CompilerGenerated]
	private List<SourcesItem> get_Sources() { }

	public int get_Subdivisions() { }

	[CompilerGenerated]
	private CubismMaskTilePool get_TilePool() { }

	private override void Live2D.Cubism.Rendering.Masking.ICubismMaskCommandSource.AddToCommandBuffer(CommandBuffer buffer, bool isUsingMultipleBuffer, int renderTextureIndex) { }

	private void OnDestroy() { }

	private void OnEnable() { }

	public static Texture op_Implicit(CubismMaskTexture value) { }

	private void RefreshRenderTexture() { }

	private void RefreshRenderTextures() { }

	private void ReinitializeSources() { }

	public void RemoveSource(ICubismMaskTextureCommandSource source) { }

	[CompilerGenerated]
	private void set_CommandSources(List<ICubismMaskTextureCommandSource> value) { }

	private void set_RenderTexture(RenderTexture value) { }

	public void set_RenderTextureCount(int value) { }

	private void set_RenderTextures(RenderTexture[] value) { }

	public void set_Size(int value) { }

	[CompilerGenerated]
	private void set_Sources(List<SourcesItem> value) { }

	public void set_Subdivisions(int value) { }

	[CompilerGenerated]
	private void set_TilePool(CubismMaskTilePool value) { }

	private void TryRevive() { }

}

