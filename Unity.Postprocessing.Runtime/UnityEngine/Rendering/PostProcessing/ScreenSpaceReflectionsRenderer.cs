namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
internal sealed class ScreenSpaceReflectionsRenderer : PostProcessEffectRenderer<ScreenSpaceReflections>
{
	private enum Pass
	{
		Test = 0,
		Resolve = 1,
		Reproject = 2,
		Composite = 3,
	}

	private class QualityPreset
	{
		public int maximumIterationCount; //Field offset: 0x8
		public float thickness; //Field offset: 0xC
		public ScreenSpaceReflectionResolution downsampling; //Field offset: 0x10

		public QualityPreset() { }

	}

	private RenderTexture m_Resolve; //Field offset: 0x10
	private RenderTexture m_History; //Field offset: 0x14
	private Int32[] m_MipIDs; //Field offset: 0x18
	private readonly QualityPreset[] m_Presets; //Field offset: 0x1C

	public ScreenSpaceReflectionsRenderer() { }

	internal void CheckRT(ref RenderTexture rt, int width, int height, FilterMode filterMode, bool useMipMap) { }

	public virtual DepthTextureMode GetCameraFlags() { }

	public virtual void Release() { }

	public virtual void Render(PostProcessRenderContext context) { }

}

