namespace XeSys;

public class SystemManager : MonoBehaviour
{
	internal enum OverPermissionAspectResult
	{
		None = 0,
		HdivV = 1,
		VdivH = 2,
	}

	private static string XESYS_OBJECT_NAME; //Field offset: 0x0
	private const float permissionHdivVAspectRatio = 1.7827778; //Field offset: 0x0
	private const float permissionVdivHAspectRatio = 0.755; //Field offset: 0x0
	[CompilerGenerated]
	private static Vector2 <ScreenSize>k__BackingField; //Field offset: 0x4
	[CompilerGenerated]
	private static Vector2 <ScreenHalfSize>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private static float <ScreenAspect>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private static Vector2 <BaseScreenSize>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private static Vector2 <BaseScreenHalfSize>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private static float <BaseAspect>k__BackingField; //Field offset: 0x28
	[CompilerGenerated]
	private static Vector2 <AdjustScale>k__BackingField; //Field offset: 0x2C
	[CompilerGenerated]
	private static Vector2 <AdjustInvScale>k__BackingField; //Field offset: 0x34
	[CompilerGenerated]
	private static float <AdjustScaleValue>k__BackingField; //Field offset: 0x3C
	[CompilerGenerated]
	private static float <AdjustScaleInvValue>k__BackingField; //Field offset: 0x40
	public static bool isLongScreenDevice; //Field offset: 0x44
	public static Vector2 longScreenBaseSize; //Field offset: 0x48
	public static Vector2 longScreenReferenceResolution; //Field offset: 0x50
	public static Vector2 longScreenSizeWithSafeArea; //Field offset: 0x58
	public static Rect rawSafeAreaRect; //Field offset: 0x60
	public static Rect rawScreenAreaRect; //Field offset: 0x70
	[CompilerGenerated]
	private static bool <CanWideScreenMenu>k__BackingField; //Field offset: 0x80
	private static bool isForceWideScreen; //Field offset: 0x81
	private static SystemManager mInstance; //Field offset: 0x84
	[CompilerGenerated]
	private static long <gcMinUseMemorySize>k__BackingField; //Field offset: 0x88
	[CompilerGenerated]
	private static long <gcMaxUseMemorySize>k__BackingField; //Field offset: 0x90
	[CompilerGenerated]
	private static float <gcCheckTime>k__BackingField; //Field offset: 0x98
	public static ulong frameCounter; //Field offset: 0xA0
	public bool iPhoneXFlg; //Field offset: 0x10
	[SerializeField]
	private InputManager inputManagerPrefab; //Field offset: 0x14
	[SerializeField]
	private DebugTextRenderer debugTextRendererPrefab; //Field offset: 0x18
	[SerializeField]
	private DebugFPS debugFpsPrefab; //Field offset: 0x1C
	[SerializeField]
	private RenderSettings renderSettings; //Field offset: 0x20
	[CompilerGenerated]
	private Action <DoUpdate>k__BackingField; //Field offset: 0x24

	public private static Vector2 AdjustInvScale
	{
		[CompilerGenerated]
		 get { } //Length: 93
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private static Vector2 AdjustScale
	{
		[CompilerGenerated]
		 get { } //Length: 93
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private static float AdjustScaleInvValue
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		private set { } //Length: 72
	}

	public private static float AdjustScaleValue
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		private set { } //Length: 72
	}

	public static float BaseAspect
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		 set { } //Length: 72
	}

	public private static Vector2 BaseScreenHalfSize
	{
		[CompilerGenerated]
		 get { } //Length: 93
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public static Vector2 BaseScreenSize
	{
		[CompilerGenerated]
		 get { } //Length: 93
		[CompilerGenerated]
		 set { } //Length: 82
	}

	public private static bool CanWideScreenMenu
	{
		[CompilerGenerated]
		 get { } //Length: 64
		[CompilerGenerated]
		private set { } //Length: 86
	}

	public private Action DoUpdate
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	private static float gcCheckTime
	{
		[CompilerGenerated]
		private get { } //Length: 64
		[CompilerGenerated]
		private set { } //Length: 75
	}

	public private static long gcMaxUseMemorySize
	{
		[CompilerGenerated]
		 get { } //Length: 72
		[CompilerGenerated]
		private set { } //Length: 80
	}

	public private static long gcMinUseMemorySize
	{
		[CompilerGenerated]
		 get { } //Length: 72
		[CompilerGenerated]
		private set { } //Length: 80
	}

	public static bool HasSafeArea
	{
		 get { } //Length: 73
	}

	public static SystemManager Instance
	{
		 get { } //Length: 64
	}

	public static bool IsForceWideScreen
	{
		 get { } //Length: 64
	}

	public private static float ScreenAspect
	{
		[CompilerGenerated]
		 get { } //Length: 61
		[CompilerGenerated]
		private set { } //Length: 72
	}

	public private static Vector2 ScreenHalfSize
	{
		[CompilerGenerated]
		 get { } //Length: 93
		[CompilerGenerated]
		private set { } //Length: 82
	}

	public private static Vector2 ScreenSize
	{
		[CompilerGenerated]
		 get { } //Length: 93
		[CompilerGenerated]
		private set { } //Length: 82
	}

	private static SystemManager() { }

	public SystemManager() { }

	public void AddToSystemGroup(GameObject go) { }

	private void Awake() { }

	public OverPermissionAspectResult CheckOverPermissionAspectRatio() { }

	public static void Create() { }

	[CompilerGenerated]
	public static Vector2 get_AdjustInvScale() { }

	[CompilerGenerated]
	public static Vector2 get_AdjustScale() { }

	[CompilerGenerated]
	public static float get_AdjustScaleInvValue() { }

	[CompilerGenerated]
	public static float get_AdjustScaleValue() { }

	[CompilerGenerated]
	public static float get_BaseAspect() { }

	[CompilerGenerated]
	public static Vector2 get_BaseScreenHalfSize() { }

	[CompilerGenerated]
	public static Vector2 get_BaseScreenSize() { }

	[CompilerGenerated]
	public static bool get_CanWideScreenMenu() { }

	[CompilerGenerated]
	private Action get_DoUpdate() { }

	[CompilerGenerated]
	private static float get_gcCheckTime() { }

	[CompilerGenerated]
	public static long get_gcMaxUseMemorySize() { }

	[CompilerGenerated]
	public static long get_gcMinUseMemorySize() { }

	public static bool get_HasSafeArea() { }

	public static SystemManager get_Instance() { }

	public static bool get_IsForceWideScreen() { }

	[CompilerGenerated]
	public static float get_ScreenAspect() { }

	[CompilerGenerated]
	public static Vector2 get_ScreenHalfSize() { }

	[CompilerGenerated]
	public static Vector2 get_ScreenSize() { }

	public float GetScreenScreenAspect() { }

	public static bool IsExistGameObject(string _name) { }

	private void ResetGcMemoryProfile() { }

	[CompilerGenerated]
	private static void set_AdjustInvScale(Vector2 value) { }

	[CompilerGenerated]
	private static void set_AdjustScale(Vector2 value) { }

	[CompilerGenerated]
	private static void set_AdjustScaleInvValue(float value) { }

	[CompilerGenerated]
	private static void set_AdjustScaleValue(float value) { }

	[CompilerGenerated]
	public static void set_BaseAspect(float value) { }

	[CompilerGenerated]
	private static void set_BaseScreenHalfSize(Vector2 value) { }

	[CompilerGenerated]
	public static void set_BaseScreenSize(Vector2 value) { }

	[CompilerGenerated]
	private static void set_CanWideScreenMenu(bool value) { }

	[CompilerGenerated]
	public void set_DoUpdate(Action value) { }

	[CompilerGenerated]
	private static void set_gcCheckTime(float value) { }

	[CompilerGenerated]
	private static void set_gcMaxUseMemorySize(long value) { }

	[CompilerGenerated]
	private static void set_gcMinUseMemorySize(long value) { }

	[CompilerGenerated]
	private static void set_ScreenAspect(float value) { }

	[CompilerGenerated]
	private static void set_ScreenHalfSize(Vector2 value) { }

	[CompilerGenerated]
	private static void set_ScreenSize(Vector2 value) { }

	public void SetIPhoneX(bool fg1) { }

	private void Start() { }

	private void Update() { }

	public void UpdateScreenSize() { }

}

