namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineTrackedDolly : CinemachineComponentBase
{
	[DocumentationSorting(Level::UserRef (2))]
	internal struct AutoDolly
	{
		[Tooltip("If checked, will enable automatic dolly, which chooses a path position that is as close as possible to the Follow target.  Note: this can have significant performance impact")]
		public bool m_Enabled; //Field offset: 0x0
		[Tooltip("Offset, in current position units, from the closest point on the path to the follow target")]
		public float m_PositionOffset; //Field offset: 0x4
		[Tooltip("Search up to this many waypoints on either side of the current position.  Use 0 for Entire path.")]
		public int m_SearchRadius; //Field offset: 0x8
		[FormerlySerializedAs("m_StepsPerSegment")]
		[Tooltip("We search between waypoints by dividing the segment into this many straight pieces.  he higher the number, the more accurate the result, but performance is proportionally slower for higher numbers")]
		public int m_SearchResolution; //Field offset: 0xC

		public AutoDolly(bool enabled, float positionOffset, int searchRadius, int stepsPerSegment) { }

	}

	[DocumentationSorting(Level::UserRef (2))]
	internal enum CameraUpMode
	{
		Default = 0,
		Path = 1,
		PathNoRoll = 2,
		FollowTarget = 3,
		FollowTargetNoRoll = 4,
	}

	[Tooltip("The path to which the camera will be constrained.  This must be non-null.")]
	public CinemachinePathBase m_Path; //Field offset: 0x14
	[Tooltip("The position along the path at which the camera will be placed.  This can be animated directly, or set automatically by the Auto-Dolly feature to get as close as possible to the Follow target.  The value is interpreted according to the Position Units setting.")]
	public float m_PathPosition; //Field offset: 0x18
	[Tooltip("How to interpret Path Position.  If set to Path Units, values are as follows: 0 represents the first waypoint on the path, 1 is the second, and so on.  Values in-between are points on the path in between the waypoints.  If set to Distance, then Path Position represents distance along the path.")]
	public PositionUnits m_PositionUnits; //Field offset: 0x1C
	[Tooltip("Where to put the camera relative to the path position.  X is perpendicular to the path, Y is up, and Z is parallel to the path.  This allows the camera to be offset from the path itself (as if on a tripod, for example).")]
	public Vector3 m_PathOffset; //Field offset: 0x20
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain its position in a direction perpendicular to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_XDamping; //Field offset: 0x2C
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain its position in the path-local up direction.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_YDamping; //Field offset: 0x30
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain its position in a direction parallel to the path.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera. Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; //Field offset: 0x34
	[Tooltip("How to set the virtual camera's Up vector.  This will affect the screen composition, because the camera Aim behaviours will always try to respect the Up direction.")]
	public CameraUpMode m_CameraUp; //Field offset: 0x38
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's X angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_PitchDamping; //Field offset: 0x3C
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's Y angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_YawDamping; //Field offset: 0x40
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to track the target rotation's Z angle.  Small numbers are more responsive.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_RollDamping; //Field offset: 0x44
	[Tooltip("Controls how automatic dollying occurs.  A Follow target is necessary to use this feature.")]
	public AutoDolly m_AutoDolly; //Field offset: 0x48
	private float m_PreviousPathPosition; //Field offset: 0x58
	private Quaternion m_PreviousOrientation; //Field offset: 0x5C
	private Vector3 m_PreviousCameraPosition; //Field offset: 0x6C

	private Vector3 AngularDamping
	{
		private get { } //Length: 132
	}

	public virtual bool IsValid
	{
		 get { } //Length: 93
	}

	public virtual Stage Stage
	{
		 get { } //Length: 3
	}

	public CinemachineTrackedDolly() { }

	private Vector3 get_AngularDamping() { }

	public virtual bool get_IsValid() { }

	public virtual Stage get_Stage() { }

	private Quaternion GetCameraOrientationAtPathPoint(Quaternion pathOrientation, Vector3 up) { }

	public virtual float GetMaxDampTime() { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

}

