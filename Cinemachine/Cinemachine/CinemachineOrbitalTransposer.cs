namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineOrbitalTransposer : CinemachineTransposer
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static UpdateHeadingDelegate <>9__30_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal float <.ctor>b__30_0(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	}

	[DocumentationSorting(Level::UserRef (2))]
	internal struct Heading
	{
		[DocumentationSorting(Level::UserRef (2))]
		internal enum HeadingDefinition
		{
			PositionDelta = 0,
			Velocity = 1,
			TargetForward = 2,
			WorldForward = 3,
		}

		[FormerlySerializedAs("m_HeadingDefinition")]
		[Tooltip("How 'forward' is defined.  The camera will be placed by default behind the target.  PositionDelta will consider 'forward' to be the direction in which the target is moving.")]
		public HeadingDefinition m_Definition; //Field offset: 0x0
		[Range(0, 10)]
		[Tooltip("Size of the velocity sampling window for target heading filter.  This filters out irregularities in the target's movement.  Used only if deriving heading from target's movement (PositionDelta or Velocity)")]
		public int m_VelocityFilterStrength; //Field offset: 0x4
		[FormerlySerializedAs("m_HeadingBias")]
		[Range(-180, 180)]
		[Tooltip("Where the camera is placed when the X-axis value is zero.  This is a rotation in degrees around the Y axis.  When this value is 0, the camera will be placed behind the target.  Nonzero offsets will rotate the zero position around the target.")]
		public float m_Bias; //Field offset: 0x8

		public Heading(HeadingDefinition def, int filterStrength, float bias) { }

	}

	public sealed class UpdateHeadingDelegate : MulticastDelegate
	{

		public UpdateHeadingDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up, AsyncCallback callback, object object) { }

		public override float EndInvoke(IAsyncResult result) { }

		public override float Invoke(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up) { }

	}

	[OrbitalTransposerHeadingProperty]
	[Space]
	[Tooltip("The definition of Forward.  Camera will follow behind.")]
	public Heading m_Heading; //Field offset: 0x84
	[Tooltip("Automatic heading recentering.  The settings here defines how the camera will reposition itself in the absence of player input.")]
	public Recentering m_RecenterToTargetHeading; //Field offset: 0x90
	[AxisStateProperty]
	[Tooltip("Heading Control.  The settings here control the behaviour of the camera in response to the player's input.")]
	public AxisState m_XAxis; //Field offset: 0xB0
	[FormerlySerializedAs("m_Radius")]
	[HideInInspector]
	[SerializeField]
	private float m_LegacyRadius; //Field offset: 0x114
	[FormerlySerializedAs("m_HeightOffset")]
	[HideInInspector]
	[SerializeField]
	private float m_LegacyHeightOffset; //Field offset: 0x118
	[FormerlySerializedAs("m_HeadingBias")]
	[HideInInspector]
	[SerializeField]
	private float m_LegacyHeadingBias; //Field offset: 0x11C
	[HideInInspector]
	[NoSaveDuringPlay]
	public bool m_HeadingIsSlave; //Field offset: 0x120
	internal UpdateHeadingDelegate HeadingUpdater; //Field offset: 0x124
	private Vector3 m_LastTargetPosition; //Field offset: 0x128
	private HeadingTracker mHeadingTracker; //Field offset: 0x134
	private Rigidbody m_TargetRigidBody; //Field offset: 0x138
	private Transform m_PreviousTarget; //Field offset: 0x13C
	private Vector3 m_LastCameraPosition; //Field offset: 0x140
	private float m_LastHeading; //Field offset: 0x14C

	public virtual bool RequiresUserInput
	{
		 get { } //Length: 3
	}

	public CinemachineOrbitalTransposer() { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public virtual bool get_RequiresUserInput() { }

	public float GetAxisClosestValue(Vector3 cameraPos, Vector3 up) { }

	public virtual Vector3 GetTargetCameraPosition(Vector3 worldUp) { }

	private float GetTargetHeading(float currentHeading, Quaternion targetOrientation) { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	private void OnEnable() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref TransitionParams transitionParams) { }

	protected virtual void OnValidate() { }

	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis) { }

	public float UpdateHeading(float deltaTime, Vector3 up, ref AxisState axis, ref Recentering recentering, bool isLive) { }

	public void UpdateInputAxisProvider() { }

}

