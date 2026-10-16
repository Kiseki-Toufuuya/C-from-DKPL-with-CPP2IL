namespace UnityEngine;

[NativeHeader("Runtime/Graphics/WindowLayout.h")]
[NativeHeader("Runtime/Graphics/ScreenManager.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
[StaticAccessor("GetScreenManager()", StaticAccessorType::Dot (0))]
public sealed class Screen
{

	public static Resolution currentResolution
	{
		 get { } //Length: 51
	}

	public static float dpi
	{
		[NativeName("GetDPI")]
		 get { } //Length: 33
	}

	public static bool fullScreen
	{
		[NativeName("IsFullscreen")]
		 get { } //Length: 29
	}

	public static FullScreenMode fullScreenMode
	{
		[NativeName("GetFullscreenMode")]
		 get { } //Length: 29
	}

	public static int height
	{
		[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
		 get { } //Length: 29
	}

	public static ScreenOrientation orientation
	{
		 get { } //Length: 29
		 set { } //Length: 268
	}

	public static Resolution[] resolutions
	{
		[FreeFunction("ScreenScripting::GetResolutions")]
		 get { } //Length: 250
	}

	public static Rect safeArea
	{
		 get { } //Length: 51
	}

	[NativeProperty("ScreenTimeout")]
	public static int sleepTimeout
	{
		 set { } //Length: 40
	}

	public static int width
	{
		[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
		 get { } //Length: 29
	}

	public static Resolution get_currentResolution() { }

	private static void get_currentResolution_Injected(out Resolution ret) { }

	[NativeName("GetDPI")]
	public static float get_dpi() { }

	[NativeName("IsFullscreen")]
	public static bool get_fullScreen() { }

	[NativeName("GetFullscreenMode")]
	public static FullScreenMode get_fullScreenMode() { }

	[NativeMethod(Name = "GetHeight", IsThreadSafe = True)]
	public static int get_height() { }

	public static ScreenOrientation get_orientation() { }

	[FreeFunction("ScreenScripting::GetResolutions")]
	public static Resolution[] get_resolutions() { }

	private static void get_resolutions_Injected(out BlittableArrayWrapper ret) { }

	public static Rect get_safeArea() { }

	private static void get_safeArea_Injected(out Rect ret) { }

	[NativeMethod(Name = "GetWidth", IsThreadSafe = True)]
	public static int get_width() { }

	private static ScreenOrientation GetScreenOrientation() { }

	private static void RequestOrientation(ScreenOrientation orient) { }

	public static void set_orientation(ScreenOrientation value) { }

	public static void set_sleepTimeout(int value) { }

	[NativeName("RequestResolution")]
	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode, RefreshRate preferredRefreshRate) { }

	public static void SetResolution(int width, int height, FullScreenMode fullscreenMode) { }

	[EditorBrowsable(EditorBrowsableState::Never (1))]
	[Obsolete("SetResolution(int, int, bool, int) is obsolete. Use SetResolution(int, int, FullScreenMode, RefreshRate) instead.")]
	public static void SetResolution(int width, int height, bool fullscreen, int preferredRefreshRate) { }

	private static void SetResolution_Injected(int width, int height, FullScreenMode fullscreenMode, in RefreshRate preferredRefreshRate) { }

}

