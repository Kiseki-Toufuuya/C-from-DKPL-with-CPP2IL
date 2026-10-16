namespace UnityEngine.XR;

[NativeConditional("ENABLE_VR")]
[NativeHeader("Modules/VR/ScriptBindings/XR.bindings.h")]
[NativeHeader("Runtime/Interfaces/IVRDevice.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[NativeHeader("Modules/VR/VRModule.h")]
public static class XRSettings
{
	internal enum StereoRenderingMode
	{
		MultiPass = 0,
		SinglePass = 1,
		SinglePassInstanced = 2,
		SinglePassMultiview = 3,
	}


	public static bool enabled
	{
		[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
		 get { } //Length: 29
	}

	[NativeConditional("ENABLE_VR", "RenderTextureDesc()")]
	[NativeName("IntermediateEyeTextureDesc")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static RenderTextureDescriptor eyeTextureDesc
	{
		 get { } //Length: 58
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static int eyeTextureHeight
	{
		 get { } //Length: 29
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static int eyeTextureWidth
	{
		 get { } //Length: 29
	}

	public static float renderViewportScale
	{
		 get { } //Length: 33
	}

	[NativeName("RenderViewportScale")]
	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	internal static float renderViewportScaleInternal
	{
		internal get { } //Length: 33
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static StereoRenderingMode stereoRenderingMode
	{
		 get { } //Length: 29
	}

	[StaticAccessor("GetIVRDeviceScripting()", StaticAccessorType::ArrowWithDefaultReturnIfNull (3))]
	public static bool get_enabled() { }

	public static RenderTextureDescriptor get_eyeTextureDesc() { }

	private static void get_eyeTextureDesc_Injected(out RenderTextureDescriptor ret) { }

	public static int get_eyeTextureHeight() { }

	public static int get_eyeTextureWidth() { }

	public static float get_renderViewportScale() { }

	internal static float get_renderViewportScaleInternal() { }

	public static StereoRenderingMode get_stereoRenderingMode() { }

}

