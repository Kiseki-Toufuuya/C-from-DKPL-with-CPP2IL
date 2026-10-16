namespace Cinemachine;

internal class ConfinerOven
{
	[IsReadOnly]
	private struct AspectStretcher
	{
		[CompilerGenerated]
		private readonly float <Aspect>k__BackingField; //Field offset: 0x0
		private readonly float m_InverseAspect; //Field offset: 0x4
		private readonly float m_CenterX; //Field offset: 0x8

		public float Aspect
		{
			[CompilerGenerated]
			 get { } //Length: 10
		}

		public AspectStretcher(float aspect, float centerX) { }

		[CompilerGenerated]
		public float get_Aspect() { }

		public Vector2 Stretch(Vector2 p) { }

		public Vector2 Unstretch(Vector2 p) { }

	}

	internal class BakedSolution
	{
		[CompilerGenerated]
		private sealed class <>c__DisplayClass9_0
		{
			public IntPoint point; //Field offset: 0x8

			public <>c__DisplayClass9_0() { }

			internal bool <ConfinePoint>b__4(List<IntPoint> t) { }

		}

		private const double k_ClipperEpsilon = 1000; //Field offset: 0x0
		private float m_FrustumSizeIntSpace; //Field offset: 0x8
		private readonly AspectStretcher m_AspectStretcher; //Field offset: 0xC
		private readonly bool m_HasBones; //Field offset: 0x18
		private readonly double m_SqrPolygonDiagonal; //Field offset: 0x20
		private List<List`1<IntPoint>> m_OriginalPolygon; //Field offset: 0x28
		private List<List`1<IntPoint>> m_Solution; //Field offset: 0x2C

		public BakedSolution(float aspectRatio, float frustumHeight, bool hasBones, Rect polygonBounds, List<List`1<IntPoint>> originalPolygon, List<List`1<IntPoint>> solution) { }

		[CompilerGenerated]
		internal static float <ConfinePoint>g__ClosestPointOnSegment|9_2(IntPoint point, IntPoint s0, IntPoint s1) { }

		[CompilerGenerated]
		private bool <ConfinePoint>g__DoesIntersectOriginal|9_3(IntPoint l1, IntPoint l2) { }

		[CompilerGenerated]
		internal static IntPoint <ConfinePoint>g__IntPointLerp|9_0(IntPoint a, IntPoint b, float lerp) { }

		[CompilerGenerated]
		private bool <ConfinePoint>g__IsInsideOriginal|9_1(IntPoint point) { }

		[CompilerGenerated]
		internal static double <FindIntersection>g__IntPointDiffSqrMagnitude|10_0(IntPoint point1, IntPoint point2) { }

		public Vector2 ConfinePoint(in Vector2 pointToConfine) { }

		private static int FindIntersection(in IntPoint p1, in IntPoint p2, in IntPoint p3, in IntPoint p4) { }

		public bool IsValid() { }

	}

	internal enum BakingState
	{
		BAKING = 0,
		BAKED = 1,
		TIMEOUT = 2,
	}

	private struct BakingStateCache
	{
		public ClipperOffset offsetter; //Field offset: 0x0
		public List<PolygonSolution> solutions; //Field offset: 0x4
		public PolygonSolution rightCandidate; //Field offset: 0x8
		public PolygonSolution leftCandidate; //Field offset: 0x10
		public List<List`1<IntPoint>> maxCandidate; //Field offset: 0x18
		public float stepSize; //Field offset: 0x1C
		public float maxFrustumHeight; //Field offset: 0x20
		public float userSetMaxFrustumHeight; //Field offset: 0x24
		public float theoriticalMaxFrustumHeight; //Field offset: 0x28
		public float currentFrustumHeight; //Field offset: 0x2C
		public float bakeTime; //Field offset: 0x30

	}

	private struct PolygonSolution
	{
		public List<List`1<IntPoint>> polygons; //Field offset: 0x0
		public float frustumHeight; //Field offset: 0x4

		public bool IsNull
		{
			 get { } //Length: 14
		}

		public bool get_IsNull() { }

		public bool StateChanged(in List<List`1<IntPoint>>& paths) { }

	}

	private const long k_FloatToIntScaler = 100000; //Field offset: 0x0
	private const float k_IntToFloatScaler = 1E-05; //Field offset: 0x0
	private const float k_MinStepSize = 0.0005; //Field offset: 0x0
	private float m_MinFrustumHeightWithBones; //Field offset: 0x8
	private float m_SkeletonPadding; //Field offset: 0xC
	private List<List`1<IntPoint>> m_OriginalPolygon; //Field offset: 0x10
	private IntPoint m_MidPoint; //Field offset: 0x18
	private List<List`1<IntPoint>> m_Skeleton; //Field offset: 0x28
	private Rect m_PolygonRect; //Field offset: 0x2C
	private AspectStretcher m_AspectStretcher; //Field offset: 0x3C
	private float m_MaxComputationTimeForFullSkeletonBakeInSeconds; //Field offset: 0x48
	[CompilerGenerated]
	private BakingState <State>k__BackingField; //Field offset: 0x4C
	public float bakeProgress; //Field offset: 0x50
	private BakingStateCache m_Cache; //Field offset: 0x54

	public private BakingState State
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public ConfinerOven(in List<List`1<Vector2>>& inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	[CompilerGenerated]
	private void <BakeConfiner>g__ComputeSkeleton|25_0(in List<PolygonSolution>& solutions) { }

	[CompilerGenerated]
	internal static Rect <Initialize>g__GetPolygonBoundingBox|24_0(in List<List`1<Vector2>>& polygons) { }

	[CompilerGenerated]
	internal static IntPoint <Initialize>g__MidPointOfIntRect|24_1(IntRect bounds) { }

	public void BakeConfiner(float maxComputationTimePerFrameInSeconds) { }

	[CompilerGenerated]
	public BakingState get_State() { }

	public BakedSolution GetBakedSolution(float frustumHeight) { }

	private void Initialize(in List<List`1<Vector2>>& inputPath, in float aspectRatio, float maxFrustumHeight, float skeletonPadding) { }

	[CompilerGenerated]
	private void set_State(BakingState value) { }

}

