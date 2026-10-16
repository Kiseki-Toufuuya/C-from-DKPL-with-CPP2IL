namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineBrain")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineBrainProperties.html")]
[SaveDuringPlay]
public class CinemachineBrain : MonoBehaviour, ICameraOverrideStack
{
	[CompilerGenerated]
	private sealed class <AfterPhysics>d__38 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public CinemachineBrain <>4__this; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <AfterPhysics>d__38(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class BrainEvent : UnityEvent<CinemachineBrain>
	{

		public BrainEvent() { }

	}

	private class BrainFrame
	{
		public int id; //Field offset: 0x8
		public CinemachineBlend blend; //Field offset: 0xC
		public CinemachineBlend workingBlend; //Field offset: 0x10
		public BlendSourceVirtualCamera workingBlendSource; //Field offset: 0x14
		public float deltaTimeOverride; //Field offset: 0x18
		public float blendStartPosition; //Field offset: 0x1C

		public bool Active
		{
			 get { } //Length: 34
		}

		public BrainFrame() { }

		public bool get_Active() { }

	}

	[DocumentationSorting(Level::UserRef (2))]
	internal enum BrainUpdateMethod
	{
		FixedUpdate = 0,
		LateUpdate = 1,
	}

	[DocumentationSorting(Level::UserRef (2))]
	internal enum UpdateMethod
	{
		FixedUpdate = 0,
		LateUpdate = 1,
		SmartUpdate = 2,
		ManualUpdate = 3,
	}

	internal class VcamActivatedEvent : UnityEvent<ICinemachineCamera, ICinemachineCamera>
	{

		public VcamActivatedEvent() { }

	}

	private static ICinemachineCamera mSoloCamera; //Field offset: 0x0
	private static readonly AnimationCurve mDefaultLinearAnimationCurve; //Field offset: 0x4
	[Tooltip("When enabled, the current camera and blend will be indicated in the game window, for debugging")]
	public bool m_ShowDebugText; //Field offset: 0x10
	[Tooltip("When enabled, the camera's frustum will be shown at all times in the scene view")]
	public bool m_ShowCameraFrustum; //Field offset: 0x11
	[Tooltip("When enabled, the cameras will always respond in real-time to user input and damping, even if the game is running in slow motion")]
	public bool m_IgnoreTimeScale; //Field offset: 0x12
	[Tooltip("If set, this object's Y axis will define the worldspace Up vector for all the virtual cameras.  This is useful for instance in top-down game environments.  If not set, Up is worldspace Y.  Setting this appropriately is important, because Virtual Cameras don't like looking straight up or straight down.")]
	public Transform m_WorldUpOverride; //Field offset: 0x14
	[Tooltip("The update time for the vcams.  Use FixedUpdate if all your targets are animated during FixedUpdate (e.g. RigidBodies), LateUpdate if all your targets are animated during the normal Update loop, and SmartUpdate if you want Cinemachine to do the appropriate thing on a per-target basis.  SmartUpdate is the recommended setting")]
	public UpdateMethod m_UpdateMethod; //Field offset: 0x18
	[Tooltip("The update time for the Brain, i.e. when the blends are evaluated and the brain's transform is updated")]
	public BrainUpdateMethod m_BlendUpdateMethod; //Field offset: 0x1C
	[CinemachineBlendDefinitionProperty]
	[Tooltip("The blend that is used in cases where you haven't explicitly defined a blend between two Virtual Cameras")]
	public CinemachineBlendDefinition m_DefaultBlend; //Field offset: 0x20
	[Tooltip("This is the asset that contains custom settings for blends between specific virtual cameras in your scene")]
	public CinemachineBlenderSettings m_CustomBlends; //Field offset: 0x2C
	private Camera m_OutputCamera; //Field offset: 0x30
	private GameObject m_TargetOverride; //Field offset: 0x34
	[Tooltip("This event will fire whenever a virtual camera goes live and there is no blend")]
	public BrainEvent m_CameraCutEvent; //Field offset: 0x38
	[Tooltip("This event will fire whenever a virtual camera goes live.  If a blend is involved, then the event will fire on the first frame of the blend.")]
	public VcamActivatedEvent m_CameraActivatedEvent; //Field offset: 0x3C
	private Coroutine mPhysicsCoroutine; //Field offset: 0x40
	private int m_LastFrameUpdated; //Field offset: 0x44
	private WaitForFixedUpdate mWaitForFixedUpdate; //Field offset: 0x48
	private List<BrainFrame> mFrameStack; //Field offset: 0x4C
	private int mNextFrameId; //Field offset: 0x50
	private CinemachineBlend mCurrentLiveCameras; //Field offset: 0x54
	private ICinemachineCamera mActiveCameraPreviousFrame; //Field offset: 0x58
	private GameObject mActiveCameraPreviousFrameGameObject; //Field offset: 0x5C
	[CompilerGenerated]
	private CameraState <CurrentCameraState>k__BackingField; //Field offset: 0x60

	public CinemachineBlend ActiveBlend
	{
		 get { } //Length: 197
		 set { } //Length: 137
	}

	public ICinemachineCamera ActiveVirtualCamera
	{
		 get { } //Length: 363
	}

	public GameObject ControlledObject
	{
		 get { } //Length: 99
		 set { } //Length: 99
	}

	public private CameraState CurrentCameraState
	{
		[CompilerGenerated]
		 get { } //Length: 27
		[CompilerGenerated]
		private set { } //Length: 41
	}

	public override Vector3 DefaultWorldUp
	{
		 get { } //Length: 208
	}

	public bool IsBlending
	{
		 get { } //Length: 23
	}

	public Camera OutputCamera
	{
		 get { } //Length: 179
	}

	public static ICinemachineCamera SoloCamera
	{
		 get { } //Length: 60
		 set { } //Length: 305
	}

	private static CinemachineBrain() { }

	public CinemachineBrain() { }

	[IteratorStateMachine(typeof(<AfterPhysics>d__38))]
	private IEnumerator AfterPhysics() { }

	private void Awake() { }

	public void ComputeCurrentBlend(ref CinemachineBlend outputBlend, int numTopLayersToExclude) { }

	private static ICinemachineCamera DeepCamBFromBlend(CinemachineBlend blend) { }

	public CinemachineBlend get_ActiveBlend() { }

	public ICinemachineCamera get_ActiveVirtualCamera() { }

	public GameObject get_ControlledObject() { }

	[CompilerGenerated]
	public CameraState get_CurrentCameraState() { }

	public override Vector3 get_DefaultWorldUp() { }

	public bool get_IsBlending() { }

	public Camera get_OutputCamera() { }

	public static ICinemachineCamera get_SoloCamera() { }

	private int GetBrainFrame(int withId) { }

	private float GetEffectiveDeltaTime(bool fixedDelta) { }

	public static Color GetSoloGUIColor() { }

	public bool IsLive(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	public bool IsLiveInBlend(ICinemachineCamera vcam) { }

	private void LateUpdate() { }

	private CinemachineBlendDefinition LookupBlend(ICinemachineCamera fromKey, ICinemachineCamera toKey) { }

	public void ManualUpdate() { }

	private void OnDisable() { }

	private void OnEnable() { }

	private void OnGuiHandler() { }

	private void OnSceneLoaded(Scene scene, LoadSceneMode mode) { }

	private void OnSceneUnloaded(Scene scene) { }

	private void ProcessActiveCamera(float deltaTime) { }

	private void PushStateToUnityCamera(ref CameraState state) { }

	public override void ReleaseCameraOverride(int overrideId) { }

	public void set_ActiveBlend(CinemachineBlend value) { }

	public void set_ControlledObject(GameObject value) { }

	[CompilerGenerated]
	private void set_CurrentCameraState(CameraState value) { }

	public static void set_SoloCamera(ICinemachineCamera value) { }

	public override int SetCameraOverride(int overrideId, ICinemachineCamera camA, ICinemachineCamera camB, float weightB, float deltaTime) { }

	private void Start() { }

	protected override ICinemachineCamera TopCameraFromPriorityQueue() { }

	private void UpdateFrame0(float deltaTime) { }

	private void UpdateVirtualCameras(UpdateFilter updateFilter, float deltaTime) { }

}

