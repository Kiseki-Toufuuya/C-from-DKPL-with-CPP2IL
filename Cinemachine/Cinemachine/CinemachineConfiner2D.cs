namespace Cinemachine;

[AddComponentMenu(null)]
[DisallowMultipleComponent]
[ExecuteAlways]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineConfiner2D.html")]
[SaveDuringPlay]
public class CinemachineConfiner2D : CinemachineExtension
{
	private struct ShapeCache
	{
		public ConfinerOven m_confinerOven; //Field offset: 0x0
		public List<List`1<Vector2>> m_OriginalPath; //Field offset: 0x4
		public Matrix4x4 m_DeltaWorldToBaked; //Field offset: 0x8
		public Matrix4x4 m_DeltaBakedToWorld; //Field offset: 0x48
		private float m_aspectRatio; //Field offset: 0x88
		private float m_maxWindowSize; //Field offset: 0x8C
		private float m_skeletonPadding; //Field offset: 0x90
		internal float m_maxComputationTimePerFrameInSeconds; //Field offset: 0x94
		private Matrix4x4 m_bakedToWorld; //Field offset: 0x98
		private Collider2D m_boundingShape2D; //Field offset: 0xD8

		private void CalculateDeltaTransformationMatrix() { }

		public void Invalidate() { }

		private bool IsValid(in Collider2D boundingShape2D, in float aspectRatio, in float maxOrthoSize, in float padding) { }

		public bool ValidateCache(Collider2D boundingShape2D, float maxWindowSize, float aspectRatio, float skeletonPadding, out bool confinerStateChanged) { }

	}

	private class VcamExtraState
	{
		public Vector3 m_PreviousDisplacement; //Field offset: 0x8
		public Vector3 m_DampedDisplacement; //Field offset: 0x14
		public BakedSolution m_BakedSolution; //Field offset: 0x20
		public CinemachineVirtualCameraBase m_vcam; //Field offset: 0x24

		public VcamExtraState() { }

	}

	private const float k_cornerAngleTreshold = 10; //Field offset: 0x0
	[Tooltip("The 2D shape within which the camera is to be contained.  Can be a 2D polygon or 2D composite collider.")]
	public Collider2D m_BoundingShape2D; //Field offset: 0x18
	[Range(0, 5)]
	[Tooltip("Damping applied around corners to avoid jumps.  Higher numbers are more gradual.")]
	public float m_Damping; //Field offset: 0x1C
	[Tooltip("To optimize computation and memory costs, set this to the largest view size that the camera is expected to have.  The confiner will not compute a polygon cache for frustum sizes larger than this.  This refers to the size in world units of the frustum at the confiner plane (for orthographic cameras, this is just the orthographic size).  If set to 0, then this parameter is ignored and a polygon cache will be calculated for all potential window sizes.")]
	public float m_MaxWindowSize; //Field offset: 0x20
	[Range(0, 100)]
	[Tooltip("For large window sizes, the confiner will potentially generate polygons with zero area.  The padding may be used to add a small amount of area to these polygons, to prevent them from being a series of disconnected dots.")]
	public float m_Padding; //Field offset: 0x24
	private float m_MaxComputationTimePerFrameInSeconds; //Field offset: 0x28
	private ShapeCache m_shapeCache; //Field offset: 0x2C

	public CinemachineConfiner2D() { }

	private float CalculateHalfFrustumHeight(in CameraState state, in float cameraPosLocalZ) { }

	public void InvalidateCache() { }

	private void OnValidate() { }

	protected virtual void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, Stage stage, ref CameraState state, float deltaTime) { }

	private void Reset() { }

	public bool ValidateCache(float cameraAspectRatio) { }

}

