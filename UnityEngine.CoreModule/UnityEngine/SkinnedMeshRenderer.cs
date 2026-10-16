namespace UnityEngine;

[NativeHeader("Runtime/Graphics/Mesh/SkinnedMeshRenderer.h")]
[RequiredByNativeCode]
public class SkinnedMeshRenderer : Renderer
{

	public Transform[] bones
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool forceMatrixRecalculationPerRender
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public SkinQuality quality
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Transform rootBone
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	[NativeProperty("Mesh")]
	public Mesh sharedMesh
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	[NativeProperty("SkinnedMeshMotionVectors")]
	public bool skinnedMotionVectors
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool updateWhenOffscreen
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Target vertexBufferTarget
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public SkinnedMeshRenderer() { }

	public void BakeMesh(Mesh mesh, bool useScale) { }

	public void BakeMesh(Mesh mesh) { }

	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, bool useScale) { }

	public Transform[] get_bones() { }

	private static Transform[] get_bones_Injected(IntPtr _unity_self) { }

	public bool get_forceMatrixRecalculationPerRender() { }

	private static bool get_forceMatrixRecalculationPerRender_Injected(IntPtr _unity_self) { }

	public SkinQuality get_quality() { }

	private static SkinQuality get_quality_Injected(IntPtr _unity_self) { }

	public Transform get_rootBone() { }

	private static IntPtr get_rootBone_Injected(IntPtr _unity_self) { }

	public Mesh get_sharedMesh() { }

	private static IntPtr get_sharedMesh_Injected(IntPtr _unity_self) { }

	public bool get_skinnedMotionVectors() { }

	private static bool get_skinnedMotionVectors_Injected(IntPtr _unity_self) { }

	public bool get_updateWhenOffscreen() { }

	private static bool get_updateWhenOffscreen_Injected(IntPtr _unity_self) { }

	public Target get_vertexBufferTarget() { }

	private static Target get_vertexBufferTarget_Injected(IntPtr _unity_self) { }

	public float GetBlendShapeWeight(int index) { }

	private static float GetBlendShapeWeight_Injected(IntPtr _unity_self, int index) { }

	public GraphicsBuffer GetPreviousVertexBuffer() { }

	[FreeFunction(Name = "SkinnedMeshRendererScripting::GetPreviousVertexBufferPtr", HasExplicitThis = True)]
	private GraphicsBuffer GetPreviousVertexBufferImpl() { }

	private static IntPtr GetPreviousVertexBufferImpl_Injected(IntPtr _unity_self) { }

	public GraphicsBuffer GetVertexBuffer() { }

	[FreeFunction(Name = "SkinnedMeshRendererScripting::GetVertexBufferPtr", HasExplicitThis = True)]
	private GraphicsBuffer GetVertexBufferImpl() { }

	private static IntPtr GetVertexBufferImpl_Injected(IntPtr _unity_self) { }

	public void set_bones(Transform[] value) { }

	private static void set_bones_Injected(IntPtr _unity_self, Transform[] value) { }

	public void set_forceMatrixRecalculationPerRender(bool value) { }

	private static void set_forceMatrixRecalculationPerRender_Injected(IntPtr _unity_self, bool value) { }

	public void set_quality(SkinQuality value) { }

	private static void set_quality_Injected(IntPtr _unity_self, SkinQuality value) { }

	public void set_rootBone(Transform value) { }

	private static void set_rootBone_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_sharedMesh(Mesh value) { }

	private static void set_sharedMesh_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_skinnedMotionVectors(bool value) { }

	private static void set_skinnedMotionVectors_Injected(IntPtr _unity_self, bool value) { }

	public void set_updateWhenOffscreen(bool value) { }

	private static void set_updateWhenOffscreen_Injected(IntPtr _unity_self, bool value) { }

	public void set_vertexBufferTarget(Target value) { }

	private static void set_vertexBufferTarget_Injected(IntPtr _unity_self, Target value) { }

	public void SetBlendShapeWeight(int index, float value) { }

	private static void SetBlendShapeWeight_Injected(IntPtr _unity_self, int index, float value) { }

}

