namespace Cinemachine;

[AddComponentMenu("Cinemachine/CinemachinePath")]
[DisallowMultipleComponent]
[DocumentationSorting(Level::UserRef (2))]
[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.9/manual/CinemachinePath.html")]
[SaveDuringPlay]
public class CinemachinePath : CinemachinePathBase
{
	[DocumentationSorting(Level::UserRef (2))]
	internal struct Waypoint
	{
		[Tooltip("Position in path-local space")]
		public Vector3 position; //Field offset: 0x0
		[Tooltip("Offset from the position, which defines the tangent of the curve at the waypoint.  The length of the tangent encodes the strength of the bezier handle.  The same handle is used symmetrically on both sides of the waypoint, to ensure smoothness.")]
		public Vector3 tangent; //Field offset: 0xC
		[Tooltip("Defines the roll of the path at this waypoint.  The other orientation axes are inferred from the tangent and world up.")]
		public float roll; //Field offset: 0x18

	}

	[Tooltip("If checked, then the path ends are joined to form a continuous loop.")]
	public bool m_Looped; //Field offset: 0x30
	[Tooltip("The waypoints that define the path.  They will be interpolated using a bezier curve.")]
	public Waypoint[] m_Waypoints; //Field offset: 0x34

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

	public CinemachinePath() { }

	public virtual Quaternion EvaluateLocalOrientation(float pos) { }

	public virtual Vector3 EvaluateLocalPosition(float pos) { }

	public virtual Vector3 EvaluateLocalTangent(float pos) { }

	public virtual int get_DistanceCacheSampleStepsPerSegment() { }

	public virtual bool get_Looped() { }

	public virtual float get_MaxPos() { }

	public virtual float get_MinPos() { }

	private float GetBoundingIndices(float pos, out int indexA, out int indexB) { }

	internal float GetRoll(int indexA, int indexB, float standardizedPos) { }

	private void OnValidate() { }

	private void Reset() { }

	private static Quaternion RollAroundForward(float angle) { }

}

