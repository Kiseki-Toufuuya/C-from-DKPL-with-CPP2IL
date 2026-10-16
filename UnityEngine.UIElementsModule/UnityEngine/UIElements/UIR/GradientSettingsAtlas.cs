namespace UnityEngine.UIElements.UIR;

internal class GradientSettingsAtlas : IDisposable
{
	private struct RawTexture
	{
		public Color32[] rgba; //Field offset: 0x0
		public int width; //Field offset: 0x4
		public int height; //Field offset: 0x8

		public void WriteRawFloat4Packed(float f0, float f1, float f2, float f3, int destX, int destY) { }

		public void WriteRawInt2Packed(int v0, int v1, int destX, int destY) { }

	}

	private static ProfilerMarker s_MarkerWrite; //Field offset: 0x0
	private static ProfilerMarker s_MarkerCommit; //Field offset: 0x4
	private static int s_TextureCounter; //Field offset: 0x8
	private readonly int m_Length; //Field offset: 0x8
	private readonly int m_ElemWidth; //Field offset: 0xC
	private BestFitAllocator m_Allocator; //Field offset: 0x10
	private Texture2D m_Atlas; //Field offset: 0x14
	private RawTexture m_RawAtlas; //Field offset: 0x18
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <MustCommit>k__BackingField; //Field offset: 0x25

	public Texture2D atlas
	{
		 get { } //Length: 11
	}

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal int length
	{
		internal get { } //Length: 11
	}

	public private bool MustCommit
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	private static GradientSettingsAtlas() { }

	public GradientSettingsAtlas(int length = 4096) { }

	public Alloc Add(int count) { }

	public void Commit() { }

	public override void Dispose() { }

	protected override void Dispose(bool disposing) { }

	public Texture2D get_atlas() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	internal int get_length() { }

	[CompilerGenerated]
	public bool get_MustCommit() { }

	private void PrepareAtlas() { }

	public void Reset() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	[CompilerGenerated]
	private void set_MustCommit(bool value) { }

	public void Write(Alloc alloc, GradientSettings[] settings, GradientRemap remap) { }

}

