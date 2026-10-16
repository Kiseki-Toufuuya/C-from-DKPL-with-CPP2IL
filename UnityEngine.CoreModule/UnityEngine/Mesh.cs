namespace UnityEngine;

[ExcludeFromPreset]
[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
[RequiredByNativeCode]
public sealed class Mesh : object
{
	[NativeHeader("Runtime/Graphics/Mesh/MeshScriptBindings.h")]
	[StaticAccessor("MeshDataBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshData
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr m_Ptr; //Field offset: 0x0

	}

	[DefaultMember("Item")]
	[NativeContainer]
	[NativeContainerSupportsMinMaxWriteRestriction]
	[StaticAccessor("MeshDataArrayBindings", StaticAccessorType::DoubleColon (2))]
	internal struct MeshDataArray : IDisposable
	{
		[NativeDisableUnsafePtrRestriction]
		internal IntPtr* m_Ptrs; //Field offset: 0x0
		internal int m_Length; //Field offset: 0x4

		public int Length
		{
			 get { } //Length: 11
		}

		internal MeshDataArray(int meshesCount) { }

		internal MeshDataArray(Mesh[] meshes, int meshesCount, bool checkReadWrite = true, bool createAsCopy = false) { }

		internal MeshDataArray(Mesh mesh, bool checkReadWrite = true, bool createAsCopy = false) { }

		private static void AcquireMeshDataCopy(Mesh mesh, IntPtr* datas) { }

		private static void AcquireMeshDataCopy_Injected(IntPtr mesh, IntPtr* datas) { }

		private static void AcquireMeshDatasCopy(Mesh[] meshes, IntPtr* datas, int count) { }

		private static void AcquireMeshDatasCopy_Injected(Mesh[] meshes, IntPtr* datas, int count) { }

		private static void AcquireReadOnlyMeshData(Mesh mesh, IntPtr* datas) { }

		private static void AcquireReadOnlyMeshData_Injected(IntPtr mesh, IntPtr* datas) { }

		private static void AcquireReadOnlyMeshDatas(Mesh[] meshes, IntPtr* datas, int count) { }

		private static void AcquireReadOnlyMeshDatas_Injected(Mesh[] meshes, IntPtr* datas, int count) { }

		internal void ApplyToMeshAndDispose(Mesh mesh, MeshUpdateFlags flags) { }

		internal void ApplyToMeshesAndDispose(Mesh[] meshes, MeshUpdateFlags flags) { }

		[NativeThrows]
		private static void ApplyToMeshesImpl(Mesh[] meshes, IntPtr* datas, int count, MeshUpdateFlags flags) { }

		private static void ApplyToMeshesImpl_Injected(Mesh[] meshes, IntPtr* datas, int count, MeshUpdateFlags flags) { }

		[NativeThrows]
		private static void ApplyToMeshImpl(Mesh mesh, IntPtr data, MeshUpdateFlags flags) { }

		private static void ApplyToMeshImpl_Injected(IntPtr mesh, IntPtr data, MeshUpdateFlags flags) { }

		private static void CreateNewMeshDatas(IntPtr* datas, int count) { }

		public override void Dispose() { }

		public int get_Length() { }

		private static void ReleaseMeshDatas(IntPtr* datas, int count) { }

	}


	public int bindposeCount
	{
		 get { } //Length: 98
	}

	[NativeName("BindPosesFromScript")]
	public Matrix4x4[] bindposes
	{
		 get { } //Length: 322
		 set { } //Length: 202
	}

	public int blendShapeCount
	{
		[NativeMethod(Name = "GetBlendShapeChannelCount")]
		 get { } //Length: 98
	}

	public BoneWeight[] boneWeights
	{
		 get { } //Length: 16
		 set { } //Length: 202
	}

	public Bounds bounds
	{
		 get { } //Length: 117
		 set { } //Length: 102
	}

	internal bool canAccess
	{
		[NativeMethod("CanAccessFromScript")]
		internal get { } //Length: 98
	}

	public Color[] colors
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Color32[] colors32
	{
		 get { } //Length: 57
		 set { } //Length: 62
	}

	public Target indexBufferTarget
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public IndexFormat indexFormat
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool isReadable
	{
		[NativeMethod("GetIsReadable")]
		 get { } //Length: 98
	}

	public Vector3[] normals
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public SkinWeights skinWeightBufferLayout
	{
		 get { } //Length: 98
	}

	public int subMeshCount
	{
		[NativeMethod(Name = "GetSubMeshCount")]
		 get { } //Length: 98
		[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
		 set { } //Length: 101
	}

	public Vector4[] tangents
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Int32[] triangles
	{
		 get { } //Length: 173
		 set { } //Length: 259
	}

	public Vector2[] uv
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Vector2[] uv2
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Vector2[] uv3
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Vector2[] uv4
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Vector2[] uv5
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Vector2[] uv6
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Vector2[] uv7
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public Vector2[] uv8
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	public int vertexAttributeCount
	{
		 get { } //Length: 98
	}

	public int vertexBufferCount
	{
		[FreeFunction(Name = "MeshScripting::GetVertexBufferCount", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public Target vertexBufferTarget
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int vertexCount
	{
		[NativeMethod("GetVertexCount")]
		 get { } //Length: 98
	}

	public Vector3[] vertices
	{
		 get { } //Length: 53
		 set { } //Length: 58
	}

	[RequiredByNativeCode]
	public Mesh() { }

	public static MeshDataArray AcquireReadOnlyMeshData(List<Mesh> meshes) { }

	public static MeshDataArray AcquireReadOnlyMeshData(Mesh[] meshes) { }

	public static MeshDataArray AcquireReadOnlyMeshData(Mesh mesh) { }

	[FreeFunction(Name = "AddBlendShapeFrameFromScript", HasExplicitThis = True, ThrowsException = True)]
	public void AddBlendShapeFrame(string shapeName, float frameWeight, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	private static void AddBlendShapeFrame_Injected(IntPtr _unity_self, ref ManagedSpanWrapper shapeName, float frameWeight, ref ManagedSpanWrapper deltaVertices, ref ManagedSpanWrapper deltaNormals, ref ManagedSpanWrapper deltaTangents) { }

	public static MeshDataArray AllocateWritableMeshData(List<Mesh> meshes) { }

	public static MeshDataArray AllocateWritableMeshData(Mesh[] meshes) { }

	public static MeshDataArray AllocateWritableMeshData(Mesh mesh) { }

	public static MeshDataArray AllocateWritableMeshData(int meshCount) { }

	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh mesh, MeshUpdateFlags flags = 0) { }

	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, Mesh[] meshes, MeshUpdateFlags flags = 0) { }

	public static void ApplyAndDisposeWritableMeshData(MeshDataArray data, List<Mesh> meshes, MeshUpdateFlags flags = 0) { }

	private bool CheckCanAccessSubmesh(int submesh, bool errorAboutTriangles) { }

	private bool CheckCanAccessSubmeshIndices(int submesh) { }

	private bool CheckCanAccessSubmeshTriangles(int submesh) { }

	private void CheckIndicesArrayRange(int valuesLength, int start, int length) { }

	[ExcludeFromDocs]
	public void Clear() { }

	public void Clear(bool keepVertexLayout) { }

	[FreeFunction(Name = "MeshScripting::ClearBlendShapes", HasExplicitThis = True)]
	public void ClearBlendShapes() { }

	private static void ClearBlendShapes_Injected(IntPtr _unity_self) { }

	[NativeMethod("Clear")]
	private void ClearImpl(bool keepVertexLayout) { }

	private static void ClearImpl_Injected(IntPtr _unity_self, bool keepVertexLayout) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes) { }

	[ExcludeFromDocs]
	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices) { }

	public void CombineMeshes(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	[NativeMethod(Name = "MeshScripting::CombineMeshes", IsFreeFunction = True, ThrowsException = True, HasExplicitThis = True)]
	private void CombineMeshesImpl(CombineInstance[] combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	private static void CombineMeshesImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper combine, bool mergeSubMeshes, bool useMatrices, bool hasLightmapData) { }

	internal static int DefaultDimensionForChannel(VertexAttribute channel) { }

	[FreeFunction("MeshScripting::MeshFromInstanceId")]
	internal static Mesh FromInstanceID(int id) { }

	private static IntPtr FromInstanceID_Injected(int id) { }

	public int get_bindposeCount() { }

	private static int get_bindposeCount_Injected(IntPtr _unity_self) { }

	public Matrix4x4[] get_bindposes() { }

	private static void get_bindposes_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[NativeMethod(Name = "GetBlendShapeChannelCount")]
	public int get_blendShapeCount() { }

	private static int get_blendShapeCount_Injected(IntPtr _unity_self) { }

	public BoneWeight[] get_boneWeights() { }

	public Bounds get_bounds() { }

	private static void get_bounds_Injected(IntPtr _unity_self, out Bounds ret) { }

	[NativeMethod("CanAccessFromScript")]
	internal bool get_canAccess() { }

	private static bool get_canAccess_Injected(IntPtr _unity_self) { }

	public Color[] get_colors() { }

	public Color32[] get_colors32() { }

	public Target get_indexBufferTarget() { }

	private static Target get_indexBufferTarget_Injected(IntPtr _unity_self) { }

	public IndexFormat get_indexFormat() { }

	private static IndexFormat get_indexFormat_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetIsReadable")]
	public bool get_isReadable() { }

	private static bool get_isReadable_Injected(IntPtr _unity_self) { }

	public Vector3[] get_normals() { }

	public SkinWeights get_skinWeightBufferLayout() { }

	[NativeMethod(Name = "GetSubMeshCount")]
	public int get_subMeshCount() { }

	private static int get_subMeshCount_Injected(IntPtr _unity_self) { }

	public Vector4[] get_tangents() { }

	public Int32[] get_triangles() { }

	public Vector2[] get_uv() { }

	public Vector2[] get_uv2() { }

	public Vector2[] get_uv3() { }

	public Vector2[] get_uv4() { }

	public Vector2[] get_uv5() { }

	public Vector2[] get_uv6() { }

	public Vector2[] get_uv7() { }

	public Vector2[] get_uv8() { }

	public int get_vertexAttributeCount() { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferCount", HasExplicitThis = True)]
	public int get_vertexBufferCount() { }

	private static int get_vertexBufferCount_Injected(IntPtr _unity_self) { }

	public Target get_vertexBufferTarget() { }

	private static Target get_vertexBufferTarget_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetVertexCount")]
	public int get_vertexCount() { }

	private static int get_vertexCount_Injected(IntPtr _unity_self) { }

	public Vector3[] get_vertices() { }

	public NativeArray<BoneWeight1> GetAllBoneWeights() { }

	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArray", HasExplicitThis = True)]
	private IntPtr GetAllBoneWeightsArray() { }

	private static IntPtr GetAllBoneWeightsArray_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "MeshScripting::GetAllBoneWeightsArraySize", HasExplicitThis = True)]
	private int GetAllBoneWeightsArraySize() { }

	private static int GetAllBoneWeightsArraySize_Injected(IntPtr _unity_self) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel) { }

	private T[] GetAllocArrayFromChannel(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "AllocExtractMeshComponentFromScript", HasExplicitThis = True)]
	private Array GetAllocArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	private static Array GetAllocArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim) { }

	[FreeFunction(Name = "ExtractMeshComponentFromScript", HasExplicitThis = True)]
	private void GetArrayFromChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	private static void GetArrayFromChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values) { }

	public uint GetBaseVertex(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetBaseVertex", HasExplicitThis = True)]
	private uint GetBaseVertexImpl(int submesh) { }

	private static uint GetBaseVertexImpl_Injected(IntPtr _unity_self, int submesh) { }

	public NativeArray<Matrix4x4> GetBindposes() { }

	public void GetBindposes(List<Matrix4x4> bindposes) { }

	[FreeFunction(Name = "MeshScripting::GetBindposesArray", HasExplicitThis = True)]
	private IntPtr GetBindposesArray() { }

	private static IntPtr GetBindposesArray_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "MeshScripting::ExtractBindPosesIntoArray", HasExplicitThis = True)]
	private void GetBindposesNonAllocImpl(out Matrix4x4[] values) { }

	private static void GetBindposesNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values) { }

	public GraphicsBuffer GetBlendShapeBuffer(BlendShapeBufferLayout layout) { }

	public GraphicsBuffer GetBlendShapeBuffer() { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetBlendShapeBufferImpl(int layout) { }

	private static IntPtr GetBlendShapeBufferImpl_Injected(IntPtr _unity_self, int layout) { }

	public BlendShapeBufferRange GetBlendShapeBufferRange(int blendShapeIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameCount", HasExplicitThis = True, ThrowsException = True)]
	public int GetBlendShapeFrameCount(int shapeIndex) { }

	private static int GetBlendShapeFrameCount_Injected(IntPtr _unity_self, int shapeIndex) { }

	[FreeFunction(Name = "GetBlendShapeFrameVerticesFromScript", HasExplicitThis = True, ThrowsException = True)]
	public void GetBlendShapeFrameVertices(int shapeIndex, int frameIndex, Vector3[] deltaVertices, Vector3[] deltaNormals, Vector3[] deltaTangents) { }

	private static void GetBlendShapeFrameVertices_Injected(IntPtr _unity_self, int shapeIndex, int frameIndex, ref ManagedSpanWrapper deltaVertices, ref ManagedSpanWrapper deltaNormals, ref ManagedSpanWrapper deltaTangents) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeFrameWeight", HasExplicitThis = True, ThrowsException = True)]
	public float GetBlendShapeFrameWeight(int shapeIndex, int frameIndex) { }

	private static float GetBlendShapeFrameWeight_Injected(IntPtr _unity_self, int shapeIndex, int frameIndex) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeIndex", HasExplicitThis = True, ThrowsException = True)]
	public int GetBlendShapeIndex(string blendShapeName) { }

	private static int GetBlendShapeIndex_Injected(IntPtr _unity_self, ref ManagedSpanWrapper blendShapeName) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeName", HasExplicitThis = True, ThrowsException = True)]
	public string GetBlendShapeName(int shapeIndex) { }

	private static void GetBlendShapeName_Injected(IntPtr _unity_self, int shapeIndex, out ManagedSpanWrapper ret) { }

	[FreeFunction(Name = "MeshScripting::GetBlendShapeOffset", HasExplicitThis = True)]
	private BlendShape GetBlendShapeOffsetInternal(int index) { }

	private static void GetBlendShapeOffsetInternal_Injected(IntPtr _unity_self, int index, out BlendShape ret) { }

	public NativeArray<Byte> GetBonesPerVertex() { }

	[FreeFunction(Name = "MeshScripting::GetBonesPerVertexArray", HasExplicitThis = True)]
	private IntPtr GetBonesPerVertexArray() { }

	private static IntPtr GetBonesPerVertexArray_Injected(IntPtr _unity_self) { }

	public GraphicsBuffer GetBoneWeightBuffer(SkinWeights layout) { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeightBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetBoneWeightBufferImpl(int bonesPerVertex) { }

	private static IntPtr GetBoneWeightBufferImpl_Injected(IntPtr _unity_self, int bonesPerVertex) { }

	[NativeMethod("GetBoneWeightBufferDimension")]
	private int GetBoneWeightBufferLayoutInternal() { }

	private static int GetBoneWeightBufferLayoutInternal_Injected(IntPtr _unity_self) { }

	public void GetBoneWeights(List<BoneWeight> boneWeights) { }

	[FreeFunction(Name = "MeshScripting::GetBoneWeights", HasExplicitThis = True)]
	private BoneWeight[] GetBoneWeightsImpl() { }

	private static void GetBoneWeightsImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper ret) { }

	[FreeFunction(Name = "MeshScripting::ExtractBoneWeightsIntoArray", HasExplicitThis = True)]
	private void GetBoneWeightsNonAllocImpl(out BoneWeight[] values) { }

	private static void GetBoneWeightsNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values) { }

	public void GetColors(List<Color32> colors) { }

	public void GetColors(List<Color> colors) { }

	public GraphicsBuffer GetIndexBuffer() { }

	[FreeFunction(Name = "MeshScripting::GetIndexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetIndexBufferImpl() { }

	private static IntPtr GetIndexBufferImpl_Injected(IntPtr _unity_self) { }

	public uint GetIndexCount(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexCount", HasExplicitThis = True)]
	private uint GetIndexCountImpl(int submesh) { }

	private static uint GetIndexCountImpl_Injected(IntPtr _unity_self, int submesh) { }

	public uint GetIndexStart(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndexStart", HasExplicitThis = True)]
	private uint GetIndexStartImpl(int submesh) { }

	private static uint GetIndexStartImpl_Injected(IntPtr _unity_self, int submesh) { }

	public void GetIndices(List<UInt16> indices, int submesh, bool applyBaseVertex = true) { }

	public Int32[] GetIndices(int submesh, bool applyBaseVertex) { }

	public void GetIndices(List<Int32> indices, int submesh, bool applyBaseVertex) { }

	[ExcludeFromDocs]
	public void GetIndices(List<Int32> indices, int submesh) { }

	[ExcludeFromDocs]
	public Int32[] GetIndices(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetIndices", HasExplicitThis = True)]
	private Int32[] GetIndicesImpl(int submesh, bool applyBaseVertex) { }

	private static void GetIndicesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, out BlittableArrayWrapper ret) { }

	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray", HasExplicitThis = True)]
	private void GetIndicesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex) { }

	private static void GetIndicesNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractIndicesToArray16", HasExplicitThis = True)]
	private void GetIndicesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex) { }

	private static void GetIndicesNonAllocImpl16_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim) { }

	private void GetListForChannel(List<T> buffer, int capacity, VertexAttribute channel, int dim, VertexAttributeFormat channelType) { }

	[FreeFunction(Name = "MeshScripting::GetNativeIndexBufferPtr", HasExplicitThis = True)]
	public IntPtr GetNativeIndexBufferPtr() { }

	private static IntPtr GetNativeIndexBufferPtr_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "MeshScripting::GetNativeVertexBufferPtr", HasExplicitThis = True)]
	[NativeThrows]
	public IntPtr GetNativeVertexBufferPtr(int index) { }

	private static IntPtr GetNativeVertexBufferPtr_Injected(IntPtr _unity_self, int index) { }

	public void GetNormals(List<Vector3> normals) { }

	[FreeFunction("MeshScripting::GetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	public SubMeshDescriptor GetSubMesh(int index) { }

	private static void GetSubMesh_Injected(IntPtr _unity_self, int index, out SubMeshDescriptor ret) { }

	public void GetTangents(List<Vector4> tangents) { }

	public MeshTopology GetTopology(int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetPrimitiveType", HasExplicitThis = True)]
	private MeshTopology GetTopologyImpl(int submesh) { }

	private static MeshTopology GetTopologyImpl_Injected(IntPtr _unity_self, int submesh) { }

	internal uint GetTotalIndexCount() { }

	private static uint GetTotalIndexCount_Injected(IntPtr _unity_self) { }

	public void GetTriangles(List<Int32> triangles, int submesh) { }

	public void GetTriangles(List<UInt16> triangles, int submesh, bool applyBaseVertex = true) { }

	public Int32[] GetTriangles(int submesh) { }

	public void GetTriangles(List<Int32> triangles, int submesh, bool applyBaseVertex) { }

	public Int32[] GetTriangles(int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::GetTrianglesCount", HasExplicitThis = True)]
	private uint GetTrianglesCountImpl(int submesh) { }

	private static uint GetTrianglesCountImpl_Injected(IntPtr _unity_self, int submesh) { }

	[FreeFunction(Name = "MeshScripting::GetTriangles", HasExplicitThis = True)]
	private Int32[] GetTrianglesImpl(int submesh, bool applyBaseVertex) { }

	private static void GetTrianglesImpl_Injected(IntPtr _unity_self, int submesh, bool applyBaseVertex, out BlittableArrayWrapper ret) { }

	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray", HasExplicitThis = True)]
	private void GetTrianglesNonAllocImpl(out Int32[] values, int submesh, bool applyBaseVertex) { }

	private static void GetTrianglesNonAllocImpl_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex) { }

	[FreeFunction(Name = "MeshScripting::ExtractTrianglesToArray16", HasExplicitThis = True)]
	private void GetTrianglesNonAllocImpl16(out UInt16[] values, int submesh, bool applyBaseVertex) { }

	private static void GetTrianglesNonAllocImpl16_Injected(IntPtr _unity_self, out BlittableArrayWrapper values, int submesh, bool applyBaseVertex) { }

	internal static VertexAttribute GetUVChannel(int uvIndex) { }

	[NativeMethod("GetMeshMetric")]
	public float GetUVDistributionMetric(int uvSetIndex) { }

	private static float GetUVDistributionMetric_Injected(IntPtr _unity_self, int uvSetIndex) { }

	public void GetUVs(int channel, List<Vector2> uvs) { }

	public void GetUVs(int channel, List<Vector4> uvs) { }

	public void GetUVs(int channel, List<Vector3> uvs) { }

	private void GetUVsImpl(int uvIndex, List<T> uvs, int dim) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributeByIndex", HasExplicitThis = True, ThrowsException = True)]
	public VertexAttributeDescriptor GetVertexAttribute(int index) { }

	private static void GetVertexAttribute_Injected(IntPtr _unity_self, int index, out VertexAttributeDescriptor ret) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesCount", HasExplicitThis = True)]
	private int GetVertexAttributeCountImpl() { }

	private static int GetVertexAttributeCountImpl_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "MeshScripting::GetChannelDimension", HasExplicitThis = True)]
	public int GetVertexAttributeDimension(VertexAttribute attr) { }

	private static int GetVertexAttributeDimension_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelFormat", HasExplicitThis = True)]
	public VertexAttributeFormat GetVertexAttributeFormat(VertexAttribute attr) { }

	private static VertexAttributeFormat GetVertexAttributeFormat_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[FreeFunction(Name = "MeshScripting::GetChannelOffset", HasExplicitThis = True)]
	public int GetVertexAttributeOffset(VertexAttribute attr) { }

	private static int GetVertexAttributeOffset_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	public int GetVertexAttributes(VertexAttributeDescriptor[] attributes) { }

	public int GetVertexAttributes(List<VertexAttributeDescriptor> attributes) { }

	public VertexAttributeDescriptor[] GetVertexAttributes() { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesAlloc", HasExplicitThis = True)]
	private Array GetVertexAttributesAlloc() { }

	private static Array GetVertexAttributesAlloc_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesArray", HasExplicitThis = True)]
	private int GetVertexAttributesArray(VertexAttributeDescriptor[] attributes) { }

	private static int GetVertexAttributesArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper attributes) { }

	[FreeFunction(Name = "MeshScripting::GetVertexAttributesList", HasExplicitThis = True)]
	private int GetVertexAttributesList(List<VertexAttributeDescriptor> attributes) { }

	private static int GetVertexAttributesList_Injected(IntPtr _unity_self, ref BlittableListWrapper attributes) { }

	[FreeFunction(Name = "MeshScripting::GetChannelStream", HasExplicitThis = True)]
	public int GetVertexAttributeStream(VertexAttribute attr) { }

	private static int GetVertexAttributeStream_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	public GraphicsBuffer GetVertexBuffer(int index) { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferPtr", HasExplicitThis = True, ThrowsException = True)]
	private GraphicsBuffer GetVertexBufferImpl(int index) { }

	private static IntPtr GetVertexBufferImpl_Injected(IntPtr _unity_self, int index) { }

	[FreeFunction(Name = "MeshScripting::GetVertexBufferStride", HasExplicitThis = True)]
	public int GetVertexBufferStride(int stream) { }

	private static int GetVertexBufferStride_Injected(IntPtr _unity_self, int stream) { }

	public void GetVertices(List<Vector3> vertices) { }

	[NativeMethod("HasBoneWeights")]
	private bool HasBoneWeights() { }

	private static bool HasBoneWeights_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "MeshScripting::HasChannel", HasExplicitThis = True)]
	public bool HasVertexAttribute(VertexAttribute attr) { }

	private static bool HasVertexAttribute_Injected(IntPtr _unity_self, VertexAttribute attr) { }

	[FreeFunction("MeshScripting::CreateMesh")]
	private static void Internal_Create(Mesh mono) { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	private void InternalSetBoneWeights(IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	private static void InternalSetBoneWeights_Injected(IntPtr _unity_self, IntPtr bonesPerVertex, int bonesPerVertexSize, IntPtr weights, int weightsSize) { }

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferData", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetIndexBufferData(IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	private static void InternalSetIndexBufferData_Injected(IntPtr _unity_self, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetIndexBufferDataFromArray", HasExplicitThis = True, ThrowsException = True)]
	private void InternalSetIndexBufferDataFromArray(Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	private static void InternalSetIndexBufferDataFromArray_Injected(IntPtr _unity_self, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferData", HasExplicitThis = True)]
	private void InternalSetVertexBufferData(int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	private static void InternalSetVertexBufferData_Injected(IntPtr _unity_self, int stream, IntPtr data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "MeshScripting::InternalSetVertexBufferDataFromArray", HasExplicitThis = True)]
	private void InternalSetVertexBufferDataFromArray(int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	private static void InternalSetVertexBufferDataFromArray_Injected(IntPtr _unity_self, int stream, Array data, int dataStart, int meshBufferStart, int count, int elemSize, MeshUpdateFlags flags) { }

	public void MarkDynamic() { }

	[NativeMethod("MarkDynamic")]
	private void MarkDynamicImpl() { }

	private static void MarkDynamicImpl_Injected(IntPtr _unity_self) { }

	[NativeMethod("MarkModified")]
	public void MarkModified() { }

	private static void MarkModified_Injected(IntPtr _unity_self) { }

	public void Optimize() { }

	[NativeMethod("Optimize")]
	private void OptimizeImpl() { }

	private static void OptimizeImpl_Injected(IntPtr _unity_self) { }

	public void OptimizeIndexBuffers() { }

	[NativeMethod("OptimizeIndexBuffers")]
	private void OptimizeIndexBuffersImpl() { }

	private static void OptimizeIndexBuffersImpl_Injected(IntPtr _unity_self) { }

	public void OptimizeReorderVertexBuffer() { }

	[NativeMethod("OptimizeReorderVertexBuffer")]
	private void OptimizeReorderVertexBufferImpl() { }

	private static void OptimizeReorderVertexBufferImpl_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "MeshScripting::PrintErrorCantAccessChannel", HasExplicitThis = True)]
	private void PrintErrorCantAccessChannel(VertexAttribute ch) { }

	private static void PrintErrorCantAccessChannel_Injected(IntPtr _unity_self, VertexAttribute ch) { }

	private void PrintErrorCantAccessIndices() { }

	[ExcludeFromDocs]
	public void RecalculateBounds() { }

	public void RecalculateBounds(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateBounds")]
	private void RecalculateBoundsImpl(MeshUpdateFlags flags) { }

	private static void RecalculateBoundsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateNormals() { }

	public void RecalculateNormals(MeshUpdateFlags flags) { }

	[NativeMethod("RecalculateNormals")]
	private void RecalculateNormalsImpl(MeshUpdateFlags flags) { }

	private static void RecalculateNormalsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	public void RecalculateTangents(MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void RecalculateTangents() { }

	[NativeMethod("RecalculateTangents")]
	private void RecalculateTangentsImpl(MeshUpdateFlags flags) { }

	private static void RecalculateTangentsImpl_Injected(IntPtr _unity_self, MeshUpdateFlags flags) { }

	public void RecalculateUVDistributionMetric(int uvSetIndex, float uvAreaThreshold = 1E-09) { }

	[NativeMethod("RecalculateMeshMetric")]
	private void RecalculateUVDistributionMetricImpl(int uvSetIndex, float uvAreaThreshold) { }

	private static void RecalculateUVDistributionMetricImpl_Injected(IntPtr _unity_self, int uvSetIndex, float uvAreaThreshold) { }

	public void RecalculateUVDistributionMetrics(float uvAreaThreshold = 1E-09) { }

	[NativeMethod("RecalculateMeshMetrics")]
	private void RecalculateUVDistributionMetricsImpl(float uvAreaThreshold) { }

	private static void RecalculateUVDistributionMetricsImpl_Injected(IntPtr _unity_self, float uvAreaThreshold) { }

	public void set_bindposes(Matrix4x4[] value) { }

	private static void set_bindposes_Injected(IntPtr _unity_self, ref ManagedSpanWrapper value) { }

	public void set_boneWeights(BoneWeight[] value) { }

	public void set_bounds(Bounds value) { }

	private static void set_bounds_Injected(IntPtr _unity_self, in Bounds value) { }

	public void set_colors(Color[] value) { }

	public void set_colors32(Color32[] value) { }

	public void set_indexBufferTarget(Target value) { }

	private static void set_indexBufferTarget_Injected(IntPtr _unity_self, Target value) { }

	public void set_indexFormat(IndexFormat value) { }

	private static void set_indexFormat_Injected(IntPtr _unity_self, IndexFormat value) { }

	public void set_normals(Vector3[] value) { }

	[FreeFunction(Name = "MeshScripting::SetSubMeshCount", HasExplicitThis = True)]
	public void set_subMeshCount(int value) { }

	private static void set_subMeshCount_Injected(IntPtr _unity_self, int value) { }

	public void set_tangents(Vector4[] value) { }

	public void set_triangles(Int32[] value) { }

	public void set_uv(Vector2[] value) { }

	public void set_uv2(Vector2[] value) { }

	public void set_uv3(Vector2[] value) { }

	public void set_uv4(Vector2[] value) { }

	public void set_uv5(Vector2[] value) { }

	public void set_uv6(Vector2[] value) { }

	public void set_uv7(Vector2[] value) { }

	public void set_uv8(Vector2[] value) { }

	public void set_vertexBufferTarget(Target value) { }

	private static void set_vertexBufferTarget_Injected(IntPtr _unity_self, Target value) { }

	public void set_vertices(Vector3[] value) { }

	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllSubMeshesAtOnceFromArray(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	private static void SetAllSubMeshesAtOnceFromArray_Injected(IntPtr _unity_self, ref ManagedSpanWrapper desc, int start, int count, MeshUpdateFlags flags) { }

	[FreeFunction("MeshScripting::SetAllSubMeshesAtOnceFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetAllSubMeshesAtOnceFromNativeArray(IntPtr desc, int start, int count, MeshUpdateFlags flags = 0) { }

	private static void SetAllSubMeshesAtOnceFromNativeArray_Injected(IntPtr _unity_self, IntPtr desc, int start, int count, MeshUpdateFlags flags) { }

	private void SetArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, T[] values, MeshUpdateFlags flags = 0) { }

	private void SetArrayForChannel(VertexAttribute channel, T[] values, MeshUpdateFlags flags = 0) { }

	[FreeFunction(Name = "SetMeshComponentFromArrayFromScript", HasExplicitThis = True)]
	private void SetArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	private static void SetArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	public void SetBindposes(NativeArray<Matrix4x4> poses) { }

	[NativeMethod("SetBindposes")]
	private void SetBindposesFromScript_NativeArray(IntPtr posesPtr, int posesCount) { }

	private static void SetBindposesFromScript_NativeArray_Injected(IntPtr _unity_self, IntPtr posesPtr, int posesCount) { }

	public void SetBoneWeights(NativeArray<Byte> bonesPerVertex, NativeArray<BoneWeight1> weights) { }

	[FreeFunction(Name = "MeshScripting::SetBoneWeights", HasExplicitThis = True)]
	private void SetBoneWeightsImpl(BoneWeight[] weights) { }

	private static void SetBoneWeightsImpl_Injected(IntPtr _unity_self, ref ManagedSpanWrapper weights) { }

	public void SetColors(Color[] inColors) { }

	public void SetColors(Color[] inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(List<Color32> inColors, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetColors(List<Color32> inColors, int start, int length) { }

	public void SetColors(List<Color> inColors, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetColors(List<Color> inColors, int start, int length) { }

	public void SetColors(Color32[] inColors, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetColors(Color32[] inColors, int start, int length) { }

	public void SetColors(List<Color32> inColors) { }

	public void SetColors(List<Color> inColors) { }

	public void SetColors(NativeArray<T> inColors) { }

	[ExcludeFromDocs]
	public void SetColors(NativeArray<T> inColors, int start, int length) { }

	public void SetColors(NativeArray<T> inColors, int start, int length, MeshUpdateFlags flags) { }

	public void SetColors(Color32[] inColors) { }

	[ExcludeFromDocs]
	public void SetColors(Color[] inColors, int start, int length) { }

	public void SetIndexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	public void SetIndexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	public void SetIndexBufferData(T[] data, int dataStart, int meshBufferStart, int count, MeshUpdateFlags flags = 0) { }

	[FreeFunction(Name = "MeshScripting::SetIndexBufferParams", HasExplicitThis = True, ThrowsException = True)]
	public void SetIndexBufferParams(int indexCount, IndexFormat format) { }

	private static void SetIndexBufferParams_Injected(IntPtr _unity_self, int indexCount, IndexFormat format) { }

	public void SetIndices(NativeArray<T> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<UInt16> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh) { }

	[ExcludeFromDocs]
	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds) { }

	public void SetIndices(List<Int32> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(Int32[] indices, MeshTopology topology, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetIndices(Int32[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(UInt16[] indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(UInt16[] indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(NativeArray<T> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<Int32> indices, int indicesStart, int indicesLength, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetIndices(List<UInt16> indices, MeshTopology topology, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[FreeFunction(Name = "SetMeshIndicesFromScript", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private static void SetIndicesImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, Array indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	[FreeFunction(Name = "SetMeshIndicesFromNativeArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetIndicesNativeArrayImpl(int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private static void SetIndicesNativeArrayImpl_Injected(IntPtr _unity_self, int submesh, MeshTopology topology, IndexFormat indicesFormat, IntPtr indices, int arrayStart, int arraySize, bool calculateBounds, int baseVertex) { }

	private void SetListForChannel(VertexAttribute channel, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	private void SetListForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, List<T> values, int start, int length, MeshUpdateFlags flags) { }

	[FreeFunction(Name = "SetMeshComponentFromNativeArrayFromScript", HasExplicitThis = True)]
	private void SetNativeArrayForChannelImpl(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	private static void SetNativeArrayForChannelImpl_Injected(IntPtr _unity_self, VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int arraySize, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	public void SetNormals(NativeArray<T> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetNormals(NativeArray<T> inNormals, int start, int length) { }

	public void SetNormals(NativeArray<T> inNormals) { }

	public void SetNormals(Vector3[] inNormals, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetNormals(Vector3[] inNormals, int start, int length) { }

	public void SetNormals(Vector3[] inNormals) { }

	public void SetNormals(List<Vector3> inNormals, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetNormals(List<Vector3> inNormals, int start, int length) { }

	public void SetNormals(List<Vector3> inNormals) { }

	private void SetSizedArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, Array values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	private void SetSizedNativeArrayForChannel(VertexAttribute channel, VertexAttributeFormat format, int dim, IntPtr values, int valuesArrayLength, int valuesStart, int valuesCount, MeshUpdateFlags flags) { }

	[FreeFunction("MeshScripting::SetSubMesh", HasExplicitThis = True, ThrowsException = True)]
	public void SetSubMesh(int index, SubMeshDescriptor desc, MeshUpdateFlags flags = 0) { }

	private static void SetSubMesh_Injected(IntPtr _unity_self, int index, in SubMeshDescriptor desc, MeshUpdateFlags flags) { }

	public void SetSubMeshes(SubMeshDescriptor[] desc, int start, int count, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(SubMeshDescriptor[] desc, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(List<SubMeshDescriptor> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(List<SubMeshDescriptor> desc, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(NativeArray<T> desc, MeshUpdateFlags flags = 0) { }

	public void SetSubMeshes(NativeArray<T> desc, int start, int count, MeshUpdateFlags flags = 0) { }

	[ExcludeFromDocs]
	public void SetTangents(List<Vector4> inTangents, int start, int length) { }

	public void SetTangents(List<Vector4> inTangents) { }

	[ExcludeFromDocs]
	public void SetTangents(Vector4[] inTangents, int start, int length) { }

	[ExcludeFromDocs]
	public void SetTangents(NativeArray<T> inTangents, int start, int length) { }

	public void SetTangents(NativeArray<T> inTangents) { }

	public void SetTangents(Vector4[] inTangents, int start, int length, MeshUpdateFlags flags) { }

	public void SetTangents(Vector4[] inTangents) { }

	public void SetTangents(List<Vector4> inTangents, int start, int length, MeshUpdateFlags flags) { }

	public void SetTangents(NativeArray<T> inTangents, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetTriangles(Int32[] triangles, int submesh) { }

	[ExcludeFromDocs]
	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds) { }

	public void SetTriangles(Int32[] triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(Int32[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(UInt16[] triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh) { }

	[ExcludeFromDocs]
	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds) { }

	public void SetTriangles(List<Int32> triangles, int submesh, bool calculateBounds, int baseVertex) { }

	public void SetTriangles(List<Int32> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(List<UInt16> triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(UInt16[] triangles, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	public void SetTriangles(List<UInt16> triangles, int trianglesStart, int trianglesLength, int submesh, bool calculateBounds = true, int baseVertex = 0) { }

	private void SetTrianglesImpl(int submesh, IndexFormat indicesFormat, Array triangles, int trianglesArrayLength, int start, int length, bool calculateBounds, int baseVertex) { }

	public void SetUVs(int channel, Vector4[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector4> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector3> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector3> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector2> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, List<Vector2> uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs) { }

	public void SetUVs(int channel, List<Vector3> uvs) { }

	public void SetUVs(int channel, List<Vector2> uvs) { }

	public void SetUVs(int channel, Vector2[] uvs) { }

	public void SetUVs(int channel, Vector4[] uvs) { }

	public void SetUVs(int channel, Vector3[] uvs) { }

	public void SetUVs(int channel, Vector2[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector3[] uvs, int start, int length) { }

	public void SetUVs(int channel, Vector3[] uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector4[] uvs, int start, int length) { }

	public void SetUVs(int channel, NativeArray<T> uvs) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, NativeArray<T> uvs, int start, int length) { }

	public void SetUVs(int channel, NativeArray<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetUVs(int channel, Vector2[] uvs, int start, int length) { }

	public void SetUVs(int channel, List<Vector4> uvs, int start, int length, MeshUpdateFlags flags) { }

	private void SetUvsImpl(int uvIndex, int dim, Array uvs, int arrayStart, int arraySize, MeshUpdateFlags flags) { }

	private void SetUvsImpl(int uvIndex, int dim, List<T> uvs, int start, int length, MeshUpdateFlags flags) { }

	public void SetVertexBufferData(NativeArray<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferData(T[] data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferData(List<T> data, int dataStart, int meshBufferStart, int count, int stream = 0, MeshUpdateFlags flags = 0) { }

	public void SetVertexBufferParams(int vertexCount, NativeArray<VertexAttributeDescriptor> attributes) { }

	public void SetVertexBufferParams(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromArray", HasExplicitThis = True, ThrowsException = True)]
	private void SetVertexBufferParamsFromArray(int vertexCount, VertexAttributeDescriptor[] attributes) { }

	private static void SetVertexBufferParamsFromArray_Injected(IntPtr _unity_self, int vertexCount, ref ManagedSpanWrapper attributes) { }

	[FreeFunction(Name = "MeshScripting::SetVertexBufferParamsFromPtr", HasExplicitThis = True, ThrowsException = True)]
	private void SetVertexBufferParamsFromPtr(int vertexCount, IntPtr attributesPtr, int attributesCount) { }

	private static void SetVertexBufferParamsFromPtr_Injected(IntPtr _unity_self, int vertexCount, IntPtr attributesPtr, int attributesCount) { }

	public void SetVertices(Vector3[] inVertices) { }

	public void SetVertices(List<Vector3> inVertices, int start, int length, MeshUpdateFlags flags) { }

	[ExcludeFromDocs]
	public void SetVertices(List<Vector3> inVertices, int start, int length) { }

	[ExcludeFromDocs]
	public void SetVertices(Vector3[] inVertices, int start, int length) { }

	public void SetVertices(Vector3[] inVertices, int start, int length, MeshUpdateFlags flags) { }

	public void SetVertices(NativeArray<T> inVertices) { }

	[ExcludeFromDocs]
	public void SetVertices(NativeArray<T> inVertices, int start, int length) { }

	public void SetVertices(NativeArray<T> inVertices, int start, int length, MeshUpdateFlags flags) { }

	public void SetVertices(List<Vector3> inVertices) { }

	public void UploadMeshData(bool markNoLongerReadable) { }

	[NativeMethod("UploadMeshData")]
	private void UploadMeshDataImpl(bool markNoLongerReadable) { }

	private static void UploadMeshDataImpl_Injected(IntPtr _unity_self, bool markNoLongerReadable) { }

}

