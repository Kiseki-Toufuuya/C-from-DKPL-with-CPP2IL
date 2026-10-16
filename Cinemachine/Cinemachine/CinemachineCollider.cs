namespace Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineCollider.html")]
[SaveDuringPlay]
public class CinemachineCollider : CinemachineExtension
{
	internal enum ResolutionStrategy
	{
		PullCameraForward = 0,
		PreserveCameraHeight = 1,
		PreserveCameraDistance = 2,
	}

	private class VcamExtraState
	{
		public Vector3 previousDisplacement; //Field offset: 0x8
		public Vector3 previousCameraOffset; //Field offset: 0x14
		public Vector3 previousCameraPosition; //Field offset: 0x20
		public float previousDampTime; //Field offset: 0x2C
		public bool targetObscured; //Field offset: 0x30
		public float occlusionStartTime; //Field offset: 0x34
		public List<Vector3> debugResolutionPath; //Field offset: 0x38
		private float m_SmoothedDistance; //Field offset: 0x3C
		private float m_SmoothedTime; //Field offset: 0x40

		public VcamExtraState() { }

		public void AddPointToDebugPath(Vector3 p) { }

		public float ApplyDistanceSmoothing(float distance, float smoothingTime) { }

		public void ResetDistanceSmoothing(float smoothingTime) { }

		public void UpdateDistanceSmoothing(float distance) { }

	}

	private static Collider[] s_ColliderBuffer; //Field offset: 0x0
	private const float k_PrecisionSlush = 0.001; //Field offset: 0x0
	private const float k_AngleThreshold = 0.1; //Field offset: 0x0
	[Header("Obstacle Detection")]
	[Tooltip("Objects on these layers will be detected")]
	public LayerMask m_CollideAgainst; //Field offset: 0x18
	[TagField]
	[Tooltip("Obstacles with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string m_IgnoreTag; //Field offset: 0x1C
	[Tooltip("Objects on these layers will never obstruct view of the target")]
	public LayerMask m_TransparentLayers; //Field offset: 0x20
	[Tooltip("Obstacles closer to the target than this will be ignored")]
	public float m_MinimumDistanceFromTarget; //Field offset: 0x24
	[FormerlySerializedAs("m_PreserveLineOfSight")]
	[Space]
	[Tooltip("When enabled, will attempt to resolve situations where the line of sight to the target is blocked by an obstacle")]
	public bool m_AvoidObstacles; //Field offset: 0x28
	[FormerlySerializedAs("m_LineOfSightFeelerDistance")]
	[Tooltip("The maximum raycast distance when checking if the line of sight to this camera's target is clear.  If the setting is 0 or less, the current actual distance to target will be used.")]
	public float m_DistanceLimit; //Field offset: 0x2C
	[Tooltip("Don't take action unless occlusion has lasted at least this long.")]
	public float m_MinimumOcclusionTime; //Field offset: 0x30
	[Tooltip("Camera will try to maintain this distance from any obstacle.  Try to keep this value small.  Increase it if you are seeing inside obstacles due to a large FOV on the camera.")]
	public float m_CameraRadius; //Field offset: 0x34
	[Tooltip("The way in which the Collider will attempt to preserve sight of the target.")]
	public ResolutionStrategy m_Strategy; //Field offset: 0x38
	[Range(1, 10)]
	[Tooltip("Upper limit on how many obstacle hits to process.  Higher numbers may impact performance.  In most environments, 4 is enough.")]
	public int m_MaximumEffort; //Field offset: 0x3C
	[Range(0, 2)]
	[Tooltip("Smoothing to apply to obstruction resolution.  Nearest camera point is held for at least this long")]
	public float m_SmoothingTime; //Field offset: 0x40
	[FormerlySerializedAs("m_Smoothing")]
	[Range(0, 10)]
	[Tooltip("How gradually the camera returns to its normal position after having been corrected.  Higher numbers will move the camera more gradually back to normal.")]
	public float m_Damping; //Field offset: 0x44
	[Range(0, 10)]
	[Tooltip("How gradually the camera moves to resolve an occlusion.  Higher numbers will move the camera more gradually.")]
	public float m_DampingWhenOccluded; //Field offset: 0x48
	[Header("Shot Evaluation")]
	[Tooltip("If greater than zero, a higher score will be given to shots when the target is closer to this distance.  Set this to zero to disable this feature.")]
	public float m_OptimalTargetDistance; //Field offset: 0x4C
	private RaycastHit[] m_CornerBuffer; //Field offset: 0x50

	public List<List`1<Vector3>> DebugPaths
	{
		 get { } //Length: 449
	}

	private static CinemachineCollider() { }

	public CinemachineCollider() { }

	public bool CameraWasDisplaced(ICinemachineCamera vcam) { }

	private bool CheckForTargetObstructions(CameraState state) { }

	private static float ClampRayToBounds(Ray ray, float distance, Bounds bounds) { }

	public List<List`1<Vector3>> get_DebugPaths() { }

	public float GetCameraDisplacementDistance(ICinemachineCamera vcam) { }

	public virtual float GetMaxDampTime() { }

	private float GetPushBackDistance(Ray ray, Plane startPlane, float targetDistance, Vector3 lookAtPos) { }

	private bool GetWalkingDirection(Vector3 pos, Vector3 pushDir, RaycastHit obstacle, ref Vector3 outDir) { }

	public bool IsTargetObscured(ICinemachineCamera vcam) { }

	private static bool IsTargetOffscreen(CameraState state) { }

	protected virtual void OnDestroy() { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	private void OnValidate() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	private Vector3 PreserveLineOfSight(ref CameraState state, ref VcamExtraState extra) { }

	private Vector3 PullCameraInFrontOfNearestObstacle(Vector3 cameraPos, Vector3 lookAtPos, int layerMask, ref RaycastHit hitInfo) { }

	private Vector3 PushCameraBack(Vector3 currentPos, Vector3 pushDir, RaycastHit obstacle, Vector3 lookAtPos, Plane startPlane, float targetDistance, int iterations, ref VcamExtraState extra) { }

	private Vector3 RespectCameraRadius(Vector3 cameraPos, Vector3 lookAtPos) { }

}

