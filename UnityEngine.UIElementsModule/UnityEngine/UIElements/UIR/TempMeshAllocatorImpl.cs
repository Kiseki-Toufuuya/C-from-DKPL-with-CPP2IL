namespace UnityEngine.UIElements.UIR;

internal class TempMeshAllocatorImpl : IDisposable
{
	private struct ThreadData
	{
		public List<IntPtr> allocations; //Field offset: 0x0

	}

	private GCHandle m_GCHandle; //Field offset: 0x8
	private ThreadData[] m_ThreadData; //Field offset: 0xC
	private TempAllocator<Vertex> m_VertexPool; //Field offset: 0x10
	private TempAllocator<UInt16> m_IndexPool; //Field offset: 0x14
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <disposed>k__BackingField; //Field offset: 0x18

	protected private bool disposed
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public TempMeshAllocatorImpl() { }

	private NativeSlice<T> Allocate(int count, int alignment) { }

	public void AllocateTempMesh(int vertexCount, int indexCount, out NativeSlice<Vertex>& vertices, out NativeSlice<UInt16>& indices) { }

	public void Clear() { }

	public void CreateNativeHandle(out TempMeshAllocator allocator) { }

	public override void Dispose() { }

	protected void Dispose(bool disposing) { }

	[CompilerGenerated]
	protected bool get_disposed() { }

	[CompilerGenerated]
	private void set_disposed(bool value) { }

}

