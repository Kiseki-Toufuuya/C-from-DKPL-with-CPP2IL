namespace XeSys.Gfx;

public class RenderManager : SingletonBehaviour<RenderManager>
{
	internal enum LetterBoxDirection
	{
		TopBottom = 0,
		LeftRight = 1,
	}

	[CompilerGenerated]
	private static RenderSettings <settings>k__BackingField; //Field offset: 0x0
	[CompilerGenerated]
	private static Vector2 <baseSize>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static Vector2 <baseHalfSize>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private static float <baseAspect>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private static Vector2 <startScreenSize>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private static Vector2 <screenSize>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private static Vector2 <screenHalfSize>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private static float <screenAspect>k__BackingField; //Field offset: 0x30
	[CompilerGenerated]
	private static Vector2 <adjustScale>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private static Vector2 <adjustInvScale>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private static float <adjustScaleValue>k__BackingField; //Field offset: 0x44
	[CompilerGenerated]
	private static float <adjustScaleInvValue>k__BackingField; //Field offset: 0x48
	[CompilerGenerated]
	private static float <renderingScale>k__BackingField; //Field offset: 0x4C
	[CompilerGenerated]
	private static Rect <renderingRect>k__BackingField; //Field offset: 0x50
	[CompilerGenerated]
	private static uGUILetterBoxController <letterBox>k__BackingField; //Field offset: 0x60
	[CompilerGenerated]
	private static uGUIFader <fader>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private static LetterBoxDirection <letterBoxDirection>k__BackingField; //Field offset: 0x68
	[CompilerGenerated]
	private static Canvas <systemCanvas>k__BackingField; //Field offset: 0x6C
	[CompilerGenerated]
	private static GameObject <systemCanvasSafeArea>k__BackingField; //Field offset: 0x70
	private static Vector2 mOffset; //Field offset: 0x74
	private RenderSettings mLocalSettings; //Field offset: 0x10

	public private static Vector2 adjustInvScale
	{
		[CompilerGenerated]
		 get { } //Length: 73
		[CompilerGenerated]
		private set { } //Length: 54
	}

	public private static Vector2 adjustScale
	{
		[CompilerGenerated]
		 get { } //Length: 73
		[CompilerGenerated]
		private set { } //Length: 54
	}

	public private static float adjustScaleInvValue
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 52
	}

	public private static float adjustScaleValue
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 52
	}

	public private static float baseAspect
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 52
	}

	public private static Vector2 baseHalfSize
	{
		[CompilerGenerated]
		 get { } //Length: 73
		[CompilerGenerated]
		private set { } //Length: 54
	}

	public private static Vector2 baseSize
	{
		[CompilerGenerated]
		 get { } //Length: 73
		[CompilerGenerated]
		private set { } //Length: 54
	}

	public private static uGUIFader fader
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public private static uGUILetterBoxController letterBox
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public private static LetterBoxDirection letterBoxDirection
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 48
	}

	public static Vector2 offset
	{
		 get { } //Length: 73
	}

	public private static Rect renderingRect
	{
		[CompilerGenerated]
		 get { } //Length: 52
		[CompilerGenerated]
		private set { } //Length: 50
	}

	public private static float renderingScale
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 52
	}

	public private static float screenAspect
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 52
	}

	public private static Vector2 screenHalfSize
	{
		[CompilerGenerated]
		 get { } //Length: 73
		[CompilerGenerated]
		private set { } //Length: 54
	}

	public private static Vector2 screenSize
	{
		[CompilerGenerated]
		 get { } //Length: 73
		[CompilerGenerated]
		private set { } //Length: 54
	}

	public private static RenderSettings settings
	{
		[CompilerGenerated]
		private get { } //Length: 40
		[CompilerGenerated]
		 set { } //Length: 64
	}

	public private static Vector2 startScreenSize
	{
		[CompilerGenerated]
		 get { } //Length: 73
		[CompilerGenerated]
		private set { } //Length: 54
	}

	public private static Canvas systemCanvas
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		private set { } //Length: 69
	}

	public static GameObject systemCanvasSafeArea
	{
		[CompilerGenerated]
		 get { } //Length: 41
		[CompilerGenerated]
		 set { } //Length: 69
	}

	public RenderManager() { }

	public static Vector3 AppToScreenPosition(Vector3 appPosi) { }

	public static Vector2 AppToScreenPosition(Vector2 appPosi) { }

	protected virtual void Awake() { }

	public void ChangeBaseSize(int width, int height) { }

	public void ChangeBaseSize(Vector2 size) { }

	public static void ChangeResolution(Vector2 size, int refreshRate = 0) { }

	public static void ChangeResolution(int width, int height, int refreshRate = 0) { }

	public void ChangeSettings(RenderSettings _settings) { }

	[CompilerGenerated]
	public static Vector2 get_adjustInvScale() { }

	[CompilerGenerated]
	public static Vector2 get_adjustScale() { }

	[CompilerGenerated]
	public static float get_adjustScaleInvValue() { }

	[CompilerGenerated]
	public static float get_adjustScaleValue() { }

	[CompilerGenerated]
	public static float get_baseAspect() { }

	[CompilerGenerated]
	public static Vector2 get_baseHalfSize() { }

	[CompilerGenerated]
	public static Vector2 get_baseSize() { }

	[CompilerGenerated]
	public static uGUIFader get_fader() { }

	[CompilerGenerated]
	public static uGUILetterBoxController get_letterBox() { }

	[CompilerGenerated]
	public static LetterBoxDirection get_letterBoxDirection() { }

	public static Vector2 get_offset() { }

	[CompilerGenerated]
	public static Rect get_renderingRect() { }

	[CompilerGenerated]
	public static float get_renderingScale() { }

	[CompilerGenerated]
	public static float get_screenAspect() { }

	[CompilerGenerated]
	public static Vector2 get_screenHalfSize() { }

	[CompilerGenerated]
	public static Vector2 get_screenSize() { }

	[CompilerGenerated]
	private static RenderSettings get_settings() { }

	[CompilerGenerated]
	public static Vector2 get_startScreenSize() { }

	[CompilerGenerated]
	public static Canvas get_systemCanvas() { }

	[CompilerGenerated]
	public static GameObject get_systemCanvasSafeArea() { }

	public void Initialize(RenderSettings _settings) { }

	public static Rect MakeScreenRect(float rx, float ry, float rw, float rh) { }

	public static void ResetResolution() { }

	public static Vector3 ScreenToAppPosition(Vector3 screenPosition) { }

	[CompilerGenerated]
	private static void set_adjustInvScale(Vector2 value) { }

	[CompilerGenerated]
	private static void set_adjustScale(Vector2 value) { }

	[CompilerGenerated]
	private static void set_adjustScaleInvValue(float value) { }

	[CompilerGenerated]
	private static void set_adjustScaleValue(float value) { }

	[CompilerGenerated]
	private static void set_baseAspect(float value) { }

	[CompilerGenerated]
	private static void set_baseHalfSize(Vector2 value) { }

	[CompilerGenerated]
	private static void set_baseSize(Vector2 value) { }

	[CompilerGenerated]
	private static void set_fader(uGUIFader value) { }

	[CompilerGenerated]
	private static void set_letterBox(uGUILetterBoxController value) { }

	[CompilerGenerated]
	private static void set_letterBoxDirection(LetterBoxDirection value) { }

	[CompilerGenerated]
	private static void set_renderingRect(Rect value) { }

	[CompilerGenerated]
	private static void set_renderingScale(float value) { }

	[CompilerGenerated]
	private static void set_screenAspect(float value) { }

	[CompilerGenerated]
	private static void set_screenHalfSize(Vector2 value) { }

	[CompilerGenerated]
	private static void set_screenSize(Vector2 value) { }

	[CompilerGenerated]
	public static void set_settings(RenderSettings value) { }

	[CompilerGenerated]
	private static void set_startScreenSize(Vector2 value) { }

	[CompilerGenerated]
	private static void set_systemCanvas(Canvas value) { }

	[CompilerGenerated]
	public static void set_systemCanvasSafeArea(GameObject value) { }

	private void Start() { }

	public static Vector3 UnityToAppPosition(Vector3 unityPosi) { }

	private void Update() { }

	private void UpdateBaseParameter() { }

	private void UpdateParameter() { }

	private void UpdateScreenParam(int width, int height) { }

}

