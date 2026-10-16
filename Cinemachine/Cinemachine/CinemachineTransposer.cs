namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineTransposer : CinemachineComponentBase
{
	internal enum AngularDampingMode
	{
		Euler = 0,
		Quaternion = 1,
	}

	[DocumentationSorting(Level::UserRef (2))]
	internal enum BindingMode
	{
		LockToTargetOnAssign = 0,
		LockToTargetWithWorldUp = 1,
		LockToTargetNoRoll = 2,
		LockToTarget = 3,
		WorldSpace = 4,
		SimpleFollowWithWorldUp = 5,
	}

	[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
	public BindingMode m_BindingMode; //Field offset: 0x14
	[Tooltip("The distance vector that the transposer will attempt to maintain from the Follow target")]
	public Vector3 m_FollowOffset; //Field offset: 0x18
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_XDamping; //Field offset: 0x24
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_YDamping; //Field offset: 0x28
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; //Field offset: 0x2C
	public AngularDampingMode m_AngularDampingMode; //Field offset: 0x30
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_PitchDamping; //Field offset: 0x34
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_YawDamping; //Field offset: 0x38
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_RollDamping; //Field offset: 0x3C
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target's orientation.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_AngularDamping; //Field offset: 0x40
	[CompilerGenerated]
	private bool <HideOffsetInInspector>k__BackingField; //Field offset: 0x44
	private Vector3 m_PreviousTargetPosition; //Field offset: 0x48
	private Quaternion m_PreviousReferenceOrientation; //Field offset: 0x54
	private Quaternion m_targetOrientationOnAssign; //Field offset: 0x64
	private Vector3 m_PreviousOffset; //Field offset: 0x74
	private Transform m_previousTarget; //Field offset: 0x80

	protected Vector3 AngularDamping
	{
		 get { } //Length: 172
	}

	protected Vector3 Damping
	{
		 get { } //Length: 54
	}

	public Vector3 EffectiveOffset
	{
		 get { } //Length: 64
	}

	public bool HideOffsetInInspector
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public virtual bool IsValid
	{
		 get { } //Length: 104
	}

	public virtual Stage Stage
	{
		 get { } //Length: 3
	}

	public CinemachineTransposer() { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	protected Vector3 get_AngularDamping() { }

	protected Vector3 get_Damping() { }

	public Vector3 get_EffectiveOffset() { }

	[CompilerGenerated]
	public bool get_HideOffsetInInspector() { }

	public virtual bool get_IsValid() { }

	public virtual Stage get_Stage() { }

	public virtual float GetMaxDampTime() { }

	protected Vector3 GetOffsetForMinimumTargetDistance(Vector3 dampedTargetPos, Vector3 cameraOffset, Vector3 cameraFwd, Vector3 up, Vector3 actualTargetPos) { }

	public Quaternion GetReferenceOrientation(Vector3 worldUp) { }

	public override Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	protected void InitPrevFrameStateInfo(ref CameraState curState, float deltaTime) { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	protected override void OnValidate() { }

	[CompilerGenerated]
	public void set_HideOffsetInInspector(bool value) { }

	protected void TrackTarget(float deltaTime, Vector3 up, Vector3 desiredCameraOffset, out Vector3 outTargetPosition, out Quaternion outTargetOrient) { }

}

