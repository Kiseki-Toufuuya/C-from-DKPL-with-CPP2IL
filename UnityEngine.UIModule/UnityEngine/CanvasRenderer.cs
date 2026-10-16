namespace UnityEngine;

[NativeClass("UI::CanvasRenderer")]
[NativeHeader("Modules/UI/CanvasRenderer.h")]
public sealed class CanvasRenderer : Component
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <isMask>k__BackingField; //Field offset: 0xC

	public int absoluteDepth
	{
		 get { } //Length: 98
	}

	public Vector2 clippingSoftness
	{
		 get { } //Length: 121
		 set { } //Length: 102
	}

	[NativeProperty("ShouldCull", False, TargetType::Function (0))]
	public bool cull
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool cullTransparentMesh
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool hasMoved
	{
		 get { } //Length: 98
	}

	public bool hasPopInstruction
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[NativeProperty("RectClipping", False, TargetType::Function (0))]
	public bool hasRectClipping
	{
		 get { } //Length: 98
	}

	[Obsolete("isMask is no longer supported.See EnableClipping for vertex clipping configuration", False)]
	public bool isMask
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int materialCount
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int popMaterialCount
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	[NativeProperty("Depth", False, TargetType::Function (0))]
	public int relativeDepth
	{
		 get { } //Length: 98
	}

	public CanvasRenderer() { }

	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents) { }

	public static void AddUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents) { }

	public void Clear() { }

	private static void Clear_Injected(IntPtr _unity_self) { }

	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	public static void CreateUIVertexStream(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	private static void CreateUIVertexStreamInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents, object indices) { }

	public void DisableRectClipping() { }

	private static void DisableRectClipping_Injected(IntPtr _unity_self) { }

	public void EnableRectClipping(Rect rect) { }

	private static void EnableRectClipping_Injected(IntPtr _unity_self, in Rect rect) { }

	public int get_absoluteDepth() { }

	private static int get_absoluteDepth_Injected(IntPtr _unity_self) { }

	public Vector2 get_clippingSoftness() { }

	private static void get_clippingSoftness_Injected(IntPtr _unity_self, out Vector2 ret) { }

	public bool get_cull() { }

	private static bool get_cull_Injected(IntPtr _unity_self) { }

	public bool get_cullTransparentMesh() { }

	private static bool get_cullTransparentMesh_Injected(IntPtr _unity_self) { }

	public bool get_hasMoved() { }

	private static bool get_hasMoved_Injected(IntPtr _unity_self) { }

	public bool get_hasPopInstruction() { }

	private static bool get_hasPopInstruction_Injected(IntPtr _unity_self) { }

	public bool get_hasRectClipping() { }

	private static bool get_hasRectClipping_Injected(IntPtr _unity_self) { }

	[CompilerGenerated]
	public bool get_isMask() { }

	public int get_materialCount() { }

	private static int get_materialCount_Injected(IntPtr _unity_self) { }

	public int get_popMaterialCount() { }

	private static int get_popMaterialCount_Injected(IntPtr _unity_self) { }

	public int get_relativeDepth() { }

	private static int get_relativeDepth_Injected(IntPtr _unity_self) { }

	public float GetAlpha() { }

	public Color GetColor() { }

	private static void GetColor_Injected(IntPtr _unity_self, out Color ret) { }

	public float GetInheritedAlpha() { }

	private static float GetInheritedAlpha_Injected(IntPtr _unity_self) { }

	public Material GetMaterial(int index) { }

	public Material GetMaterial() { }

	private static IntPtr GetMaterial_Injected(IntPtr _unity_self, int index) { }

	public Mesh GetMesh() { }

	private static IntPtr GetMesh_Injected(IntPtr _unity_self) { }

	public Material GetPopMaterial(int index) { }

	private static IntPtr GetPopMaterial_Injected(IntPtr _unity_self, int index) { }

	public void set_clippingSoftness(Vector2 value) { }

	private static void set_clippingSoftness_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_cull(bool value) { }

	private static void set_cull_Injected(IntPtr _unity_self, bool value) { }

	public void set_cullTransparentMesh(bool value) { }

	private static void set_cullTransparentMesh_Injected(IntPtr _unity_self, bool value) { }

	public void set_hasPopInstruction(bool value) { }

	private static void set_hasPopInstruction_Injected(IntPtr _unity_self, bool value) { }

	[CompilerGenerated]
	public void set_isMask(bool value) { }

	public void set_materialCount(int value) { }

	private static void set_materialCount_Injected(IntPtr _unity_self, int value) { }

	public void set_popMaterialCount(int value) { }

	private static void set_popMaterialCount_Injected(IntPtr _unity_self, int value) { }

	public void SetAlpha(float alpha) { }

	public void SetAlphaTexture(Texture texture) { }

	private static void SetAlphaTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	public void SetColor(Color color) { }

	private static void SetColor_Injected(IntPtr _unity_self, in Color color) { }

	public void SetMaterial(Material material, int index) { }

	public void SetMaterial(Material material, Texture texture) { }

	private static void SetMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	public void SetMesh(Mesh mesh) { }

	private static void SetMesh_Injected(IntPtr _unity_self, IntPtr mesh) { }

	public void SetPopMaterial(Material material, int index) { }

	private static void SetPopMaterial_Injected(IntPtr _unity_self, IntPtr material, int index) { }

	public void SetTexture(Texture texture) { }

	private static void SetTexture_Injected(IntPtr _unity_self, IntPtr texture) { }

	[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
	public void SetVertices(UIVertex[] vertices, int size) { }

	[Obsolete("UI System now uses meshes.Generate a mesh and use 'SetMesh' instead", False)]
	public void SetVertices(List<UIVertex> vertices) { }

	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	private static void SplitIndicesStreamsInternal(object verts, object indices) { }

	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector4> uv2S, List<Vector4> uv3S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	public static void SplitUIVertexStreams(List<UIVertex> verts, List<Vector3> positions, List<Color32> colors, List<Vector4> uv0S, List<Vector4> uv1S, List<Vector3> normals, List<Vector4> tangents, List<Int32> indices) { }

	[StaticAccessor("UI", StaticAccessorType::DoubleColon (2))]
	private static void SplitUIVertexStreamsInternal(object verts, object positions, object colors, object uv0S, object uv1S, object uv2S, object uv3S, object normals, object tangents) { }

}

