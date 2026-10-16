namespace UnityEngine.UIElements.UIR;

internal class CommandList : IDisposable
{
	public VisualElement m_Owner; //Field offset: 0x8
	private readonly IntPtr m_VertexDecl; //Field offset: 0xC
	private readonly IntPtr m_StencilState; //Field offset: 0x10
	public MaterialPropertyBlock constantProps; //Field offset: 0x14
	public MaterialPropertyBlock batchProps; //Field offset: 0x18
	public GCHandle handle; //Field offset: 0x1C
	private List<SerializedCommand> m_Commands; //Field offset: 0x20
	private Vector4[] m_GpuTextureData; //Field offset: 0x24
	private NativeList<DrawBufferRange> m_DrawRanges; //Field offset: 0x28
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

	public CommandList(VisualElement owner, IntPtr vertexDecl, IntPtr stencilState) { }

	public void ApplyBatchProps() { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	public void DrawRanges(GPUBuffer<UInt16> ib, GPUBuffer<Vertex> vb, NativeSlice<DrawBufferRange> ranges) { }

	public void Execute() { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	public void Reset(VisualElement newOwner) { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

	public void SetTexture(int name, Texture texture, int gpuDataOffset, Vector4 gpuData0, Vector4 gpuData1) { }

}

