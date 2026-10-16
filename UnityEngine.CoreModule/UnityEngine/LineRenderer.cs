namespace UnityEngine;

[NativeHeader("Runtime/Graphics/LineRenderer.h")]
[NativeHeader("Runtime/Graphics/GraphicsScriptBindings.h")]
public sealed class LineRenderer : Renderer
{

	public Color endColor
	{
		 set { } //Length: 102
	}

	public float endWidth
	{
		 set { } //Length: 109
	}

	public bool loop
	{
		 set { } //Length: 101
	}

	[NativeProperty("PositionsCount")]
	public int positionCount
	{
		 set { } //Length: 101
	}

	public Color startColor
	{
		 set { } //Length: 102
	}

	public float startWidth
	{
		 set { } //Length: 109
	}

	public float widthMultiplier
	{
		 set { } //Length: 109
	}

	public LineRenderer() { }

	public Vector3 GetPosition(int index) { }

	private static void GetPosition_Injected(IntPtr _unity_self, int index, out Vector3 ret) { }

	public void set_endColor(Color value) { }

	private static void set_endColor_Injected(IntPtr _unity_self, in Color value) { }

	public void set_endWidth(float value) { }

	private static void set_endWidth_Injected(IntPtr _unity_self, float value) { }

	public void set_loop(bool value) { }

	private static void set_loop_Injected(IntPtr _unity_self, bool value) { }

	public void set_positionCount(int value) { }

	private static void set_positionCount_Injected(IntPtr _unity_self, int value) { }

	public void set_startColor(Color value) { }

	private static void set_startColor_Injected(IntPtr _unity_self, in Color value) { }

	public void set_startWidth(float value) { }

	private static void set_startWidth_Injected(IntPtr _unity_self, float value) { }

	public void set_widthMultiplier(float value) { }

	private static void set_widthMultiplier_Injected(IntPtr _unity_self, float value) { }

	[Obsolete("Use startColor, endColor or colorGradient instead.", False)]
	public void SetColors(Color start, Color end) { }

	public void SetPosition(int index, Vector3 position) { }

	private static void SetPosition_Injected(IntPtr _unity_self, int index, in Vector3 position) { }

	[Obsolete("Use startWidth, endWidth or widthCurve instead.", False)]
	public void SetWidth(float start, float end) { }

}

