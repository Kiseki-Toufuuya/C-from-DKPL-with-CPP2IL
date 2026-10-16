namespace Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExecuteAlways]
[SaveDuringPlay]
public class Cinemachine3rdPersonAim : CinemachineExtension
{
	[Header("Aim Target Detection")]
	[Tooltip("Objects on these layers will be detected")]
	public LayerMask AimCollisionFilter; //Field offset: 0x18
	[TagField]
	[Tooltip("Objects with this tag will be ignored.  It is a good idea to set this field to the target's tag")]
	public string IgnoreTag; //Field offset: 0x1C
	[Tooltip("How far to project the object detection ray")]
	public float AimDistance; //Field offset: 0x20
	[Tooltip("This 2D object will be positioned in the game view over the raycast hit point, if any, or will remain in the center of the screen if no hit point is detected.  May be null, in which case no on-screen indicator will appear")]
	public RectTransform AimTargetReticle; //Field offset: 0x24
	[CompilerGenerated]
	private Vector3 <AimTarget>k__BackingField; //Field offset: 0x28

	public private Vector3 AimTarget
	{
		[CompilerGenerated]
		 get { } //Length: 26
		[CompilerGenerated]
		private set { } //Length: 24
	}

	public Cinemachine3rdPersonAim() { }

	private Vector3 ComputeAimTarget(Vector3 cameraLookAt, Transform player) { }

	private Vector3 ComputeLookAtPoint(Vector3 camPos, Transform player) { }

	private void DrawReticle(CinemachineBrain brain) { }

	[CompilerGenerated]
	public Vector3 get_AimTarget() { }

	public virtual bool OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime) { }

	private void OnValidate() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	private void Reset() { }

	[CompilerGenerated]
	private void set_AimTarget(Vector3 value) { }

}

