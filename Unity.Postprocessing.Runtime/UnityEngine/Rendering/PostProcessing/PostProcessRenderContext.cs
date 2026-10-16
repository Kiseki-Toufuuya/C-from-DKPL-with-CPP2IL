namespace UnityEngine.Rendering.PostProcessing;

public sealed class PostProcessRenderContext
{
	internal enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3,
	}

	private Camera m_Camera; //Field offset: 0x8
	[CompilerGenerated]
	private CommandBuffer <command>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private RenderTargetIdentifier <source>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private RenderTargetIdentifier <destination>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private RenderTextureFormat <sourceFormat>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private bool <flip>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private PostProcessResources <resources>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private PropertySheetFactory <propertySheets>k__BackingField; //Field offset: 0x54
	[CompilerGenerated]
	private Dictionary<String, Object> <userData>k__BackingField; //Field offset: 0x58
	[CompilerGenerated]
	private PostProcessDebugLayer <debugLayer>k__BackingField; //Field offset: 0x5C
	[CompilerGenerated]
	private int <width>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private int <height>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private bool <stereoActive>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private int <xrActiveEye>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private int <numberOfEyes>k__BackingField; //Field offset: 0x70
	[CompilerGenerated]
	private StereoRenderingMode <stereoRenderingMode>k__BackingField; //Field offset: 0x74
	[CompilerGenerated]
	private int <screenWidth>k__BackingField; //Field offset: 0x78
	[CompilerGenerated]
	private int <screenHeight>k__BackingField; //Field offset: 0x7C
	[CompilerGenerated]
	private bool <isSceneView>k__BackingField; //Field offset: 0x80
	[CompilerGenerated]
	private Antialiasing <antialiasing>k__BackingField; //Field offset: 0x84
	[CompilerGenerated]
	private TemporalAntialiasing <temporalAntialiasing>k__BackingField; //Field offset: 0x88
	internal PropertySheet uberSheet; //Field offset: 0x8C
	internal Texture autoExposureTexture; //Field offset: 0x90
	internal LogHistogram logHistogram; //Field offset: 0x94
	internal Texture logLut; //Field offset: 0x98
	internal AutoExposure autoExposure; //Field offset: 0x9C
	internal int bloomBufferNameID; //Field offset: 0xA0
	internal bool physicalCamera; //Field offset: 0xA4
	private RenderTextureDescriptor m_sourceDescriptor; //Field offset: 0xA8

	public internal Antialiasing antialiasing
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 17
	}

	public Camera camera
	{
		 get { } //Length: 11
		 set { } //Length: 361
	}

	public CommandBuffer command
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public internal PostProcessDebugLayer debugLayer
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public RenderTargetIdentifier destination
	{
		[CompilerGenerated]
		 get { } //Length: 34
		[CompilerGenerated]
		 set { } //Length: 32
	}

	public bool flip
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private int height
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public internal bool isSceneView
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 17
	}

	public private int numberOfEyes
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public internal PropertySheetFactory propertySheets
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public internal PostProcessResources resources
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 27
	}

	public private int screenHeight
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private int screenWidth
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public RenderTargetIdentifier source
	{
		[CompilerGenerated]
		 get { } //Length: 34
		[CompilerGenerated]
		 set { } //Length: 32
	}

	public RenderTextureFormat sourceFormat
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public private bool stereoActive
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private StereoRenderingMode stereoRenderingMode
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public internal TemporalAntialiasing temporalAntialiasing
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		internal set { } //Length: 33
	}

	public private Dictionary<String, Object> userData
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public private int width
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public int xrActiveEye
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public PostProcessRenderContext() { }

	[CompilerGenerated]
	public Antialiasing get_antialiasing() { }

	public Camera get_camera() { }

	[CompilerGenerated]
	public CommandBuffer get_command() { }

	[CompilerGenerated]
	public PostProcessDebugLayer get_debugLayer() { }

	[CompilerGenerated]
	public RenderTargetIdentifier get_destination() { }

	[CompilerGenerated]
	public bool get_flip() { }

	[CompilerGenerated]
	public int get_height() { }

	[CompilerGenerated]
	public bool get_isSceneView() { }

	[CompilerGenerated]
	public int get_numberOfEyes() { }

	[CompilerGenerated]
	public PropertySheetFactory get_propertySheets() { }

	[CompilerGenerated]
	public PostProcessResources get_resources() { }

	[CompilerGenerated]
	public int get_screenHeight() { }

	[CompilerGenerated]
	public int get_screenWidth() { }

	[CompilerGenerated]
	public RenderTargetIdentifier get_source() { }

	[CompilerGenerated]
	public RenderTextureFormat get_sourceFormat() { }

	[CompilerGenerated]
	public bool get_stereoActive() { }

	[CompilerGenerated]
	public StereoRenderingMode get_stereoRenderingMode() { }

	[CompilerGenerated]
	public TemporalAntialiasing get_temporalAntialiasing() { }

	[CompilerGenerated]
	public Dictionary<String, Object> get_userData() { }

	[CompilerGenerated]
	public int get_width() { }

	[CompilerGenerated]
	public int get_xrActiveEye() { }

	internal RenderTextureDescriptor GetDescriptor(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0) { }

	public void GetScreenSpaceTemporaryRT(CommandBuffer cmd, int nameID, int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, FilterMode filter = 1, int widthOverride = 0, int heightOverride = 0) { }

	public RenderTexture GetScreenSpaceTemporaryRT(int depthBufferBits = 0, RenderTextureFormat colorFormat = 7, RenderTextureReadWrite readWrite = 0, int widthOverride = 0, int heightOverride = 0) { }

	public bool IsDebugOverlayEnabled(DebugOverlay overlay) { }

	public bool IsTemporalAntialiasingActive() { }

	public void PushDebugOverlay(CommandBuffer cmd, RenderTargetIdentifier source, PropertySheet sheet, int pass) { }

	public void Reset() { }

	[CompilerGenerated]
	internal void set_antialiasing(Antialiasing value) { }

	public void set_camera(Camera value) { }

	[CompilerGenerated]
	public void set_command(CommandBuffer value) { }

	[CompilerGenerated]
	internal void set_debugLayer(PostProcessDebugLayer value) { }

	[CompilerGenerated]
	public void set_destination(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	public void set_flip(bool value) { }

	[CompilerGenerated]
	private void set_height(int value) { }

	[CompilerGenerated]
	internal void set_isSceneView(bool value) { }

	[CompilerGenerated]
	private void set_numberOfEyes(int value) { }

	[CompilerGenerated]
	internal void set_propertySheets(PropertySheetFactory value) { }

	[CompilerGenerated]
	internal void set_resources(PostProcessResources value) { }

	[CompilerGenerated]
	private void set_screenHeight(int value) { }

	[CompilerGenerated]
	private void set_screenWidth(int value) { }

	[CompilerGenerated]
	public void set_source(RenderTargetIdentifier value) { }

	[CompilerGenerated]
	public void set_sourceFormat(RenderTextureFormat value) { }

	[CompilerGenerated]
	private void set_stereoActive(bool value) { }

	[CompilerGenerated]
	private void set_stereoRenderingMode(StereoRenderingMode value) { }

	[CompilerGenerated]
	internal void set_temporalAntialiasing(TemporalAntialiasing value) { }

	[CompilerGenerated]
	private void set_userData(Dictionary<String, Object> value) { }

	[CompilerGenerated]
	private void set_width(int value) { }

	[CompilerGenerated]
	public void set_xrActiveEye(int value) { }

	public void UpdateSinglePassStereoState(bool isTAAEnabled, bool isAOEnabled, bool isSSREnabled) { }

}

