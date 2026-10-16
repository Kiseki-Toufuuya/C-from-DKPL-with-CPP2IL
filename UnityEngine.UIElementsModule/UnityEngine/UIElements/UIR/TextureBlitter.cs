namespace UnityEngine.UIElements.UIR;

internal class TextureBlitter : IDisposable
{
	private struct BlitInfo
	{
		public Texture src; //Field offset: 0x0
		public RectInt srcRect; //Field offset: 0x4
		public Vector2Int dstPos; //Field offset: 0x14
		public int border; //Field offset: 0x1C
		public Color tint; //Field offset: 0x20

	}

	private static readonly Int32[] k_TextureIds; //Field offset: 0x0
	private static ProfilerMarker s_CommitSampler; //Field offset: 0x4
	private BlitInfo[] m_SingleBlit; //Field offset: 0x8
	private Material m_BlitMaterial; //Field offset: 0xC
	private MaterialPropertyBlock m_Properties; //Field offset: 0x10
	private RectInt m_Viewport; //Field offset: 0x14
	private RenderTexture m_PrevRT; //Field offset: 0x24
	private List<BlitInfo> m_PendingBlits; //Field offset: 0x28
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x2C

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private static TextureBlitter() { }

	public TextureBlitter(int capacity = 512) { }

	private void BeginBlit(RenderTexture dst) { }

	public void BlitOneNow(RenderTexture dst, Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	public void Commit(RenderTexture dst) { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	private void DoBlit(IList<BlitInfo> blitInfos, int startIndex) { }

	private void EndBlit() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	public void QueueBlit(Texture src, RectInt srcRect, Vector2Int dstPos, bool addBorder, Color tint) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

