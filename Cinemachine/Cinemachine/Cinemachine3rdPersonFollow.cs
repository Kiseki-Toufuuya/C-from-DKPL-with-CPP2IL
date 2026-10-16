namespace Cinemachine;

[AddComponentMenu(null)]
[SaveDuringPlay]
public class Cinemachine3rdPersonFollow : CinemachineComponentBase
{
	[Tooltip("How responsively the camera tracks the target.  Each axis (camera-local) can have its own setting.  Value is the approximate time it takes the camera to catch up to the target's new position.  Smaller values give a more rigid effect, larger values give a squishier one")]
	public Vector3 Damping; //Field offset: 0x14
	[Header("Rig")]
	[Tooltip("Position of the shoulder pivot relative to the Follow target origin.  This offset is in target-local space")]
	public Vector3 ShoulderOffset; //Field offset: 0x20
	[Tooltip("Vertical offset of the hand in relation to the shoulder.  Arm length will affect the follow target's screen position when the camera rotates vertically")]
	public float VerticalArmLength; //Field offset: 0x2C
	[Range(0, 1)]
	[Tooltip("Specifies which shoulder (left, right, or in-between) the camera is on")]
	public float CameraSide; //Field offset: 0x30
	[Tooltip("How far behind the hand the camera will be placed")]
	public float CameraDistance; //Field offset: 0x34
	[Header("Obstacles")]
	[Tooltip("Camera will avoid obstacles on these layers")]
	public LayerMask CameraCollisionFilter; //Field offset: 0x38
	[TagField]
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string IgnoreTag; //Field offset: 0x3C
	[Range(0, 1)]
	[Tooltip("Specifies how close the camera can get to obstacles")]
	public float CameraRadius; //Field offset: 0x40
	[Range(0, 10)]
	[Tooltip("How gradually the camera moves to correct for occlusions.  Higher numbers will move the camera more gradually.")]
	public float DampingIntoCollision; //Field offset: 0x44
	[Range(0, 10)]
	[Tooltip("How gradually the camera returns to its normal position after having been corrected by the built-in collision resolution system.  Higher numbers will move the camera more gradually back to normal.")]
	public float DampingFromCollision; //Field offset: 0x48
	private Vector3 m_PreviousFollowTargetPosition; //Field offset: 0x4C
	private Vector3 m_DampingCorrection; //Field offset: 0x58
	private float m_CamPosCollisionCorrection; //Field offset: 0x64

	public virtual bool IsValid
	{
		 get { } //Length: 104
	}

	public virtual Stage Stage
	{
		 get { } //Length: 3
	}

	public Cinemachine3rdPersonFollow() { }

	public virtual bool get_IsValid() { }

	public virtual Stage get_Stage() { }

	internal static Quaternion GetHeading(Quaternion targetRot, Vector3 up) { }

	public virtual float GetMaxDampTime() { }

	private void GetRawRigPositions(Vector3 root, Quaternion targetRot, Quaternion heading, out Vector3 shoulder, out Vector3 hand) { }

	public void GetRigPositions(out Vector3 root, out Vector3 shoulder, out Vector3 hand) { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	private void OnDestroy() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	private void OnValidate() { }

	private void PositionCamera(ref CameraState curState, float deltaTime) { }

	private void Reset() { }

	private Vector3 ResolveCollisions(Vector3 root, Vector3 tip, float deltaTime, float cameraRadius, ref float collisionCorrection) { }

}

