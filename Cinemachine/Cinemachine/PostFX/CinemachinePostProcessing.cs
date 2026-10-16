namespace Cinemachine.PostFX;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachinePostProcessing.html")]
[SaveDuringPlay]
public class CinemachinePostProcessing : CinemachineExtension
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UnityAction<Scene> <>9__22_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <InitializeModule>b__22_0(Scene scene) { }

	}

	internal enum FocusTrackingMode
	{
		None = 0,
		LookAtTarget = 1,
		FollowTarget = 2,
		CustomTarget = 3,
		Camera = 4,
	}

	private class VcamExtraState
	{
		public PostProcessProfile mProfileCopy; //Field offset: 0x8

		public VcamExtraState() { }

		public void CreateProfileCopy(PostProcessProfile source) { }

		public void DestroyProfileCopy() { }

	}

	public static float s_VolumePriority; //Field offset: 0x0
	private static string sVolumeOwnerName; //Field offset: 0x4
	private static List<PostProcessVolume> sVolumes; //Field offset: 0x8
	private static Dictionary<CinemachineBrain, PostProcessLayer> mBrainToLayer; //Field offset: 0xC
	[HideInInspector]
	public bool m_FocusTracksTarget; //Field offset: 0x18
	[Tooltip("If the profile has the appropriate overrides, will set the base focus distance to be the distance from the selected target to the camera.The Focus Offset field will then modify that distance.")]
	public FocusTrackingMode m_FocusTracking; //Field offset: 0x1C
	[Tooltip("The target to use if Focus Tracks Target is set to Custom Target")]
	public Transform m_FocusTarget; //Field offset: 0x20
	[Tooltip("Offset from target distance, to be used with Focus Tracks Target.  Offsets the sharpest point away from the location of the focus target.")]
	public float m_FocusOffset; //Field offset: 0x24
	[Tooltip("This Post-Processing profile will be applied whenever this virtual camera is live")]
	public PostProcessProfile m_Profile; //Field offset: 0x28

	public bool IsValid
	{
		 get { } //Length: 121
	}

	private static CinemachinePostProcessing() { }

	public CinemachinePostProcessing() { }

	private static void ApplyPostFX(CinemachineBrain brain) { }

	private static void CleanupLookupTable() { }

	public bool get_IsValid() { }

	private static List<PostProcessVolume> GetDynamicBrainVolumes(CinemachineBrain brain, PostProcessLayer ppLayer, int minVolumes) { }

	private static PostProcessLayer GetPPLayer(CinemachineBrain brain) { }

	[RuntimeInitializeOnLoadMethod]
	private static void InitializeModule() { }

	public void InvalidateCachedProfile() { }

	private static void OnCameraCut(CinemachineBrain brain) { }

	protected virtual void OnDestroy() { }

	protected virtual void OnEnable() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

}

