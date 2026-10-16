namespace Cinemachine;

[AddComponentMenu(null)]
[DocumentationSorting(Level::UserRef (2))]
[SaveDuringPlay]
public class CinemachineGroupComposer : CinemachineComposer
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
	}

	[Space]
	[Tooltip("The bounding box of the targets should occupy this amount of the screen space.  1 means fill the whole screen.  0.5 means fill half the screen, etc.")]
	public float m_GroupFramingSize; //Field offset: 0xE8
	[Tooltip("What screen dimensions to consider when framing.  Can be Horizontal, Vertical, or both")]
	public FramingMode m_FramingMode; //Field offset: 0xEC
	[Range(0, 20)]
	[Tooltip("How aggressively the camera tries to frame the group. Small numbers are more responsive, rapidly adjusting the camera to keep the group in the frame.  Larger numbers give a more heavy slowly responding camera.")]
	public float m_FrameDamping; //Field offset: 0xF0
	[Tooltip("How to adjust the camera to get the desired framing.  You can zoom, dolly in/out, or do both.")]
	public AdjustmentMode m_AdjustmentMode; //Field offset: 0xF4
	[Tooltip("The maximum distance toward the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyIn; //Field offset: 0xF8
	[Tooltip("The maximum distance away the target that this behaviour is allowed to move the camera.")]
	public float m_MaxDollyOut; //Field offset: 0xFC
	[Tooltip("Set this to limit how close to the target the camera can get.")]
	public float m_MinimumDistance; //Field offset: 0x100
	[Tooltip("Set this to limit how far from the target the camera can get.")]
	public float m_MaximumDistance; //Field offset: 0x104
	[Range(1, 179)]
	[Tooltip("If adjusting FOV, will not set the FOV lower than this.")]
	public float m_MinimumFOV; //Field offset: 0x108
	[Range(1, 179)]
	[Tooltip("If adjusting FOV, will not set the FOV higher than this.")]
	public float m_MaximumFOV; //Field offset: 0x10C
	[Tooltip("If adjusting Orthographic Size, will not set it lower than this.")]
	public float m_MinimumOrthoSize; //Field offset: 0x110
	[Tooltip("If adjusting Orthographic Size, will not set it higher than this.")]
	public float m_MaximumOrthoSize; //Field offset: 0x114
	private float m_prevFramingDistance; //Field offset: 0x118
	private float m_prevFOV; //Field offset: 0x11C
	[CompilerGenerated]
	private Bounds <LastBounds>k__BackingField; //Field offset: 0x120
	[CompilerGenerated]
	private Matrix4x4 <LastBoundsMatrix>k__BackingField; //Field offset: 0x138

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

	public CinemachineGroupComposer() { }

	[CompilerGenerated]
	public Bounds get_LastBounds() { }

	[CompilerGenerated]
	public Matrix4x4 get_LastBoundsMatrix() { }

	public virtual float GetMaxDampTime() { }

	private static Bounds GetScreenSpaceGroupBoundingBox(ICinemachineTargetGroup group, Matrix4x4 observer, out Vector3 newFwd) { }

	private float GetTargetHeight(Vector2 boundsSize) { }

	public virtual void MutateCameraState(ref CameraState curState, float deltaTime) { }

	private void OnValidate() { }

	[CompilerGenerated]
	private void set_LastBounds(Bounds value) { }

	[CompilerGenerated]
	private void set_LastBoundsMatrix(Matrix4x4 value) { }

}

