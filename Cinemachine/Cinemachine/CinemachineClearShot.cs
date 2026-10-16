namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineClearShot")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExcludeFromPreset]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineClearShot.html")]
public class CinemachineClearShot : CinemachineVirtualCameraBase
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Comparison<Pair> <>9__49_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <Randomize>b__49_0(Pair p1, Pair p2) { }

	}

	private struct Pair
	{
		public int a; //Field offset: 0x0
		public float b; //Field offset: 0x4

	}

	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children to look at (the aim target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
	[VcamTargetProperty]
	public Transform m_LookAt; //Field offset: 0x68
	[NoSaveDuringPlay]
	[Tooltip("Default object for the camera children wants to move with (the body target), if not specified in a child camera.  May be empty if all children specify targets of their own.")]
	[VcamTargetProperty]
	public Transform m_Follow; //Field offset: 0x6C
	[NoSaveDuringPlay]
	[Tooltip("When enabled, the current child camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; //Field offset: 0x70
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	internal CinemachineVirtualCameraBase[] m_ChildCameras; //Field offset: 0x74
	[Tooltip("Wait this many seconds before activating a new child camera")]
	public float m_ActivateAfter; //Field offset: 0x78
	[Tooltip("An active camera must be active for at least this many seconds")]
	public float m_MinDuration; //Field offset: 0x7C
	[Tooltip("If checked, camera choice will be randomized if multiple cameras are equally desirable.  Otherwise, child list order and child camera priority will be used.")]
	public bool m_RandomizeChoice; //Field offset: 0x80
	[CinemachineBlendDefinitionProperty]
	[Tooltip("The blend which is used if you don't explicitly define a blend between two Virtual Cameras")]
	public CinemachineBlendDefinition m_DefaultBlend; //Field offset: 0x84
	[HideInInspector]
	public CinemachineBlenderSettings m_CustomBlends; //Field offset: 0x90
	[CompilerGenerated]
	private ICinemachineCamera <LiveChild>k__BackingField; //Field offset: 0x94
	private CameraState m_State; //Field offset: 0x98
	private float mActivationTime; //Field offset: 0x158
	private float mPendingActivationTime; //Field offset: 0x15C
	private ICinemachineCamera mPendingCamera; //Field offset: 0x160
	private CinemachineBlend mActiveBlend; //Field offset: 0x164
	private bool mRandomizeNow; //Field offset: 0x168
	private CinemachineVirtualCameraBase[] m_RandomizedChilden; //Field offset: 0x16C
	private ICinemachineCamera m_TransitioningFrom; //Field offset: 0x170

	public CinemachineBlend ActiveBlend
	{
		 get { } //Length: 14
	}

	public CinemachineVirtualCameraBase[] ChildCameras
	{
		 get { } //Length: 24
	}

	public virtual string Description
	{
		 get { } //Length: 228
	}

	public virtual Transform Follow
	{
		 get { } //Length: 22
		 set { } //Length: 27
	}

	public bool IsBlending
	{
		 get { } //Length: 18
	}

	public ICinemachineCamera LiveChild
	{
		[CompilerGenerated]
		 get { } //Length: 14
		[CompilerGenerated]
		 set { } //Length: 33
	}

	public virtual Transform LookAt
	{
		 get { } //Length: 22
		 set { } //Length: 27
	}

	public virtual CameraState State
	{
		 get { } //Length: 30
	}

	public CinemachineClearShot() { }

	private ICinemachineCamera ChooseCurrentCamera(Vector3 worldUp) { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public CinemachineBlend get_ActiveBlend() { }

	public CinemachineVirtualCameraBase[] get_ChildCameras() { }

	public virtual string get_Description() { }

	public virtual Transform get_Follow() { }

	public bool get_IsBlending() { }

	[CompilerGenerated]
	public ICinemachineCamera get_LiveChild() { }

	public virtual Transform get_LookAt() { }

	public virtual CameraState get_State() { }

	public virtual void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	private void InvalidateListOfChildren() { }

	public virtual bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	protected virtual void OnDisable() { }

	protected virtual void OnEnable() { }

	private void OnGuiHandler() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public void OnTransformChildrenChanged() { }

	public virtual void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	private CinemachineVirtualCameraBase[] Randomize(CinemachineVirtualCameraBase[] src) { }

	public void ResetRandomization() { }

	public virtual void set_Follow(Transform value) { }

	[CompilerGenerated]
	public void set_LiveChild(ICinemachineCamera value) { }

	public virtual void set_LookAt(Transform value) { }

	private void UpdateListOfChildren() { }

}

