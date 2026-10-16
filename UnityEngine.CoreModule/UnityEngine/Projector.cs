namespace UnityEngine;

[NativeHeader("Runtime/Camera/Projector.h")]
public sealed class Projector : Behaviour
{

	public float aspectRatio
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float farClipPlane
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float fieldOfView
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public int ignoreLayers
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Material material
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	public float nearClipPlane
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public bool orthographic
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public float orthographicSize
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Projector() { }

	public float get_aspectRatio() { }

	private static float get_aspectRatio_Injected(IntPtr _unity_self) { }

	public float get_farClipPlane() { }

	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	public float get_fieldOfView() { }

	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	public int get_ignoreLayers() { }

	private static int get_ignoreLayers_Injected(IntPtr _unity_self) { }

	public Material get_material() { }

	private static IntPtr get_material_Injected(IntPtr _unity_self) { }

	public float get_nearClipPlane() { }

	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	public bool get_orthographic() { }

	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	public float get_orthographicSize() { }

	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	public void set_aspectRatio(float value) { }

	private static void set_aspectRatio_Injected(IntPtr _unity_self, float value) { }

	public void set_farClipPlane(float value) { }

	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	public void set_fieldOfView(float value) { }

	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	public void set_ignoreLayers(int value) { }

	private static void set_ignoreLayers_Injected(IntPtr _unity_self, int value) { }

	public void set_material(Material value) { }

	private static void set_material_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_nearClipPlane(float value) { }

	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	public void set_orthographic(bool value) { }

	private static void set_orthographic_Injected(IntPtr _unity_self, bool value) { }

	public void set_orthographicSize(float value) { }

	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

}

