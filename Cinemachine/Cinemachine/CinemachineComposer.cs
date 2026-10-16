namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineComposer : CinemachineComponentBase
{
	private struct FovCache
	{
		public Rect mFovSoftGuideRect; //Field offset: 0x0
		public Rect mFovHardGuideRect; //Field offset: 0x10
		public float mFovH; //Field offset: 0x20
		public float mFov; //Field offset: 0x24
		private float mOrthoSizeOverDistance; //Field offset: 0x28
		private float mAspect; //Field offset: 0x2C
		private Rect mSoftGuideRect; //Field offset: 0x30
		private Rect mHardGuideRect; //Field offset: 0x40

		private Rect ScreenToFOV(Rect rScreen, float fov, float fovH, float aspect) { }

		public void UpdateCache(LensSettings lens, Rect softGuide, Rect hardGuide, float targetDistance) { }

	}

	[Tooltip("Target offset from the target object's center in target-local space. Use this to fine-tune the tracking target position when the desired area is not the tracked object's center.")]
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
	[Tooltip("How aggressively the camera tries to follow the target in the screen-horizontal direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public float m_HorizontalDamping; //Field offset: 0x2C
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to follow the target in the screen-vertical direction. Small numbers are more responsive, rapidly orienting the camera to keep the target in the dead zone. Larger numbers give a more heavy slowly responding camera. Using different vertical and horizontal settings can yield a wide range of camera behaviors.")]
	public float m_VerticalDamping; //Field offset: 0x30
	[Range(-0.5, 1.5)]
	[Space]
	[Tooltip("Horizontal screen position for target. The camera will rotate to position the tracked object here.")]
	public float m_ScreenX; //Field offset: 0x34
	[Range(-0.5, 1.5)]
	[Tooltip("Vertical screen position for target, The camera will rotate to position the tracked object here.")]
	public float m_ScreenY; //Field offset: 0x38
	[Range(0, 2)]
	[Tooltip("Camera will not rotate horizontally if the target is within this range of the position.")]
	public float m_DeadZoneWidth; //Field offset: 0x3C
	[Range(0, 2)]
	[Tooltip("Camera will not rotate vertically if the target is within this range of the position.")]
	public float m_DeadZoneHeight; //Field offset: 0x40
	[Range(0, 2)]
	[Tooltip("When target is within this region, camera will gradually rotate horizontally to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneWidth; //Field offset: 0x44
	[Range(0, 2)]
	[Tooltip("When target is within this region, camera will gradually rotate vertically to re-align towards the desired position, depending on the damping speed.")]
	public float m_SoftZoneHeight; //Field offset: 0x48
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position horizontally away from the center of the soft zone.")]
	public float m_BiasX; //Field offset: 0x4C
	[Range(-0.5, 0.5)]
	[Tooltip("A non-zero bias will move the target position vertically away from the center of the soft zone.")]
	public float m_BiasY; //Field offset: 0x50
	[Tooltip("Force target to center of screen when this camera activates.  If false, will clamp target to the edges of the dead zone")]
	public bool m_CenterOnActivate; //Field offset: 0x54
	[CompilerGenerated]
	private Vector3 <TrackedPoint>k__BackingField; //Field offset: 0x58
	private Vector3 m_CameraPosPrevFrame; //Field offset: 0x64
	private Vector3 m_LookAtPrevFrame; //Field offset: 0x70
	private Vector2 m_ScreenOffsetPrevFrame; //Field offset: 0x7C
	private Quaternion m_CameraOrientationPrevFrame; //Field offset: 0x84
	internal PositionPredictor m_Predictor; //Field offset: 0x94
	private FovCache mCache; //Field offset: 0x98

	internal Rect HardGuideRect
	{
		internal get { } //Length: 135
		internal set { } //Length: 103
	}

	public virtual bool IsValid
	{
		 get { } //Length: 104
	}

	internal Rect SoftGuideRect
	{
		internal get { } //Length: 76
		internal set { } //Length: 197
	}

	public virtual Stage Stage
	{
		 get { } //Length: 6
	}

	public private Vector3 TrackedPoint
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public CinemachineComposer() { }

	private bool ClampVerticalBounds(ref Rect r, Vector3 dir, Vector3 up, float fov) { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	internal Rect get_HardGuideRect() { }

	public virtual bool get_IsValid() { }

	internal Rect get_SoftGuideRect() { }

	public virtual Stage get_Stage() { }

	[CompilerGenerated]
	public Vector3 get_TrackedPoint() { }

	protected override Vector3 GetLookAtPointAndSetTrackedPoint(Vector3 lookAt, Vector3 up, float deltaTime) { }

	public virtual float GetMaxDampTime() { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	public virtual void OnTargetObjectWarped(Transform target, Vector3 positionDelta) { }

	public virtual void PrePipelineMutateCameraState(ref CameraState curState, float deltaTime) { }

	private void RotateToScreenBounds(ref CameraState state, Rect screenRect, Vector3 trackedPoint, ref Quaternion rigOrientation, float fov, float fovH, float deltaTime) { }

	internal void set_HardGuideRect(Rect value) { }

	internal void set_SoftGuideRect(Rect value) { }

	[CompilerGenerated]
	private void set_TrackedPoint(Vector3 value) { }

}

