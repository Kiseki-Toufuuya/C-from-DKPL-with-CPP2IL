namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineFramingTransposer : CinemachineComponentBase
{
	internal enum AdjustmentMode
	{
		ZoomOnly = 0,
		DollyOnly = 1,
		DollyThenZoom = 2,
	}

	[DocumentationSorting(Level::UserRef (2))]
	internal enum FramingMode
	{
		Horizontal = 0,
		Vertical = 1,
		HorizontalAndVertical = 2,
		None = 3,
	}

	private const float kMinimumCameraDistance = 0.01; //Field offset: 0x0
	private const float kMinimumGroupSize = 0.01; //Field offset: 0x0
	[Tooltip("Offset from the Follow Target object (in target-local co-ordinates).  The camera will attempt to frame the point which is the target's position plus this offset.  Use it to correct for cases when the target's origin is not the point of interest for the camera.")]
	public Vector3 m_TrackedObjectOffset; //Field offset: 0x14
	[Range(0, 1)]
	[Space]
	[Tooltip("This setting will instruct the composer to adjust its target offset based on the motion of the target.  The composer will look at a point where it estimates the target will be this many seconds into the future.  Note that this setting is sensitive to noisy animation, and can amplify the noise, resulting in undesirable camera jitter.  If the camera jitters unacceptably when the target is in motion, turn down this setting, or animate the target more smoothly.")]
	public float m_LookaheadTime; //Field offset: 0x20
	[Range(0, 30)]
	[Tooltip("Controls the smoothness of the lookahead algorithm.  Larger values smooth out jittery predictions and also increase prediction lag")]
	public float m_LookaheadSmoothing; //Field offset: 0x24
	[Tooltip("If checked, movement along the Y axis will be ignored for lookahead calculations")]
	public bool m_LookaheadIgnoreY; //Field offset: 0x28
	[Range(0, 20)]
	[Space]
	[Tooltip("How aggressively the camera tries to maintain the offset in the X-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's x-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_XDamping; //Field offset: 0x2C
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Y-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's y-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_YDamping; //Field offset: 0x30
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to maintain the offset in the Z-axis.  Small numbers are more responsive, rapidly translating the camera to keep the target's z-axis offset.  Larger numbers give a more heavy slowly responding camera.  Using different settings per axis can yield a wide range of camera behaviors.")]
	public float m_ZDamping; //Field offset: 0x34
	[Tooltip("If set, damping will apply  only to target motion, but not to camera rotation changes.  Turn this on to get an instant response when the rotation changes.  ")]
	public bool m_TargetMovementOnly; //Field offset: 0x38
	[Range(-0.5, 1.5)]
	[Space]
	[Tooltip("Horizontal screen position for target. The camera will move to position the tracked object here.")]
	public float m_ScreenX; //Field offset: 0x3C
	[Range(-0.5, 1.5)]
	[Tooltip("Vertical screen position for target, The camera will move to position the tracked object here.")]
	public float m_ScreenY; //Field offset: 0x40
	[Tooltip("The distance along the camera axis that will be maintained from the Follow target")]
	public float m_CameraDistance; //Field offset: 0x44
	[Range(0, 2)]
	[Space]
	[Tooltip("Camera will not move horizontally if the target is within this range of the position.")]
	public float m_DeadZoneWidth; //Field offset: 0x48
	[Range(0, 2)]
	[Tooltip("Camera will not move vertically if the target is within this range of the position.")]
	public float m_DeadZoneHeight; //Field offset: 0x4C
	[FormerlySerializedAs("m_DistanceDeadZoneSize")]
	[Tooltip("The camera will not move along its z-axis if the Follow target is within this distance of the specified camera distance")]
	public float m_DeadZoneDepth; //Field offset: 0x50
	[Space]
	[Tooltip("If checked, then then soft zone will be unlimited in size.")]
	public bool m_UnlimitedSoftZone; //Field offset: 0x54
	[Range(0, 2)]
	[Tooltip("When target is within this region, camera will gradually move horizontally to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneWidth; //Field offset: 0x58
	[Range(0, 2)]
	[Tooltip("When target is within this region, camera will gradually move vertically to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneHeight; //Field offset: 0x5C
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
	public float m_BiasX; //Field offset: 0x60
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
	public float m_BiasY; //Field offset: 0x64
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool m_CenterOnActivate; //Field offset: 0x68
	[FormerlySerializedAs("m_FramingMode")]
	[Space]
	[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
	public FramingMode m_GroupFramingMode; //Field offset: 0x6C
	[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
	public AdjustmentMode m_AdjustmentMode; //Field offset: 0x70
	[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
	public float m_GroupFramingSize; //Field offset: 0x74
	[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyIn; //Field offset: 0x78
	[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyOut; //Field offset: 0x7C
	[Tooltip("Set this to limit how close to the target the camera can get.")]
	public float m_MinimumDistance; //Field offset: 0x80
	[Tooltip("Set this to limit how far from the target the camera can get.")]
	public float m_MaximumDistance; //Field offset: 0x84
	[Range(1, 179)]
	[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
	public float m_MinimumFOV; //Field offset: 0x88
	[Range(1, 179)]
	[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
	public float m_MaximumFOV; //Field offset: 0x8C
	[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
	public float m_MinimumOrthoSize; //Field offset: 0x90
	[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
	public float m_MaximumOrthoSize; //Field offset: 0x94
	private Vector3 m_PreviousCameraPosition; //Field offset: 0x98
	internal PositionPredictor m_Predictor; //Field offset: 0xA4
	[CompilerGenerated]
	private Vector3 <TrackedPoint>k__BackingField; //Field offset: 0xA8
	private bool m_InheritingPosition; //Field offset: 0xB4
	private float m_prevFOV; //Field offset: 0xB8
	private Quaternion m_prevRotation; //Field offset: 0xBC
	[CompilerGenerated]
	private Bounds <LastBounds>k__BackingField; //Field offset: 0xCC
	[CompilerGenerated]
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; //Field offset: 0xE4

	public virtual bool BodyAppliesAfterAim
	{
		 get { } //Length: 3
	}

	internal Rect HardGuideRect
	{
		internal get { } //Length: 135
		internal set { } //Length: 103
	}

	public virtual bool IsValid
	{
		 get { } //Length: 104
	}

	public private Bounds LastBounds
	{
		[CompilerGenerated]
		 get { } //Length: 34
		[CompilerGenerated]
		private set { } //Length: 32
	}

	public private Matrix4x4 LastBoundsMatrix
	{
		[CompilerGenerated]
		 get { } //Length: 54
		[CompilerGenerated]
		private set { } //Length: 52
	}

	internal Rect SoftGuideRect
	{
		internal get { } //Length: 76
		internal set { } //Length: 197
	}

	public virtual Stage Stage
	{
		 get { } //Length: 3
	}

	public private Vector3 TrackedPoint
	{
		[CompilerGenerated]
		 get { } //Length: 32
		[CompilerGenerated]
		private set { } //Length: 30
	}

	public CinemachineFramingTransposer() { }

	private Vector3 ComputeGroupBounds(ICinemachineTargetGroup group, ref CameraState curState) { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public virtual bool get_BodyAppliesAfterAim() { }

	internal Rect get_HardGuideRect() { }

	public virtual bool get_IsValid() { }

	[CompilerGenerated]
	public Bounds get_LastBounds() { }

	[CompilerGenerated]
	public Matrix4x4 get_LastBoundsMatrix() { }

	internal Rect get_SoftGuideRect() { }

	public virtual Stage get_Stage() { }

	[CompilerGenerated]
	public Vector3 get_TrackedPoint() { }

	public virtual float GetMaxDampTime() { }

	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, ref Vector3 pos, Quaternion orientation) { }

	private float GetTargetHeight(Vector2 boundsSize) { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref TransitionParams transitionParams) { }

	private void OnValidate() { }

	private Vector3 OrthoOffsetToScreenBounds(Vector3 targetPos2D, Rect screenRect) { }

	private Rect ScreenToOrtho(Rect rScreen, float orthoSize, float aspect) { }

	internal void set_HardGuideRect(Rect value) { }

	[CompilerGenerated]
	private void set_LastBounds(Bounds value) { }

	[CompilerGenerated]
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

	internal void set_SoftGuideRect(Rect value) { }

	[CompilerGenerated]
	private void set_TrackedPoint(Vector3 value) { }

}

