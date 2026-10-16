namespace UnityEngine.Rendering.PostProcessing;

[Preserve]
public sealed class TemporalAntialiasing
{
	private enum Pass
	{
		SolverDilate = 0,
		SolverNoDilate = 1,
	}

	private const int k_SampleCount = 8; //Field offset: 0x0
	private const int k_NumEyes = 2; //Field offset: 0x0
	private const int k_NumHistoryTextures = 2; //Field offset: 0x0
	[Range(0.1, 1)]
	[Tooltip("The diameter (in texels) inside which jitter samples are spread. Smaller values result in crisper but more aliased output, while larger values result in more stable, but blurrier, output.")]
	public float jitterSpread; //Field offset: 0x8
	[Range(0, 3)]
	[Tooltip("Controls the amount of sharpening applied to the color buffer. High values may introduce dark-border artifacts.")]
	public float sharpness; //Field offset: 0xC
	[Range(0, 0.99)]
	[Tooltip("The blend coefficient for a stationary fragment. Controls the percentage of history sample blended into the final color.")]
	public float stationaryBlending; //Field offset: 0x10
	[Range(0, 0.99)]
	[Tooltip("The blend coefficient for a fragment with significant motion. Controls the percentage of history sample blended into the final color.")]
	public float motionBlending; //Field offset: 0x14
	public Func<Camera, Vector2, Matrix4x4> jitteredMatrixFunc; //Field offset: 0x18
	[CompilerGenerated]
	private Vector2 <jitter>k__BackingField; //Field offset: 0x1C
	private readonly RenderTargetIdentifier[] m_Mrt; //Field offset: 0x24
	private bool m_ResetHistory; //Field offset: 0x28
	[CompilerGenerated]
	private int <sampleIndex>k__BackingField; //Field offset: 0x2C
	private readonly RenderTexture[][] m_HistoryTextures; //Field offset: 0x30
	private readonly Int32[] m_HistoryPingPong; //Field offset: 0x34

	public private Vector2 jitter
	{
		[CompilerGenerated]
		 get { } //Length: 39
		[CompilerGenerated]
		private set { } //Length: 20
	}

	public private int sampleIndex
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public TemporalAntialiasing() { }

	private RenderTexture CheckHistory(int id, PostProcessRenderContext context) { }

	public void ConfigureJitteredProjectionMatrix(PostProcessRenderContext context) { }

	public void ConfigureStereoJitteredProjectionMatrices(PostProcessRenderContext context) { }

	private void GenerateHistoryName(RenderTexture rt, int id, PostProcessRenderContext context) { }

	private Vector2 GenerateRandomOffset() { }

	[CompilerGenerated]
	public Vector2 get_jitter() { }

	[CompilerGenerated]
	public int get_sampleIndex() { }

	internal DepthTextureMode GetCameraFlags() { }

	public Matrix4x4 GetJitteredProjectionMatrix(Camera camera) { }

	public bool IsSupported() { }

	internal void Release() { }

	internal void Render(PostProcessRenderContext context) { }

	internal void ResetHistory() { }

	[CompilerGenerated]
	private void set_jitter(Vector2 value) { }

	[CompilerGenerated]
	private void set_sampleIndex(int value) { }

}

