namespace Cinemachine;

public abstract class CinemachinePathBase : MonoBehaviour
{
	[DocumentationSorting(Level::UserRef (2))]
	internal class Appearance
	{
		[Tooltip("The color of the path itself when it is active in the editor")]
		public Color pathColor; //Field offset: 0x8
		[Tooltip("The color of the path itself when it is inactive in the editor")]
		public Color inactivePathColor; //Field offset: 0x18
		[Range(0, 10)]
		[Tooltip("The width of the railroad-tracks that are drawn to represent the path")]
		public float width; //Field offset: 0x28

		public Appearance() { }

	}

	internal enum PositionUnits
	{
		PathUnits = 0,
		Distance = 1,
		Normalized = 2,
	}

	[Range(1, 100)]
	[Tooltip("Path samples per waypoint.  This is used for calculating path distances.")]
	public int m_Resolution; //Field offset: 0x10
	[Tooltip("The settings that control how the path will appear in the editor scene view.")]
	public Appearance m_Appearance; //Field offset: 0x14
	private Single[] m_DistanceToPos; //Field offset: 0x18
	private Single[] m_PosToDistance; //Field offset: 0x1C
	private int m_CachedSampleSteps; //Field offset: 0x20
	private float m_PathLength; //Field offset: 0x24
	private float m_cachedPosStepSize; //Field offset: 0x28
	private float m_cachedDistanceStepSize; //Field offset: 0x2C

	public abstract int DistanceCacheSampleStepsPerSegment
	{
		 get { } //Length: 0
	}

	public abstract bool Looped
	{
		 get { } //Length: 0
	}

	public abstract float MaxPos
	{
		 get { } //Length: 0
	}

	public abstract float MinPos
	{
		 get { } //Length: 0
	}

	public float PathLength
	{
		 get { } //Length: 194
	}

	protected CinemachinePathBase() { }

	public bool DistanceCacheIsValid() { }

	public abstract Quaternion EvaluateLocalOrientation(float pos) { }

	public abstract Vector3 EvaluateLocalPosition(float pos) { }

	public abstract Vector3 EvaluateLocalTangent(float pos) { }

	public override Quaternion EvaluateOrientation(float pos) { }

	public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units) { }

	public override Vector3 EvaluatePosition(float pos) { }

	public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units) { }

	public override Vector3 EvaluateTangent(float pos) { }

	public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units) { }

	public override float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment) { }

	public float FromPathNativeUnits(float pos, PositionUnits units) { }

	public abstract int get_DistanceCacheSampleStepsPerSegment() { }

	public abstract bool get_Looped() { }

	public abstract float get_MaxPos() { }

	public abstract float get_MinPos() { }

	public float get_PathLength() { }

	public override void InvalidateDistanceCache() { }

	public float MaxUnit(PositionUnits units) { }

	public float MinUnit(PositionUnits units) { }

	private void ResamplePath(int stepsPerSegment) { }

	public float StandardizePathDistance(float distance) { }

	public override float StandardizePos(float pos) { }

	public override float StandardizeUnit(float pos, PositionUnits units) { }

	public float ToNativePathUnits(float pos, PositionUnits units) { }

}

