namespace UnityEngine;

[NativeHeader("Modules/ParticleSystem/ParticleSystemRenderer.h")]
[NativeHeader("ParticleSystemScriptingClasses.h")]
[NativeHeader("Modules/ParticleSystem/ScriptBindings/ParticleSystemRendererScriptBindings.h")]
[RequireComponent(typeof(Transform))]
public sealed class ParticleSystemRenderer : Renderer
{
	public struct BakeTextureOutput
	{
		[NativeName("first")]
		internal Texture2D vertices; //Field offset: 0x0
		[NativeName("second")]
		internal Texture2D indices; //Field offset: 0x4

	}


	public int activeTrailVertexStreamsCount
	{
		 get { } //Length: 98
	}

	public int activeVertexStreamsCount
	{
		 get { } //Length: 98
	}

	[NativeName("RenderAlignment")]
	public ParticleSystemRenderSpace alignment
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool allowRoll
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float cameraVelocityScale
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool enableGPUInstancing
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Vector3 flip
	{
		 get { } //Length: 120
		 set { } //Length: 102
	}

	public bool freeformStretching
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float lengthScale
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public SpriteMaskInteraction maskInteraction
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float maxParticleSize
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Mesh mesh
	{
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
		 get { } //Length: 120
		[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
		 set { } //Length: 145
	}

	public int meshCount
	{
		 get { } //Length: 98
	}

	public ParticleSystemMeshDistribution meshDistribution
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float minParticleSize
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float normalDirection
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	internal Material oldTrailMaterial
	{
		internal set { } //Length: 145
	}

	public Vector3 pivot
	{
		 get { } //Length: 120
		 set { } //Length: 102
	}

	public ParticleSystemRenderMode renderMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public bool rotateWithStretchDirection
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float shadowBias
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float sortingFudge
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public ParticleSystemSortMode sortMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Material trailMaterial
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public float velocityScale
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public ParticleSystemRenderer() { }

	[Obsolete("AreVertexStreamsEnabled is deprecated. Use GetActiveVertexStreams instead.", False)]
	public bool AreVertexStreamsEnabled(ParticleSystemVertexStreams streams) { }

	public void BakeMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	[Obsolete("BakeMesh with useTransform is deprecated. Use BakeMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeMesh(Mesh mesh, bool useTransform = false) { }

	public void BakeMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	private static void BakeMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, ParticleSystemBakeTextureOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	public int BakeTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTexture", HasExplicitThis = True)]
	private BakeTextureOutput BakeTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	private static void BakeTextureInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr indicesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, out int indexCount, out BakeTextureOutput ret) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTextureNoIndices", HasExplicitThis = True)]
	private Texture2D BakeTextureNoIndicesInternal(Texture2D verticesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	private static IntPtr BakeTextureNoIndicesInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeTrailsMesh(Mesh mesh, Camera camera, bool useTransform = false) { }

	[Obsolete("BakeTrailsMesh with useTransform is deprecated. Use BakeTrailsMesh with ParticleSystemBakeMeshOptions instead.", False)]
	public void BakeTrailsMesh(Mesh mesh, bool useTransform = false) { }

	public void BakeTrailsMesh(Mesh mesh, Camera camera, ParticleSystemBakeMeshOptions options) { }

	public void BakeTrailsMesh(Mesh mesh, ParticleSystemBakeMeshOptions options) { }

	private static void BakeTrailsMesh_Injected(IntPtr _unity_self, IntPtr mesh, IntPtr camera, ParticleSystemBakeMeshOptions options) { }

	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options) { }

	public int BakeTrailsTexture(ref Texture2D verticesTexture, ref Texture2D indicesTexture, ParticleSystemBakeTextureOptions options) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::BakeTrailsTexture", HasExplicitThis = True)]
	private BakeTextureOutput BakeTrailsTextureInternal(Texture2D verticesTexture, Texture2D indicesTexture, Camera camera, ParticleSystemBakeTextureOptions options, out int indexCount) { }

	private static void BakeTrailsTextureInternal_Injected(IntPtr _unity_self, IntPtr verticesTexture, IntPtr indicesTexture, IntPtr camera, ParticleSystemBakeTextureOptions options, out int indexCount, out BakeTextureOutput ret) { }

	[Obsolete("DisableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	public void DisableVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("EnableVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	public void EnableVertexStreams(ParticleSystemVertexStreams streams) { }

	public int get_activeTrailVertexStreamsCount() { }

	private static int get_activeTrailVertexStreamsCount_Injected(IntPtr _unity_self) { }

	public int get_activeVertexStreamsCount() { }

	private static int get_activeVertexStreamsCount_Injected(IntPtr _unity_self) { }

	public ParticleSystemRenderSpace get_alignment() { }

	private static ParticleSystemRenderSpace get_alignment_Injected(IntPtr _unity_self) { }

	public bool get_allowRoll() { }

	private static bool get_allowRoll_Injected(IntPtr _unity_self) { }

	public float get_cameraVelocityScale() { }

	private static float get_cameraVelocityScale_Injected(IntPtr _unity_self) { }

	public bool get_enableGPUInstancing() { }

	private static bool get_enableGPUInstancing_Injected(IntPtr _unity_self) { }

	public Vector3 get_flip() { }

	private static void get_flip_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public bool get_freeformStretching() { }

	private static bool get_freeformStretching_Injected(IntPtr _unity_self) { }

	public float get_lengthScale() { }

	private static float get_lengthScale_Injected(IntPtr _unity_self) { }

	public SpriteMaskInteraction get_maskInteraction() { }

	private static SpriteMaskInteraction get_maskInteraction_Injected(IntPtr _unity_self) { }

	public float get_maxParticleSize() { }

	private static float get_maxParticleSize_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMesh", HasExplicitThis = True)]
	public Mesh get_mesh() { }

	private static IntPtr get_mesh_Injected(IntPtr _unity_self) { }

	public int get_meshCount() { }

	private static int get_meshCount_Injected(IntPtr _unity_self) { }

	public ParticleSystemMeshDistribution get_meshDistribution() { }

	private static ParticleSystemMeshDistribution get_meshDistribution_Injected(IntPtr _unity_self) { }

	public float get_minParticleSize() { }

	private static float get_minParticleSize_Injected(IntPtr _unity_self) { }

	public float get_normalDirection() { }

	private static float get_normalDirection_Injected(IntPtr _unity_self) { }

	public Vector3 get_pivot() { }

	private static void get_pivot_Injected(IntPtr _unity_self, out Vector3 ret) { }

	public ParticleSystemRenderMode get_renderMode() { }

	private static ParticleSystemRenderMode get_renderMode_Injected(IntPtr _unity_self) { }

	public bool get_rotateWithStretchDirection() { }

	private static bool get_rotateWithStretchDirection_Injected(IntPtr _unity_self) { }

	public float get_shadowBias() { }

	private static float get_shadowBias_Injected(IntPtr _unity_self) { }

	public float get_sortingFudge() { }

	private static float get_sortingFudge_Injected(IntPtr _unity_self) { }

	public ParticleSystemSortMode get_sortMode() { }

	private static ParticleSystemSortMode get_sortMode_Injected(IntPtr _unity_self) { }

	public Material get_trailMaterial() { }

	private static IntPtr get_trailMaterial_Injected(IntPtr _unity_self) { }

	public float get_velocityScale() { }

	private static float get_velocityScale_Injected(IntPtr _unity_self) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveTrailVertexStreams", HasExplicitThis = True)]
	public void GetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	private static void GetActiveTrailVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetActiveVertexStreams", HasExplicitThis = True)]
	public void GetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	private static void GetActiveVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	[Obsolete("GetEnabledVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	public ParticleSystemVertexStreams GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshes", HasExplicitThis = True)]
	[RequiredByNativeCode]
	public int GetMeshes(out Mesh[] meshes) { }

	private static int GetMeshes_Injected(IntPtr _unity_self, out Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::GetMeshWeightings", HasExplicitThis = True)]
	public int GetMeshWeightings(out Single[] weightings) { }

	private static int GetMeshWeightings_Injected(IntPtr _unity_self, out BlittableArrayWrapper weightings) { }

	[Obsolete("Internal_GetVertexStreams is deprecated. Use GetActiveVertexStreams instead.", False)]
	internal ParticleSystemVertexStreams Internal_GetEnabledVertexStreams(ParticleSystemVertexStreams streams) { }

	[Obsolete("Internal_SetVertexStreams is deprecated. Use SetActiveVertexStreams instead.", False)]
	internal void Internal_SetVertexStreams(ParticleSystemVertexStreams streams, bool enabled) { }

	public void set_alignment(ParticleSystemRenderSpace value) { }

	private static void set_alignment_Injected(IntPtr _unity_self, ParticleSystemRenderSpace value) { }

	public void set_allowRoll(bool value) { }

	private static void set_allowRoll_Injected(IntPtr _unity_self, bool value) { }

	public void set_cameraVelocityScale(float value) { }

	private static void set_cameraVelocityScale_Injected(IntPtr _unity_self, float value) { }

	public void set_enableGPUInstancing(bool value) { }

	private static void set_enableGPUInstancing_Injected(IntPtr _unity_self, bool value) { }

	public void set_flip(Vector3 value) { }

	private static void set_flip_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_freeformStretching(bool value) { }

	private static void set_freeformStretching_Injected(IntPtr _unity_self, bool value) { }

	public void set_lengthScale(float value) { }

	private static void set_lengthScale_Injected(IntPtr _unity_self, float value) { }

	public void set_maskInteraction(SpriteMaskInteraction value) { }

	private static void set_maskInteraction_Injected(IntPtr _unity_self, SpriteMaskInteraction value) { }

	public void set_maxParticleSize(float value) { }

	private static void set_maxParticleSize_Injected(IntPtr _unity_self, float value) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMesh", HasExplicitThis = True)]
	public void set_mesh(Mesh value) { }

	private static void set_mesh_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_meshDistribution(ParticleSystemMeshDistribution value) { }

	private static void set_meshDistribution_Injected(IntPtr _unity_self, ParticleSystemMeshDistribution value) { }

	public void set_minParticleSize(float value) { }

	private static void set_minParticleSize_Injected(IntPtr _unity_self, float value) { }

	public void set_normalDirection(float value) { }

	private static void set_normalDirection_Injected(IntPtr _unity_self, float value) { }

	internal void set_oldTrailMaterial(Material value) { }

	private static void set_oldTrailMaterial_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_pivot(Vector3 value) { }

	private static void set_pivot_Injected(IntPtr _unity_self, in Vector3 value) { }

	public void set_renderMode(ParticleSystemRenderMode value) { }

	private static void set_renderMode_Injected(IntPtr _unity_self, ParticleSystemRenderMode value) { }

	public void set_rotateWithStretchDirection(bool value) { }

	private static void set_rotateWithStretchDirection_Injected(IntPtr _unity_self, bool value) { }

	public void set_shadowBias(float value) { }

	private static void set_shadowBias_Injected(IntPtr _unity_self, float value) { }

	public void set_sortingFudge(float value) { }

	private static void set_sortingFudge_Injected(IntPtr _unity_self, float value) { }

	public void set_sortMode(ParticleSystemSortMode value) { }

	private static void set_sortMode_Injected(IntPtr _unity_self, ParticleSystemSortMode value) { }

	public void set_trailMaterial(Material value) { }

	private static void set_trailMaterial_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_velocityScale(float value) { }

	private static void set_velocityScale_Injected(IntPtr _unity_self, float value) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveTrailVertexStreams", HasExplicitThis = True)]
	public void SetActiveTrailVertexStreams(List<ParticleSystemVertexStream> streams) { }

	private static void SetActiveTrailVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetActiveVertexStreams", HasExplicitThis = True)]
	public void SetActiveVertexStreams(List<ParticleSystemVertexStream> streams) { }

	private static void SetActiveVertexStreams_Injected(IntPtr _unity_self, ref BlittableListWrapper streams) { }

	public void SetMeshes(Mesh[] meshes) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshes", HasExplicitThis = True)]
	public void SetMeshes(Mesh[] meshes, int size) { }

	private static void SetMeshes_Injected(IntPtr _unity_self, Mesh[] meshes, int size) { }

	[FreeFunction(Name = "ParticleSystemRendererScriptBindings::SetMeshWeightings", HasExplicitThis = True)]
	public void SetMeshWeightings(Single[] weightings, int size) { }

	public void SetMeshWeightings(Single[] weightings) { }

	private static void SetMeshWeightings_Injected(IntPtr _unity_self, ref ManagedSpanWrapper weightings, int size) { }

}

