namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachineSmoothPath")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachineSmoothPath.html")]
[SaveDuringPlay]
public class CinemachineSmoothPath : CinemachinePathBase
{
	[DocumentationSorting(Level::UserRef (2))]
	internal struct Waypoint
	{
		[Tooltip("Position in path-local space")]
		public Vector3 position; //Field offset: 0x0
		[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
		public float roll; //Field offset: 0xC

		internal Vector4 AsVector4
		{
			internal get { } //Length: 33
		}

		internal static Waypoint FromVector4(Vector4 v) { }

		internal Vector4 get_AsVector4() { }

	}

	[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
	public bool m_Looped; //Field offset: 0x30
	[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
	public Waypoint[] m_Waypoints; //Field offset: 0x34
	internal Waypoint[] m_ControlPoints1; //Field offset: 0x38
	internal Waypoint[] m_ControlPoints2; //Field offset: 0x3C
	private bool m_IsLoopedCache; //Field offset: 0x40

	public virtual int DistanceCacheSampleStepsPerSegment
	{
		 get { } //Length: 11
	}

	public virtual bool Looped
	{
		 get { } //Length: 11
	}

	public virtual float MaxPos
	{
		 get { } //Length: 57
	}

	public virtual float MinPos
	{
		 get { } //Length: 3
	}

	public CinemachineSmoothPath() { }

	public virtual Quaternion EvaluateLocalOrientation(float pos) { }

	public virtual Vector3 EvaluateLocalPosition(float pos) { }

	public virtual Vector3 EvaluateLocalTangent(float pos) { }

	public virtual int get_DistanceCacheSampleStepsPerSegment() { }

	public virtual bool get_Looped() { }

	public virtual float get_MaxPos() { }

	public virtual float get_MinPos() { }

	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	public virtual void InvalidateDistanceCache() { }

	private void OnValidate() { }

	private void Reset() { }

	private static Quaternion RollAroundForward(float angle) { }

	internal void UpdateControlPoints() { }

}

