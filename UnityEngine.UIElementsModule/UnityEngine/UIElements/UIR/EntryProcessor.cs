namespace UnityEngine.UIElements.UIR;

internal class EntryProcessor
{
	private struct MaskMesh
	{
		public NativeSlice<Vertex> vertices; //Field offset: 0x0
		public NativeSlice<UInt16> indices; //Field offset: 0xC
		public int indexOffset; //Field offset: 0x18

	}

	private static Material s_blitMaterial_LinearToGamma; //Field offset: 0x0
	private static Material s_blitMaterial_GammaToLinear; //Field offset: 0x4
	private static Material s_blitMaterial_NoChange; //Field offset: 0x8
	private static Shader s_blitShader; //Field offset: 0xC
	private EntryPreProcessor m_PreProcessor; //Field offset: 0x8
	private RenderChain m_RenderChain; //Field offset: 0xC
	private VisualElement m_CurrentElement; //Field offset: 0x10
	private int m_MaskDepth; //Field offset: 0x14
	private int m_MaskDepthPopped; //Field offset: 0x18
	private int m_MaskDepthPushed; //Field offset: 0x1C
	private int m_StencilRef; //Field offset: 0x20
	private int m_StencilRefPopped; //Field offset: 0x24
	private int m_StencilRefPushed; //Field offset: 0x28
	private BMPAlloc m_ClipRectId; //Field offset: 0x2C
	private BMPAlloc m_ClipRectIdPopped; //Field offset: 0x34
	private BMPAlloc m_ClipRectIdPushed; //Field offset: 0x3C
	private bool m_IsDrawingMask; //Field offset: 0x44
	private Stack<MaskMesh> m_MaskMeshes; //Field offset: 0x48
	private bool m_VertexDataComputed; //Field offset: 0x4C
	private Matrix4x4 m_Transform; //Field offset: 0x50
	private Color32 m_TransformData; //Field offset: 0x90
	private Color32 m_OpacityData; //Field offset: 0x94
	private Color32 m_TextCoreSettingsPage; //Field offset: 0x98
	private MeshHandle m_Mesh; //Field offset: 0x9C
	private NativeSlice<Vertex> m_Verts; //Field offset: 0xA0
	private NativeSlice<UInt16> m_Indices; //Field offset: 0xAC
	private ushort m_IndexOffset; //Field offset: 0xB8
	private int m_AllocVertexCount; //Field offset: 0xBC
	private int m_AllocIndex; //Field offset: 0xC0
	private int m_VertsFilled; //Field offset: 0xC4
	private int m_IndicesFilled; //Field offset: 0xC8
	private VertexFlags m_RenderType; //Field offset: 0xCC
	private bool m_RemapUVs; //Field offset: 0xD0
	private Rect m_AtlasRect; //Field offset: 0xD4
	private int m_GradientSettingIndexOffset; //Field offset: 0xE4
	private bool m_IsTail; //Field offset: 0xE8
	private RenderChainCommand m_FirstCommand; //Field offset: 0xEC
	private RenderChainCommand m_LastCommand; //Field offset: 0xF0
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <firstHeadCommand>k__BackingField; //Field offset: 0xF4
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <lastHeadCommand>k__BackingField; //Field offset: 0xF8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <firstTailCommand>k__BackingField; //Field offset: 0xFC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private RenderChainCommand <lastTailCommand>k__BackingField; //Field offset: 0x100

	public private RenderChainCommand firstHeadCommand
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private RenderChainCommand firstTailCommand
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private RenderChainCommand lastHeadCommand
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public private RenderChainCommand lastTailCommand
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		private set { } //Length: 33
	}

	public EntryProcessor() { }

	private void AppendCommand(RenderChainCommand next) { }

	public void ClearReferences() { }

	private static Material CreateBlitShader(float colorConversion) { }

	private RenderChainCommand CreateMeshDrawCommand(MeshHandle mesh, int indexCount, int indexOffset, Material material, TextureId texture) { }

	private void DrawReverseMask() { }

	[CompilerGenerated]
	public RenderChainCommand get_firstHeadCommand() { }

	[CompilerGenerated]
	public RenderChainCommand get_firstTailCommand() { }

	[CompilerGenerated]
	public RenderChainCommand get_lastHeadCommand() { }

	[CompilerGenerated]
	public RenderChainCommand get_lastTailCommand() { }

	private static Material GetBlitMaterial(RenderTargetMode mode) { }

	public void Init(Entry root, RenderChain renderChain, VisualElement ve) { }

	private void ProcessFirstAlloc(List<AllocSize> allocList, ref MeshHandle mesh) { }

	public void ProcessHead() { }

	private void ProcessMeshEntry(Entry entry, TextureId textureId) { }

	private void ProcessNextAlloc() { }

	private void ProcessRange(int first, int last) { }

	public void ProcessTail() { }

	[CompilerGenerated]
	private void set_firstHeadCommand(RenderChainCommand value) { }

	[CompilerGenerated]
	private void set_firstTailCommand(RenderChainCommand value) { }

	[CompilerGenerated]
	private void set_lastHeadCommand(RenderChainCommand value) { }

	[CompilerGenerated]
	private void set_lastTailCommand(RenderChainCommand value) { }

	private static void UpdateOrAllocate(ref MeshHandle data, int vertexCount, int indexCount, UIRenderDevice device, out NativeSlice<Vertex>& verts, out NativeSlice<UInt16>& indices, out ushort indexOffset, ref ChainBuilderStats stats) { }

}

