namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessDebugLayer
{
	internal class OverlaySettings
	{
		public bool linearDepth; //Field offset: 0x8
		[Range(0, 16)]
		public float motionColorIntensity; //Field offset: 0xC
		[Range(4, 128)]
		public int motionGridSize; //Field offset: 0x10
		public ColorBlindnessType colorBlindnessType; //Field offset: 0x14
		[Range(0, 1)]
		public float colorBlindnessStrength; //Field offset: 0x18

		public OverlaySettings() { }

	}

	public LightMeterMonitor lightMeter; //Field offset: 0x8
	public HistogramMonitor histogram; //Field offset: 0xC
	public WaveformMonitor waveform; //Field offset: 0x10
	public VectorscopeMonitor vectorscope; //Field offset: 0x14
	private Dictionary<MonitorType, Monitor> m_Monitors; //Field offset: 0x18
	private int frameWidth; //Field offset: 0x1C
	private int frameHeight; //Field offset: 0x20
	[CompilerGenerated]
	private RenderTexture <debugOverlayTarget>k__BackingField; //Field offset: 0x24
	[CompilerGenerated]
	private bool <debugOverlayActive>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private DebugOverlay <debugOverlay>k__BackingField; //Field offset: 0x2C
	public OverlaySettings overlaySettings; //Field offset: 0x30

	public private DebugOverlay debugOverlay
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool debugOverlayActive
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private RenderTexture debugOverlayTarget
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public PostProcessDebugLayer() { }

	private void DestroyDebugOverlayTarget() { }

	internal void EndFrame() { }

	[CompilerGenerated]
	public DebugOverlay get_debugOverlay() { }

	[CompilerGenerated]
	public bool get_debugOverlayActive() { }

	[CompilerGenerated]
	public RenderTexture get_debugOverlayTarget() { }

	internal DepthTextureMode GetCameraFlags() { }

	internal void OnDisable() { }

	internal void OnEnable() { }

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	internal void RenderMonitors(PostProcessRenderContext context) { }

	internal void RenderSpecialOverlays(PostProcessRenderContext context) { }

	public void RequestDebugOverlay(DebugOverlay mode) { }

	public void RequestMonitorPass(MonitorType monitor) { }

	[CompilerGenerated]
	private void set_debugOverlay(DebugOverlay value) { }

	[CompilerGenerated]
	private void set_debugOverlayActive(bool value) { }

	[CompilerGenerated]
	private void set_debugOverlayTarget(RenderTexture value) { }

	internal void SetFrameSize(int width, int height) { }

}

