namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachinePOV : CinemachineComponentBase
{
	internal enum RecenterTargetMode
	{
		None = 0,
		FollowTargetForward = 1,
		LookAtTargetForward = 2,
	}

	public RecenterTargetMode m_RecenterTarget; //Field offset: 0x14
	[AxisStateProperty]
	[Tooltip("The Vertical axis.  Value is -90..90. Controls the vertical orientation")]
	public AxisState m_VerticalAxis; //Field offset: 0x18
	[Tooltip("Controls how automatic recentering of the Vertical axis is accomplished")]
	public Recentering m_VerticalRecentering; //Field offset: 0x7C
	[AxisStateProperty]
	[Tooltip("The Horizontal axis.  Value is -180..180.  Controls the horizontal orientation")]
	public AxisState m_HorizontalAxis; //Field offset: 0x9C
	[Tooltip("Controls how automatic recentering of the Horizontal axis is accomplished")]
	public Recentering m_HorizontalRecentering; //Field offset: 0x100
	[HideInInspector]
	[Tooltip("Obsolete - no longer used")]
	public bool m_ApplyBeforeBody; //Field offset: 0x120
	private Quaternion m_PreviousCameraRotation; //Field offset: 0x124

	public virtual bool IsValid
	{
		 get { } //Length: 16
	}

	public virtual bool RequiresUserInput
	{
		 get { } //Length: 3
	}

	public virtual Stage Stage
	{
		 get { } //Length: 6
	}

	public CinemachinePOV() { }

	public virtual void ForceCameraPosition(Vector3 pos, Quaternion rot) { }

	public virtual bool get_IsValid() { }

	public virtual bool get_RequiresUserInput() { }

	public virtual Stage get_Stage() { }

	public Vector2 GetRecenterTarget() { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	private static float NormalizeAngle(float angle) { }

	private void OnEnable() { }

	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime, ref TransitionParams transitionParams) { }

	private void OnValidate() { }

	public virtual void PrePipelineMutateCameraState(ref CameraState state, float deltaTime) { }

	private void SetAxesForRotation(Quaternion targetRot) { }

	public void UpdateInputAxisProvider() { }

}

