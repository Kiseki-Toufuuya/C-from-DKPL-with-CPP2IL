namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class MultiScaleVO : IAmbientOcclusionMethod
{
	public enum MipLevel
	{
		Original = 0,
		L1 = 1,
		L2 = 2,
		L3 = 3,
		L4 = 4,
		L5 = 5,
		L6 = 6,
	}

	private enum Pass
	{
		DepthCopy = 0,
		CompositionDeferred = 1,
		CompositionForward = 2,
		DebugOverlay = 3,
	}

	private readonly Single[] m_SampleThickness; //Field offset: 0x8
	private readonly Single[] m_InvThicknessTable; //Field offset: 0xC
	private readonly Single[] m_SampleWeightTable; //Field offset: 0x10
	private readonly Int32[] m_Widths; //Field offset: 0x14
	private readonly Int32[] m_Heights; //Field offset: 0x18
	private readonly Int32[] m_ScaledWidths; //Field offset: 0x1C
	private readonly Int32[] m_ScaledHeights; //Field offset: 0x20
	private AmbientOcclusion m_Settings; //Field offset: 0x24
	private PropertySheet m_PropertySheet; //Field offset: 0x28
	private PostProcessResources m_Resources; //Field offset: 0x2C
	private RenderTexture m_AmbientOnlyAO; //Field offset: 0x30
	private RenderTextureFormat m_R8Format; //Field offset: 0x34
	private RenderTextureFormat m_R16Format; //Field offset: 0x38
	private bool float4Texture; //Field offset: 0x3C
	private readonly RenderTargetIdentifier[] m_MRT; //Field offset: 0x40

	public MultiScaleVO(AmbientOcclusion settings) { }

	private void Alloc(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale) { }

	private void AllocArray(CommandBuffer cmd, int id, MipLevel size, RenderTextureFormat format, bool uav, bool dynamicScale) { }

	private float CalculateTanHalfFovHeight(Camera camera) { }

	private Vector4 CalculateZBufferParams(Camera camera) { }

	private void CheckAOTexture(PostProcessRenderContext context) { }

	public override void CompositeAmbientOnly(PostProcessRenderContext context) { }

	public void GenerateAOMap(CommandBuffer cmd, Camera camera, RenderTargetIdentifier destination, Nullable<RenderTargetIdentifier> depthMap, bool invert, bool isMSAA) { }

	public override DepthTextureMode GetCameraFlags() { }

	private Vector2 GetSize(MipLevel mip) { }

	private Vector3 GetSizeArray(MipLevel mip) { }

	private void PreparePropertySheet(PostProcessRenderContext context) { }

	private void PushAllocCommands(CommandBuffer cmd, bool isMSAA, Camera camera) { }

	private void PushDebug(PostProcessRenderContext context) { }

	private void PushDownsampleCommands(CommandBuffer cmd, Camera camera, Nullable<RenderTargetIdentifier> depthMap, bool isMSAA) { }

	private void PushReleaseCommands(CommandBuffer cmd) { }

	private void PushRenderCommands(CommandBuffer cmd, int source, int destination, Vector3 sourceSize, float tanHalfFovH, bool isMSAA) { }

	private void PushUpsampleCommands(CommandBuffer cmd, int lowResDepth, int interleavedAO, int highResDepth, Nullable<Int32> highResAO, RenderTargetIdentifier dest, Vector3 lowResDepthSize, Vector2 highResDepthSize, bool isMSAA, bool invert = false) { }

	private void Release(CommandBuffer cmd, int id) { }

	public override void Release() { }

	public override void RenderAfterOpaque(PostProcessRenderContext context) { }

	public override void RenderAmbientOnly(PostProcessRenderContext context) { }

	public void SetResources(PostProcessResources resources) { }

}

