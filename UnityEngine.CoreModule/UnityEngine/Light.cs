namespace UnityEngine;

[NativeHeader("Runtime/Camera/Light.h")]
[NativeHeader("Runtime/Export/Graphics/Light.bindings.h")]
[RequireComponent(typeof(Transform))]
[RequireComponent(typeof(Transform))]
public sealed class Light : Behaviour
{

	public LightBakingOutput bakingOutput
	{
		 get { } //Length: 119
	}

	public float bounceIntensity
	{
		 get { } //Length: 102
	}

	public Color color
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public float colorTemperature
	{
		 get { } //Length: 102
	}

	public Texture cookie
	{
		 get { } //Length: 120
	}

	public float cookieSize
	{
		 get { } //Length: 102
	}

	public float dilatedRange
	{
		 get { } //Length: 102
	}

	public float intensity
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float range
	{
		 get { } //Length: 102
	}

	public LightShadows shadows
	{
		[NativeMethod("GetShadowType")]
		 get { } //Length: 98
	}

	public float shadowStrength
	{
		 get { } //Length: 102
		[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
		 set { } //Length: 109
	}

	public float spotAngle
	{
		 get { } //Length: 102
	}

	[NativeProperty("LightType")]
	public LightType type
	{
		 get { } //Length: 98
	}

	public bool useColorTemperature
	{
		 get { } //Length: 98
	}

	public LightBakingOutput get_bakingOutput() { }

	private static void get_bakingOutput_Injected(IntPtr _unity_self, out LightBakingOutput ret) { }

	public float get_bounceIntensity() { }

	private static float get_bounceIntensity_Injected(IntPtr _unity_self) { }

	public Color get_color() { }

	private static void get_color_Injected(IntPtr _unity_self, out Color ret) { }

	public float get_colorTemperature() { }

	private static float get_colorTemperature_Injected(IntPtr _unity_self) { }

	public Texture get_cookie() { }

	private static IntPtr get_cookie_Injected(IntPtr _unity_self) { }

	public float get_cookieSize() { }

	private static float get_cookieSize_Injected(IntPtr _unity_self) { }

	public float get_dilatedRange() { }

	private static float get_dilatedRange_Injected(IntPtr _unity_self) { }

	public float get_intensity() { }

	private static float get_intensity_Injected(IntPtr _unity_self) { }

	public float get_range() { }

	private static float get_range_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetShadowType")]
	public LightShadows get_shadows() { }

	private static LightShadows get_shadows_Injected(IntPtr _unity_self) { }

	public float get_shadowStrength() { }

	private static float get_shadowStrength_Injected(IntPtr _unity_self) { }

	public float get_spotAngle() { }

	private static float get_spotAngle_Injected(IntPtr _unity_self) { }

	public LightType get_type() { }

	private static LightType get_type_Injected(IntPtr _unity_self) { }

	public bool get_useColorTemperature() { }

	private static bool get_useColorTemperature_Injected(IntPtr _unity_self) { }

	public void set_color(Color value) { }

	private static void set_color_Injected(IntPtr _unity_self, in Color value) { }

	public void set_intensity(float value) { }

	private static void set_intensity_Injected(IntPtr _unity_self, float value) { }

	[FreeFunction("Light_Bindings::SetShadowStrength", HasExplicitThis = True)]
	public void set_shadowStrength(float value) { }

	private static void set_shadowStrength_Injected(IntPtr _unity_self, float value) { }

}

