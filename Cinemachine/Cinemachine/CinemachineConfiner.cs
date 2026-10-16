namespace Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineConfiner.html")]
[SaveDuringPlay]
public class CinemachineConfiner : CinemachineExtension
{
	internal enum Mode
	{
		Confine2D = 0,
		Confine3D = 1,
	}

	private class VcamExtraState
	{
		public Vector3 m_previousDisplacement; //Field offset: 0x8
		public float confinerDisplacement; //Field offset: 0x14

		public VcamExtraState() { }

	}

	[Tooltip("The confiner can operate using a 2D bounding shape or a 3D bounding volume")]
	public Mode m_ConfineMode; //Field offset: 0x18
	[Tooltip("The volume within which the camera is to be contained")]
	public Collider m_BoundingVolume; //Field offset: 0x1C
	[Tooltip("The 2D shape within which the camera is to be contained")]
	public Collider2D m_BoundingShape2D; //Field offset: 0x20
	private Collider2D m_BoundingShape2DCache; //Field offset: 0x24
	[Tooltip("If camera is orthographic, screen edges will be confined to the volume.  If not checked, then only the camera center will be confined")]
	public bool m_ConfineScreenEdges; //Field offset: 0x28
	[Range(0, 10)]
	[Tooltip("How gradually to return the camera to the bounding volume if it goes beyond the borders.  Higher numbers are more gradual.")]
	public float m_Damping; //Field offset: 0x2C
	private List<List`1<Vector2>> m_pathCache; //Field offset: 0x30
	private int m_pathTotalPointCount; //Field offset: 0x34

	public bool IsValid
	{
		 get { } //Length: 279
	}

	public CinemachineConfiner() { }

	public bool CameraWasDisplaced(CinemachineVirtualCameraBase vcam) { }

	private Vector3 ConfinePoint(Vector3 camPos) { }

	private Vector3 ConfineScreenEdges(ref CameraState state) { }

	protected virtual void ConnectToVcam(bool connect) { }

	public bool get_IsValid() { }

	public float GetCameraDisplacementDistance(CinemachineVirtualCameraBase vcam) { }

	public virtual float GetMaxDampTime() { }

	public void InvalidatePathCache() { }

	private void OnValidate() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	private bool ValidatePathCache() { }

}

