namespace UnityEngine;

[NativeHeader("Runtime/Input/TimeManager.h")]
[StaticAccessor("GetTimeManager()", StaticAccessorType::Dot (0))]
public class Time
{

	public static float captureDeltaTime
	{
		 get { } //Length: 33
		 set { } //Length: 48
	}

	public static int captureFramerate
	{
		 get { } //Length: 385
		 set { } //Length: 89
	}

	public static float deltaTime
	{
		 get { } //Length: 33
	}

	public static float fixedDeltaTime
	{
		 get { } //Length: 33
		 set { } //Length: 48
	}

	public static float fixedTime
	{
		 get { } //Length: 33
	}

	public static float fixedUnscaledTime
	{
		 get { } //Length: 33
	}

	public static int frameCount
	{
		 get { } //Length: 29
	}

	public static float maximumDeltaTime
	{
		 get { } //Length: 33
	}

	[NativeProperty("Realtime")]
	public static float realtimeSinceStartup
	{
		 get { } //Length: 33
	}

	[NativeProperty("Realtime")]
	public static double realtimeSinceStartupAsDouble
	{
		 get { } //Length: 33
	}

	[NativeProperty("RenderFrameCount")]
	public static int renderedFrameCount
	{
		 get { } //Length: 29
	}

	public static float smoothDeltaTime
	{
		 get { } //Length: 33
	}

	[NativeProperty("CurTime")]
	public static float time
	{
		 get { } //Length: 33
	}

	[NativeProperty("CurTime")]
	public static double timeAsDouble
	{
		 get { } //Length: 33
	}

	[NativeProperty("CurTimeRational")]
	public static RationalTime timeAsRational
	{
		 get { } //Length: 51
	}

	public static float timeScale
	{
		 get { } //Length: 33
		 set { } //Length: 48
	}

	[NativeProperty("TimeSinceSceneLoad")]
	public static float timeSinceLevelLoad
	{
		 get { } //Length: 33
	}

	public static float unscaledDeltaTime
	{
		 get { } //Length: 33
	}

	public static float unscaledTime
	{
		 get { } //Length: 33
	}

	public static float get_captureDeltaTime() { }

	public static int get_captureFramerate() { }

	public static float get_deltaTime() { }

	public static float get_fixedDeltaTime() { }

	public static float get_fixedTime() { }

	public static float get_fixedUnscaledTime() { }

	public static int get_frameCount() { }

	public static float get_maximumDeltaTime() { }

	public static float get_realtimeSinceStartup() { }

	public static double get_realtimeSinceStartupAsDouble() { }

	public static int get_renderedFrameCount() { }

	public static float get_smoothDeltaTime() { }

	public static float get_time() { }

	public static double get_timeAsDouble() { }

	public static RationalTime get_timeAsRational() { }

	private static void get_timeAsRational_Injected(out RationalTime ret) { }

	public static float get_timeScale() { }

	public static float get_timeSinceLevelLoad() { }

	public static float get_unscaledDeltaTime() { }

	public static float get_unscaledTime() { }

	public static void set_captureDeltaTime(float value) { }

	public static void set_captureFramerate(int value) { }

	public static void set_fixedDeltaTime(float value) { }

	public static void set_timeScale(float value) { }

}

