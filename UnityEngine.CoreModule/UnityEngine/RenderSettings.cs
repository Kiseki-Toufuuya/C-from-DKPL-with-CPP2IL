namespace UnityEngine;

[NativeHeader("Runtime/Camera/RenderSettings.h")]
[NativeHeader("Runtime/Graphics/QualitySettingsTypes.h")]
[StaticAccessor("GetRenderSettings()", StaticAccessorType::Dot (0))]
public sealed class RenderSettings : object
{

	[NativeProperty("UseFog")]
	public static bool fog
	{
		 get { } //Length: 29
	}

	public static Color fogColor
	{
		 get { } //Length: 51
	}

	public static float fogDensity
	{
		 get { } //Length: 33
	}

	[NativeProperty("LinearFogEnd")]
	public static float fogEndDistance
	{
		 get { } //Length: 33
	}

	[NativeProperty("LinearFogStart")]
	public static float fogStartDistance
	{
		 get { } //Length: 33
	}

	public static bool get_fog() { }

	public static Color get_fogColor() { }

	private static void get_fogColor_Injected(out Color ret) { }

	public static float get_fogDensity() { }

	public static float get_fogEndDistance() { }

	public static float get_fogStartDistance() { }

}

