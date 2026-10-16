namespace Cinemachine;

[SaveDuringPlay]
public abstract class CinemachineVirtualCameraBase : MonoBehaviour, ICinemachineCamera, ISerializationCallbackReceiver
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<CinemachineExtension, Boolean> <>9__66_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal bool <RequiresUserInput>b__66_0(CinemachineExtension extension) { }

	}

	internal enum BlendHint
	{
		None = 0,
		SphericalPosition = 1,
		CylindricalPosition = 2,
		ScreenSpaceAimWhenTargetsDiffer = 3,
	}

	internal enum StandbyUpdateMode
	{
		Never = 0,
		Always = 1,
		RoundRobin = 2,
	}

	internal struct TransitionParams
	{
		[FormerlySerializedAs("m_PositionBlending")]
		[Tooltip("Hint for blending positions to and from this virtual camera")]
		public BlendHint m_BlendHint; //Field offset: 0x0
		[Tooltip("When this virtual camera goes Live, attempt to force the position to be the same as the current position of the Unity Camera")]
		public bool m_InheritPosition; //Field offset: 0x4
		[Tooltip("This event fires when the virtual camera goes Live")]
		public VcamActivatedEvent m_OnCameraLive; //Field offset: 0x8

	}

	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	public String[] m_ExcludedPropertiesInInspector; //Field offset: 0x10
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	public Stage[] m_LockStageInInspector; //Field offset: 0x14
	private int m_ValidatingStreamVersion; //Field offset: 0x18
	private bool m_OnValidateCalled; //Field offset: 0x1C
	[HideInInspector]
	[NoSaveDuringPlay]
	[SerializeField]
	private int m_StreamingVersion; //Field offset: 0x20
	[NoSaveDuringPlay]
	[Tooltip("The priority will determine which camera becomes active based on the state of other cameras and this camera.  Higher numbers have greater priority.")]
	public int m_Priority; //Field offset: 0x24
	internal int m_ActivationId; //Field offset: 0x28
	public float FollowTargetAttachment; //Field offset: 0x2C
	public float LookAtTargetAttachment; //Field offset: 0x30
	[Tooltip("When the virtual camera is not live, this is how often the virtual camera will be updated.  Set this to tune for performance. Most of the time Never is fine, unless the virtual camera is doing shot evaluation.")]
	public StandbyUpdateMode m_StandbyUpdate; //Field offset: 0x34
	[CompilerGenerated]
	private List<CinemachineExtension> <mExtensions>k__BackingField; //Field offset: 0x38
	[CompilerGenerated]
	private bool <PreviousStateIsValid>k__BackingField; //Field offset: 0x3C
	private bool m_WasStarted; //Field offset: 0x3D
	private bool mSlaveStatusUpdated; //Field offset: 0x3E
	private CinemachineVirtualCameraBase m_parentVcam; //Field offset: 0x40
	private int m_QueuePriority; //Field offset: 0x44
	private float m_blendStartPosition; //Field offset: 0x48
	private Transform m_CachedFollowTarget; //Field offset: 0x4C
	private CinemachineVirtualCameraBase m_CachedFollowTargetVcam; //Field offset: 0x50
	private ICinemachineTargetGroup m_CachedFollowTargetGroup; //Field offset: 0x54
	private Transform m_CachedLookAtTarget; //Field offset: 0x58
	private CinemachineVirtualCameraBase m_CachedLookAtTargetVcam; //Field offset: 0x5C
	private ICinemachineTargetGroup m_CachedLookAtTargetGroup; //Field offset: 0x60
	[CompilerGenerated]
	private bool <FollowTargetChanged>k__BackingField; //Field offset: 0x64
	[CompilerGenerated]
	private bool <LookAtTargetChanged>k__BackingField; //Field offset: 0x65

	public ICinemachineTargetGroup AbstractFollowTargetGroup
	{
		 get { } //Length: 11
	}

	public ICinemachineTargetGroup AbstractLookAtTargetGroup
	{
		 get { } //Length: 11
	}

	public override string Description
	{
		 get { } //Length: 35
	}

	public abstract Transform Follow
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public CinemachineVirtualCameraBase FollowTargetAsVcam
	{
		 get { } //Length: 11
	}

	public private bool FollowTargetChanged
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public override bool IsValid
	{
		 get { } //Length: 71
	}

	public abstract Transform LookAt
	{
		 get { } //Length: 0
		 set { } //Length: 0
	}

	public CinemachineVirtualCameraBase LookAtTargetAsVcam
	{
		 get { } //Length: 11
	}

	public private bool LookAtTargetChanged
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	internal List<CinemachineExtension> mExtensions
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 27
	}

	public override string Name
	{
		 get { } //Length: 16
	}

	public override ICinemachineCamera ParentCamera
	{
		 get { } //Length: 93
	}

	public override bool PreviousStateIsValid
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public override int Priority
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public abstract CameraState State
	{
		 get { } //Length: 0
	}

	public private int ValidatingStreamVersion
	{
		 get { } //Length: 78
		private set { } //Length: 14
	}

	public override GameObject VirtualCameraGameObject
	{
		 get { } //Length: 88
	}

	protected CinemachineVirtualCameraBase() { }

	public override void AddExtension(CinemachineExtension extension) { }

	protected void ApplyPositionBlendMethod(ref CameraState state, BlendHint hint) { }

	public void CancelDamping(bool updateNow = false) { }

	protected CinemachineBlend CreateBlend(ICinemachineCamera camA, ICinemachineCamera camB, CinemachineBlendDefinition blendDef, CinemachineBlend activeBlend) { }

	public float DetachedFollowTargetDamp(float initial, float dampTime, float deltaTime) { }

	public Vector3 DetachedFollowTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	public Vector3 DetachedFollowTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	public float DetachedLookAtTargetDamp(float initial, float dampTime, float deltaTime) { }

	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, Vector3 dampTime, float deltaTime) { }

	public Vector3 DetachedLookAtTargetDamp(Vector3 initial, float dampTime, float deltaTime) { }

	internal void EnsureStarted() { }

	public override void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public ICinemachineTargetGroup get_AbstractFollowTargetGroup() { }

	public ICinemachineTargetGroup get_AbstractLookAtTargetGroup() { }

	public override string get_Description() { }

	public abstract Transform get_Follow() { }

	public CinemachineVirtualCameraBase get_FollowTargetAsVcam() { }

	[CompilerGenerated]
	public bool get_FollowTargetChanged() { }

	public override bool get_IsValid() { }

	public abstract Transform get_LookAt() { }

	public CinemachineVirtualCameraBase get_LookAtTargetAsVcam() { }

	[CompilerGenerated]
	public bool get_LookAtTargetChanged() { }

	[CompilerGenerated]
	internal List<CinemachineExtension> get_mExtensions() { }

	public override string get_Name() { }

	public override ICinemachineCamera get_ParentCamera() { }

	[CompilerGenerated]
	public override bool get_PreviousStateIsValid() { }

	public override int get_Priority() { }

	public abstract CameraState get_State() { }

	public int get_ValidatingStreamVersion() { }

	public override GameObject get_VirtualCameraGameObject() { }

	private bool GetInheritPosition(ICinemachineCamera cam) { }

	public IInputAxisProvider GetInputAxisProvider() { }

	public override float GetMaxDampTime() { }

	public abstract void InternalUpdateCameraState(Vector3 worldUp, float deltaTime) { }

	private void InvalidateCachedTargets() { }

	protected bool InvokeOnTransitionInExtensions(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	protected void InvokePostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState newState, float deltaTime) { }

	protected void InvokePrePipelineMutateCameraStateCallback(CinemachineVirtualCameraBase vcam, ref CameraState newState, float deltaTime) { }

	public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false) { }

	protected private override void LegacyUpgrade(int streamedVersion) { }

	public void MoveToTopOfPrioritySubqueue() { }

	internal override void OnBeforeSerialize() { }

	protected override void OnDestroy() { }

	protected override void OnDisable() { }

	protected override void OnEnable() { }

	public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	protected override void OnTransformParentChanged() { }

	public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	protected override void OnValidate() { }

	protected CameraState PullStateFromVirtualCamera(Vector3 worldUp, ref LensSettings lens) { }

	public override void RemoveExtension(CinemachineExtension extension) { }

	internal override bool RequiresUserInput() { }

	public Transform ResolveFollow(Transform localFollow) { }

	public Transform ResolveLookAt(Transform localLookAt) { }

	public abstract void set_Follow(Transform value) { }

	[CompilerGenerated]
	private void set_FollowTargetChanged(bool value) { }

	public abstract void set_LookAt(Transform value) { }

	[CompilerGenerated]
	private void set_LookAtTargetChanged(bool value) { }

	[CompilerGenerated]
	private void set_mExtensions(List<CinemachineExtension> value) { }

	[CompilerGenerated]
	public override void set_PreviousStateIsValid(bool value) { }

	public override void set_Priority(int value) { }

	private void set_ValidatingStreamVersion(int value) { }

	protected override void Start() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnAfterDeserialize() { }

	private override void UnityEngine.ISerializationCallbackReceiver.OnBeforeSerialize() { }

	protected override void Update() { }

	public override void UpdateCameraState(Vector3 worldUp, float deltaTime) { }

	private void UpdateSlaveStatus() { }

	protected void UpdateTargetCache() { }

	private void UpdateVcamPoolStatus() { }

}

