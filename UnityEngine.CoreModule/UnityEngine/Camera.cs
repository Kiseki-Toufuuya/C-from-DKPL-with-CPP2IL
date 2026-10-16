namespace UnityEngine;

[NativeHeader("Runtime/Graphics/CommandBuffer/RenderingCommandBuffer.h")]
[NativeHeader("Runtime/Camera/RenderManager.h")]
[NativeHeader("Runtime/Camera/Camera.h")]
[NativeHeader("Runtime/Shaders/Shader.h")]
[NativeHeader("Runtime/Misc/GameObjectUtility.h")]
[NativeHeader("Runtime/Graphics/RenderTexture.h")]
[NativeHeader("Runtime/GfxDevice/GfxDeviceTypes.h")]
[RequireComponent(typeof(Transform))]
[UsedByNativeCode]
public sealed class Camera : Behaviour
{
	internal sealed class CameraCallback : MulticastDelegate
	{

		public CameraCallback(object object, IntPtr method) { }

		public override void Invoke(Camera cam) { }

	}

	internal enum GateFitMode
	{
		Vertical = 1,
		Horizontal = 2,
		Fill = 3,
		Overscan = 4,
		None = 0,
	}

	internal enum MonoOrStereoscopicEye
	{
		Left = 0,
		Right = 1,
		Mono = 2,
	}

	internal enum StereoscopicEye
	{
		Left = 0,
		Right = 1,
	}

	public const float kMinAperture = 0.7; //Field offset: 0x0
	public const float kMaxAperture = 32; //Field offset: 0x0
	public const int kMinBladeCount = 3; //Field offset: 0x0
	public const int kMaxBladeCount = 11; //Field offset: 0x0
	public static CameraCallback onPreCull; //Field offset: 0x0
	public static CameraCallback onPreRender; //Field offset: 0x4
	public static CameraCallback onPostRender; //Field offset: 0x8
	internal uint m_NonSerializedVersion; //Field offset: 0xC

	public RenderingPath actualRenderingPath
	{
		[NativeName("CalculateRenderingPath")]
		 get { } //Length: 98
	}

	public static int allCamerasCount
	{
		 get { } //Length: 29
	}

	public bool allowDynamicResolution
	{
		 get { } //Length: 98
	}

	public bool allowHDR
	{
		 get { } //Length: 98
	}

	public float aspect
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Color backgroundColor
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public CameraType cameraType
	{
		 get { } //Length: 98
	}

	public CameraClearFlags clearFlags
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int cullingMask
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public static Camera current
	{
		 get { } //Length: 74
	}

	private static Camera currentInternal
	{
		[FreeFunction("GetCurrentCameraPPtr")]
		private get { } //Length: 74
	}

	public float depth
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public DepthTextureMode depthTextureMode
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public int eventMask
	{
		 get { } //Length: 98
	}

	[NativeProperty("Far")]
	public float farClipPlane
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	[NativeProperty("VerticalFieldOfView")]
	public float fieldOfView
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public float focalLength
	{
		 set { } //Length: 109
	}

	public float focusDistance
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public GateFitMode gateFit
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Vector2 lensShift
	{
		 get { } //Length: 121
		 set { } //Length: 102
	}

	public static Camera main
	{
		[FreeFunction("FindMainCamera")]
		 get { } //Length: 74
	}

	[NativeProperty("Near")]
	public float nearClipPlane
	{
		 get { } //Length: 102
		 set { } //Length: 109
	}

	public Matrix4x4 nonJitteredProjectionMatrix
	{
		 set { } //Length: 102
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

	public int pixelHeight
	{
		[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	[NativeProperty("ScreenViewportRect")]
	public Rect pixelRect
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public int pixelWidth
	{
		[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public Matrix4x4 projectionMatrix
	{
		 get { } //Length: 119
		 set { } //Length: 102
	}

	[NativeProperty("NormalizedViewportRect")]
	public Rect rect
	{
		 get { } //Length: 112
		 set { } //Length: 102
	}

	public int scaledPixelHeight
	{
		[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public int scaledPixelWidth
	{
		[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public Vector2 sensorSize
	{
		 get { } //Length: 121
		 set { } //Length: 102
	}

	public MonoOrStereoscopicEye stereoActiveEye
	{
		[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
		 get { } //Length: 98
	}

	public bool stereoEnabled
	{
		[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
		 get { } //Length: 98
	}

	public StereoTargetEyeMask stereoTargetEye
	{
		 get { } //Length: 98
	}

	[NativeProperty("StereoTargetEye")]
	internal StereoTargetEyeMask stereoTargetEyeInternal
	{
		internal get { } //Length: 98
	}

	public int targetDisplay
	{
		 get { } //Length: 98
	}

	public RenderTexture targetTexture
	{
		 get { } //Length: 120
		 set { } //Length: 145
	}

	[NativeProperty("UseJitteredProjectionMatrixForTransparent")]
	public bool useJitteredProjectionMatrixForTransparentRendering
	{
		 set { } //Length: 101
	}

	public bool usePhysicalProperties
	{
		 get { } //Length: 98
		 set { } //Length: 101
	}

	public Matrix4x4 worldToCameraMatrix
	{
		 get { } //Length: 119
	}

	public Camera() { }

	public void AddCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("AddCommandBuffer")]
	private void AddCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	private static void AddCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	[RequiredByNativeCode]
	private static void BumpNonSerializedVersion(Camera cam) { }

	[FreeFunction("CameraScripting::CopyFrom", HasExplicitThis = True)]
	public void CopyFrom(Camera other) { }

	private static void CopyFrom_Injected(IntPtr _unity_self, IntPtr other) { }

	public void CopyStereoDeviceProjectionMatrixToNonJittered(StereoscopicEye eye) { }

	private static void CopyStereoDeviceProjectionMatrixToNonJittered_Injected(IntPtr _unity_self, StereoscopicEye eye) { }

	[NativeName("FieldOfViewToFocalLength_Safe")]
	public static float FieldOfViewToFocalLength(float fieldOfView, float sensorSize) { }

	[RequiredByNativeCode]
	private static void FireOnPostRender(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreCull(Camera cam) { }

	[RequiredByNativeCode]
	private static void FireOnPreRender(Camera cam) { }

	[NativeName("CalculateRenderingPath")]
	public RenderingPath get_actualRenderingPath() { }

	private static RenderingPath get_actualRenderingPath_Injected(IntPtr _unity_self) { }

	public static int get_allCamerasCount() { }

	public bool get_allowDynamicResolution() { }

	private static bool get_allowDynamicResolution_Injected(IntPtr _unity_self) { }

	public bool get_allowHDR() { }

	private static bool get_allowHDR_Injected(IntPtr _unity_self) { }

	public float get_aspect() { }

	private static float get_aspect_Injected(IntPtr _unity_self) { }

	public Color get_backgroundColor() { }

	private static void get_backgroundColor_Injected(IntPtr _unity_self, out Color ret) { }

	public CameraType get_cameraType() { }

	private static CameraType get_cameraType_Injected(IntPtr _unity_self) { }

	public CameraClearFlags get_clearFlags() { }

	private static CameraClearFlags get_clearFlags_Injected(IntPtr _unity_self) { }

	public int get_cullingMask() { }

	private static int get_cullingMask_Injected(IntPtr _unity_self) { }

	public static Camera get_current() { }

	[FreeFunction("GetCurrentCameraPPtr")]
	private static Camera get_currentInternal() { }

	private static IntPtr get_currentInternal_Injected() { }

	public float get_depth() { }

	private static float get_depth_Injected(IntPtr _unity_self) { }

	public DepthTextureMode get_depthTextureMode() { }

	private static DepthTextureMode get_depthTextureMode_Injected(IntPtr _unity_self) { }

	public int get_eventMask() { }

	private static int get_eventMask_Injected(IntPtr _unity_self) { }

	public float get_farClipPlane() { }

	private static float get_farClipPlane_Injected(IntPtr _unity_self) { }

	public float get_fieldOfView() { }

	private static float get_fieldOfView_Injected(IntPtr _unity_self) { }

	public float get_focusDistance() { }

	private static float get_focusDistance_Injected(IntPtr _unity_self) { }

	public GateFitMode get_gateFit() { }

	private static GateFitMode get_gateFit_Injected(IntPtr _unity_self) { }

	public Vector2 get_lensShift() { }

	private static void get_lensShift_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[FreeFunction("FindMainCamera")]
	public static Camera get_main() { }

	private static IntPtr get_main_Injected() { }

	public float get_nearClipPlane() { }

	private static float get_nearClipPlane_Injected(IntPtr _unity_self) { }

	public bool get_orthographic() { }

	private static bool get_orthographic_Injected(IntPtr _unity_self) { }

	public float get_orthographicSize() { }

	private static float get_orthographicSize_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::GetPixelHeight", HasExplicitThis = True)]
	public int get_pixelHeight() { }

	private static int get_pixelHeight_Injected(IntPtr _unity_self) { }

	public Rect get_pixelRect() { }

	private static void get_pixelRect_Injected(IntPtr _unity_self, out Rect ret) { }

	[FreeFunction("CameraScripting::GetPixelWidth", HasExplicitThis = True)]
	public int get_pixelWidth() { }

	private static int get_pixelWidth_Injected(IntPtr _unity_self) { }

	public Matrix4x4 get_projectionMatrix() { }

	private static void get_projectionMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public Rect get_rect() { }

	private static void get_rect_Injected(IntPtr _unity_self, out Rect ret) { }

	[FreeFunction("CameraScripting::GetScaledPixelHeight", HasExplicitThis = True)]
	public int get_scaledPixelHeight() { }

	private static int get_scaledPixelHeight_Injected(IntPtr _unity_self) { }

	[FreeFunction("CameraScripting::GetScaledPixelWidth", HasExplicitThis = True)]
	public int get_scaledPixelWidth() { }

	private static int get_scaledPixelWidth_Injected(IntPtr _unity_self) { }

	public Vector2 get_sensorSize() { }

	private static void get_sensorSize_Injected(IntPtr _unity_self, out Vector2 ret) { }

	[FreeFunction("CameraScripting::GetStereoActiveEye", HasExplicitThis = True)]
	public MonoOrStereoscopicEye get_stereoActiveEye() { }

	private static MonoOrStereoscopicEye get_stereoActiveEye_Injected(IntPtr _unity_self) { }

	[NativeMethod("GetStereoEnabledForBuiltInOrSRP")]
	public bool get_stereoEnabled() { }

	private static bool get_stereoEnabled_Injected(IntPtr _unity_self) { }

	public StereoTargetEyeMask get_stereoTargetEye() { }

	internal StereoTargetEyeMask get_stereoTargetEyeInternal() { }

	private static StereoTargetEyeMask get_stereoTargetEyeInternal_Injected(IntPtr _unity_self) { }

	public int get_targetDisplay() { }

	private static int get_targetDisplay_Injected(IntPtr _unity_self) { }

	public RenderTexture get_targetTexture() { }

	private static IntPtr get_targetTexture_Injected(IntPtr _unity_self) { }

	public bool get_usePhysicalProperties() { }

	private static bool get_usePhysicalProperties_Injected(IntPtr _unity_self) { }

	public Matrix4x4 get_worldToCameraMatrix() { }

	private static void get_worldToCameraMatrix_Injected(IntPtr _unity_self, out Matrix4x4 ret) { }

	public static int GetAllCameras(Camera[] cameras) { }

	[FreeFunction("CameraScripting::GetAllCamerasCount")]
	private static int GetAllCamerasCount() { }

	[FreeFunction("CameraScripting::GetAllCameras")]
	private static int GetAllCamerasImpl(out Camera[] cam) { }

	private static int GetAllCamerasImpl_Injected(out Camera[] cam) { }

	public Matrix4x4 GetStereoNonJitteredProjectionMatrix(StereoscopicEye eye) { }

	private static void GetStereoNonJitteredProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	[FreeFunction("CameraScripting::GetStereoProjectionMatrix", HasExplicitThis = True)]
	public Matrix4x4 GetStereoProjectionMatrix(StereoscopicEye eye) { }

	private static void GetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, out Matrix4x4 ret) { }

	public void RemoveCommandBuffer(CameraEvent evt, CommandBuffer buffer) { }

	[NativeName("RemoveCommandBuffer")]
	private void RemoveCommandBufferImpl(CameraEvent evt, CommandBuffer buffer) { }

	private static void RemoveCommandBufferImpl_Injected(IntPtr _unity_self, CameraEvent evt, IntPtr buffer) { }

	[FreeFunction("CameraScripting::Render", HasExplicitThis = True)]
	public void Render() { }

	private static void Render_Injected(IntPtr _unity_self) { }

	public void ResetProjectionMatrix() { }

	private static void ResetProjectionMatrix_Injected(IntPtr _unity_self) { }

	public void ResetStereoProjectionMatrices() { }

	private static void ResetStereoProjectionMatrices_Injected(IntPtr _unity_self) { }

	public Ray ScreenPointToRay(Vector3 pos) { }

	public Ray ScreenPointToRay(Vector3 pos, MonoOrStereoscopicEye eye) { }

	private Ray ScreenPointToRay(Vector2 pos, MonoOrStereoscopicEye eye) { }

	private static void ScreenPointToRay_Injected(IntPtr _unity_self, in Vector2 pos, MonoOrStereoscopicEye eye, out Ray ret) { }

	public Vector3 ScreenToViewportPoint(Vector3 position) { }

	private static void ScreenToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	public Vector3 ScreenToWorldPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 ScreenToWorldPoint(Vector3 position) { }

	private static void ScreenToWorldPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public void set_aspect(float value) { }

	private static void set_aspect_Injected(IntPtr _unity_self, float value) { }

	public void set_backgroundColor(Color value) { }

	private static void set_backgroundColor_Injected(IntPtr _unity_self, in Color value) { }

	public void set_clearFlags(CameraClearFlags value) { }

	private static void set_clearFlags_Injected(IntPtr _unity_self, CameraClearFlags value) { }

	public void set_cullingMask(int value) { }

	private static void set_cullingMask_Injected(IntPtr _unity_self, int value) { }

	public void set_depth(float value) { }

	private static void set_depth_Injected(IntPtr _unity_self, float value) { }

	public void set_depthTextureMode(DepthTextureMode value) { }

	private static void set_depthTextureMode_Injected(IntPtr _unity_self, DepthTextureMode value) { }

	public void set_farClipPlane(float value) { }

	private static void set_farClipPlane_Injected(IntPtr _unity_self, float value) { }

	public void set_fieldOfView(float value) { }

	private static void set_fieldOfView_Injected(IntPtr _unity_self, float value) { }

	public void set_focalLength(float value) { }

	private static void set_focalLength_Injected(IntPtr _unity_self, float value) { }

	public void set_focusDistance(float value) { }

	private static void set_focusDistance_Injected(IntPtr _unity_self, float value) { }

	public void set_gateFit(GateFitMode value) { }

	private static void set_gateFit_Injected(IntPtr _unity_self, GateFitMode value) { }

	public void set_lensShift(Vector2 value) { }

	private static void set_lensShift_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_nearClipPlane(float value) { }

	private static void set_nearClipPlane_Injected(IntPtr _unity_self, float value) { }

	public void set_nonJitteredProjectionMatrix(Matrix4x4 value) { }

	private static void set_nonJitteredProjectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	public void set_orthographic(bool value) { }

	private static void set_orthographic_Injected(IntPtr _unity_self, bool value) { }

	public void set_orthographicSize(float value) { }

	private static void set_orthographicSize_Injected(IntPtr _unity_self, float value) { }

	public void set_pixelRect(Rect value) { }

	private static void set_pixelRect_Injected(IntPtr _unity_self, in Rect value) { }

	public void set_projectionMatrix(Matrix4x4 value) { }

	private static void set_projectionMatrix_Injected(IntPtr _unity_self, in Matrix4x4 value) { }

	public void set_rect(Rect value) { }

	private static void set_rect_Injected(IntPtr _unity_self, in Rect value) { }

	public void set_sensorSize(Vector2 value) { }

	private static void set_sensorSize_Injected(IntPtr _unity_self, in Vector2 value) { }

	public void set_targetTexture(RenderTexture value) { }

	private static void set_targetTexture_Injected(IntPtr _unity_self, IntPtr value) { }

	public void set_useJitteredProjectionMatrixForTransparentRendering(bool value) { }

	private static void set_useJitteredProjectionMatrixForTransparentRendering_Injected(IntPtr _unity_self, bool value) { }

	public void set_usePhysicalProperties(bool value) { }

	private static void set_usePhysicalProperties_Injected(IntPtr _unity_self, bool value) { }

	public void SetStereoProjectionMatrix(StereoscopicEye eye, Matrix4x4 matrix) { }

	private static void SetStereoProjectionMatrix_Injected(IntPtr _unity_self, StereoscopicEye eye, in Matrix4x4 matrix) { }

	[FreeFunction("CameraScripting::SetupCurrent")]
	public static void SetupCurrent(Camera cur) { }

	private static void SetupCurrent_Injected(IntPtr cur) { }

	public Vector3 ViewportToScreenPoint(Vector3 position) { }

	private static void ViewportToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, out Vector3 ret) { }

	public Vector3 WorldToScreenPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToScreenPoint(Vector3 position) { }

	private static void WorldToScreenPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

	public Vector3 WorldToViewportPoint(Vector3 position, MonoOrStereoscopicEye eye) { }

	public Vector3 WorldToViewportPoint(Vector3 position) { }

	private static void WorldToViewportPoint_Injected(IntPtr _unity_self, in Vector3 position, MonoOrStereoscopicEye eye, out Vector3 ret) { }

}

