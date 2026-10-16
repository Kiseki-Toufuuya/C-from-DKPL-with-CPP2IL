namespace DG.Tweening.Plugins.Core.PathCore;

public class Path
{
	private static CatmullRomDecoder _catmullRomDecoder; //Field offset: 0x0
	private static LinearDecoder _linearDecoder; //Field offset: 0x4
	private static CubicBezierDecoder _cubicBezierDecoder; //Field offset: 0x8
	public Single[] wpLengths; //Field offset: 0x8
	[SerializeField]
	public Vector3[] wps; //Field offset: 0xC
	[SerializeField]
	internal PathType type; //Field offset: 0x10
	[SerializeField]
	internal int subdivisionsXSegment; //Field offset: 0x14
	[SerializeField]
	internal int subdivisions; //Field offset: 0x18
	[SerializeField]
	internal ControlPoint[] controlPoints; //Field offset: 0x1C
	[SerializeField]
	internal float length; //Field offset: 0x20
	[SerializeField]
	internal bool isFinalized; //Field offset: 0x24
	[SerializeField]
	internal Single[] timesTable; //Field offset: 0x28
	[SerializeField]
	internal Single[] lengthsTable; //Field offset: 0x2C
	internal int linearWPIndex; //Field offset: 0x30
	internal bool addedExtraStartWp; //Field offset: 0x34
	internal bool addedExtraEndWp; //Field offset: 0x35
	internal PathOptions plugOptions; //Field offset: 0x38
	private Path _incrementalClone; //Field offset: 0x98
	private int _incrementalIndex; //Field offset: 0x9C
	private ABSPathDecoder _decoder; //Field offset: 0xA0
	private bool _changed; //Field offset: 0xA4
	internal Vector3[] nonLinearDrawWps; //Field offset: 0xA8
	internal Vector3 targetPosition; //Field offset: 0xAC
	internal Nullable<Vector3> lookAtPosition; //Field offset: 0xB8
	internal Color gizmoColor; //Field offset: 0xC8

	internal int minInputWaypoints
	{
		internal get { } //Length: 43
	}

	public Path(PathType type, Vector3[] waypoints, int subdivisionsXSegment, Nullable<Color> gizmoColor = null) { }

	internal Path() { }

	internal void AssignDecoder(PathType pathType) { }

	internal void AssignWaypoints(Vector3[] newWps, bool cloneWps = false) { }

	internal Path CloneIncremental(int loopIncrement) { }

	internal float ConvertToConstantPathPerc(float perc) { }

	private static Vector3 ConvertToDrawPoint(Vector3 wp, PathOptions plugOptions) { }

	internal void Destroy() { }

	internal void Draw() { }

	private static void Draw(Path p) { }

	internal void FinalizePath(bool isClosedPath, AxisConstraint lockPositionAxes, Vector3 currTargetVal) { }

	internal int get_minInputWaypoints() { }

	internal static Vector3[] GetDrawPoints(Path p, int drawSubdivisionsXSegment) { }

	internal Vector3 GetPoint(float perc, bool convertToConstantPerc = false) { }

	internal int GetWaypointIndexFromPerc(float perc, bool isMovingForward) { }

	internal static void RefreshNonLinearDrawWps(Path p) { }

}

