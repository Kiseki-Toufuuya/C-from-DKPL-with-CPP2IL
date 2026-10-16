namespace XeSys;

public static class Math
{
	internal class CurveBezier2 : ICurveEvaluator
	{
		[CompilerGenerated]
		private Vector3 <p0>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Vector3 <p1>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private Vector3 <p2>k__BackingField; //Field offset: 0x20

		public Vector3 p0
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p1
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p2
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public CurveBezier2() { }

		public CurveBezier2(Vector3 p0, Vector3 p1, Vector3 p2) { }

		public static void CalcCoefficient(float t, out float tA, out float tB, out float tC) { }

		public override Vector3 Evaluate(float t) { }

		public static float Evaluate(float t, float p0, float p1, float p2) { }

		public static Vector2 Evaluate(float t, Vector2 p0, Vector2 p1, Vector2 p2) { }

		public static Vector3 Evaluate(float t, Vector3 p0, Vector3 p1, Vector3 p2) { }

		[CompilerGenerated]
		public Vector3 get_p0() { }

		[CompilerGenerated]
		public Vector3 get_p1() { }

		[CompilerGenerated]
		public Vector3 get_p2() { }

		[CompilerGenerated]
		public void set_p0(Vector3 value) { }

		[CompilerGenerated]
		public void set_p1(Vector3 value) { }

		[CompilerGenerated]
		public void set_p2(Vector3 value) { }

	}

	internal class CurveBezier3 : ICurveEvaluator
	{
		[CompilerGenerated]
		private Vector3 <p0>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Vector3 <p1>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private Vector3 <p2>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Vector3 <p3>k__BackingField; //Field offset: 0x2C

		public Vector3 p0
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p1
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p2
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p3
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public CurveBezier3(Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

		public static void CalcCoefficient(float t, out float tA, out float tB, out float tC, out float tD) { }

		public override Vector3 Evaluate(float t) { }

		public static float Evaluate(float t, float p0, float p1, float p2, float p3) { }

		public static Vector2 Evaluate(float t, Vector2 p0, Vector2 p1, Vector2 p2, Vector2 p3) { }

		public static Vector3 Evaluate(float t, Vector3 p0, Vector3 p1, Vector3 p2, Vector3 p3) { }

		[CompilerGenerated]
		public Vector3 get_p0() { }

		[CompilerGenerated]
		public Vector3 get_p1() { }

		[CompilerGenerated]
		public Vector3 get_p2() { }

		[CompilerGenerated]
		public Vector3 get_p3() { }

		[CompilerGenerated]
		public void set_p0(Vector3 value) { }

		[CompilerGenerated]
		public void set_p1(Vector3 value) { }

		[CompilerGenerated]
		public void set_p2(Vector3 value) { }

		[CompilerGenerated]
		public void set_p3(Vector3 value) { }

	}

	internal class CurveHermite : ICurveEvaluator
	{
		[CompilerGenerated]
		private Vector3 <p0>k__BackingField; //Field offset: 0x8
		[CompilerGenerated]
		private Vector3 <v0>k__BackingField; //Field offset: 0x14
		[CompilerGenerated]
		private Vector3 <p1>k__BackingField; //Field offset: 0x20
		[CompilerGenerated]
		private Vector3 <v1>k__BackingField; //Field offset: 0x2C

		public Vector3 p0
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p1
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 v0
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 v1
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public CurveHermite() { }

		public CurveHermite(Vector3 p0_, Vector3 v0_, Vector3 p1_, Vector3 v1_) { }

		public override Vector3 Evaluate(float t) { }

		[CompilerGenerated]
		public Vector3 get_p0() { }

		[CompilerGenerated]
		public Vector3 get_p1() { }

		[CompilerGenerated]
		public Vector3 get_v0() { }

		[CompilerGenerated]
		public Vector3 get_v1() { }

		[CompilerGenerated]
		public void set_p0(Vector3 value) { }

		[CompilerGenerated]
		public void set_p1(Vector3 value) { }

		[CompilerGenerated]
		public void set_v0(Vector3 value) { }

		[CompilerGenerated]
		public void set_v1(Vector3 value) { }

	}

	internal class CurveSpline : ICurveEvaluator
	{
		private enum Section
		{
			Start = 0,
			Intermediate = 1,
			End = 2,
		}

		private static Vector4[] mMatrixIntermediate; //Field offset: 0x0
		private static Vector4[] mMatrixStart; //Field offset: 0x4
		private static Vector4[] mMatrixEnd; //Field offset: 0x8
		private static Vector4[][] mMatrixTable; //Field offset: 0xC
		private Vector4 mTime; //Field offset: 0x8
		private Vector4[] mWork; //Field offset: 0x18
		[CompilerGenerated]
		private Vector3 <p0>k__BackingField; //Field offset: 0x1C
		[CompilerGenerated]
		private Vector3 <p1>k__BackingField; //Field offset: 0x28
		[CompilerGenerated]
		private Vector3 <p2>k__BackingField; //Field offset: 0x34
		[CompilerGenerated]
		private Vector3 <p3>k__BackingField; //Field offset: 0x40
		private Vector3[] mPointArray; //Field offset: 0x4C
		private int mSectionCount; //Field offset: 0x50
		private int mEndIndex; //Field offset: 0x54
		[CompilerGenerated]
		private int <section>k__BackingField; //Field offset: 0x58
		[CompilerGenerated]
		private float <sectionRatio>k__BackingField; //Field offset: 0x5C

		public Vector3 p0
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p1
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p2
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public Vector3 p3
		{
			[CompilerGenerated]
			 get { } //Length: 26
			[CompilerGenerated]
			 set { } //Length: 24
		}

		public int section
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 14
		}

		public private float sectionRatio
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			private set { } //Length: 18
		}

		private static CurveSpline() { }

		public CurveSpline(Vector3 p0_, Vector3 p1_, Vector3 p2_, Vector3 p3_) { }

		public CurveSpline() { }

		public CurveSpline(Vector3[] array) { }

		private Vector3 Evaluate(Vector4[] mat) { }

		public override Vector3 Evaluate(float t) { }

		public Vector3 Evaluate(float currentTime, float totalTime) { }

		public Vector3 EvaluatePoints(float current, float total) { }

		[CompilerGenerated]
		public Vector3 get_p0() { }

		[CompilerGenerated]
		public Vector3 get_p1() { }

		[CompilerGenerated]
		public Vector3 get_p2() { }

		[CompilerGenerated]
		public Vector3 get_p3() { }

		[CompilerGenerated]
		public int get_section() { }

		[CompilerGenerated]
		public float get_sectionRatio() { }

		[CompilerGenerated]
		public void set_p0(Vector3 value) { }

		[CompilerGenerated]
		public void set_p1(Vector3 value) { }

		[CompilerGenerated]
		public void set_p2(Vector3 value) { }

		[CompilerGenerated]
		public void set_p3(Vector3 value) { }

		[CompilerGenerated]
		public void set_section(int value) { }

		[CompilerGenerated]
		private void set_sectionRatio(float value) { }

		public void SetPoints(Vector3[] array) { }

		private void Setup(float t, Vector3 p0_, Vector3 p1_, Vector3 p2_, Vector3 p3_) { }

	}

	internal interface ICurveEvaluator
	{

		public Vector3 Evaluate(float t) { }

	}

	internal class RNSpline : ICurveEvaluator
	{
		internal class Node
		{
			public Vector3 position; //Field offset: 0x8
			public Vector3 velocity; //Field offset: 0x14
			public float distance; //Field offset: 0x20

			public Node(Vector3 p) { }

			public void MakeEndVelocity(Node prev) { }

			public void MakeStartVelocity(Node next) { }

			public void MakeVelocity(Vector3 p0, Vector3 p1, Vector3 p2) { }

		}

		private static Matrix4x4 mHermite; //Field offset: 0x0
		[CompilerGenerated]
		private float <maxDistance>k__BackingField; //Field offset: 0x8
		protected List<Node> mNodeList; //Field offset: 0xC

		protected float maxDistance
		{
			[CompilerGenerated]
			 get { } //Length: 11
			[CompilerGenerated]
			 set { } //Length: 18
		}

		protected int nodeCount
		{
			 get { } //Length: 52
		}

		public RNSpline() { }

		public void AddNode(Vector3 p) { }

		public override void Build() { }

		public override Vector3 Evaluate(float normalizedTime) { }

		[CompilerGenerated]
		protected float get_maxDistance() { }

		protected int get_nodeCount() { }

		public Vector3 GetEndVelocity(int index) { }

		private Vector3 GetPosition(Vector3 p0, Vector3 v0, Vector3 p1, Vector3 v1, float t) { }

		public Vector3 GetStartVelocity(int index) { }

		[CompilerGenerated]
		protected void set_maxDistance(float value) { }

	}

	internal class SNSpline : RNSpline
	{

		public SNSpline() { }

		public virtual void Build() { }

		protected override void Smooth() { }

	}

	internal class TNSpline : SNSpline
	{

		public TNSpline() { }

		public void AddNode(Vector3 p, float timeperiod) { }

		public virtual void Build() { }

		private void Constrain() { }

		protected virtual void Smooth() { }

	}

	internal class Tween
	{
		internal enum EasingFunc
		{
			Liner = 0,
			InQuad = 1,
			OutQuad = 2,
			InOutQuad = 3,
			InCubic = 4,
			OutCubic = 5,
			InOutCubic = 6,
			InQuart = 7,
			OutQuart = 8,
			InOutQuart = 9,
			InQuint = 10,
			OutQuint = 11,
			InOutQuint = 12,
			InSine = 13,
			OutSine = 14,
			InOutSine = 15,
			InExpo = 16,
			OutExpo = 17,
			InOutExpo = 18,
			InCirc = 19,
			OutCirc = 20,
			InOutCirc = 21,
			InBack = 22,
			OutBack = 23,
			InOutBack = 24,
			InBounce = 25,
			OutBounce = 26,
			InOutBounce = 27,
			InElastic = 28,
			OutElastic = 29,
			InOutElastic = 30,
		}

		private const float RAD90 = 1.5707964; //Field offset: 0x0
		private const float RAD180 = 3.1415927; //Field offset: 0x0
		public static float S; //Field offset: 0x0
		private const float BOUNCE_T = 2.75; //Field offset: 0x0

		private static Tween() { }

		public Tween() { }

		public static float EasingInBack(float start, float end, float t) { }

		public static float EasingInBounce(float start, float end, float t) { }

		public static float EasingInCirc(float start, float end, float t) { }

		public static float EasingInCubic(float start, float end, float t) { }

		public static float EasingInElastic(float start, float end, float t) { }

		public static float EasingInExpo(float start, float end, float t) { }

		public static float EasingInOutBack(float start, float end, float t) { }

		public static float EasingInOutBounce(float start, float end, float t) { }

		public static float EasingInOutCirc(float start, float end, float t) { }

		public static float EasingInOutCubic(float start, float end, float t) { }

		public static float EasingInOutElastic(float start, float end, float t) { }

		public static float EasingInOutExpo(float start, float end, float t) { }

		public static float EasingInOutQuad(float start, float end, float t) { }

		public static float EasingInOutQuart(float start, float end, float t) { }

		public static float EasingInOutQuint(float start, float end, float t) { }

		public static float EasingInOutSine(float start, float end, float t) { }

		public static float EasingInQuad(float start, float end, float t) { }

		public static float EasingInQuart(float start, float end, float t) { }

		public static float EasingInQuint(float start, float end, float t) { }

		public static float EasingInSine(float start, float end, float t) { }

		public static float EasingLerp(float start, float end, float t) { }

		public static float EasingOutBack(float start, float end, float t) { }

		public static float EasingOutBounce(float start, float end, float t) { }

		public static float EasingOutCirc(float start, float end, float t) { }

		public static float EasingOutCubic(float start, float end, float t) { }

		public static float EasingOutElastic(float start, float end, float t) { }

		public static float EasingOutExpo(float start, float end, float t) { }

		public static float EasingOutQuad(float start, float end, float t) { }

		public static float EasingOutQuart(float start, float end, float t) { }

		public static float EasingOutQuint(float start, float end, float t) { }

		public static float EasingOutSine(float start, float end, float t) { }

		public static Color Evaluate(EasingFunc efunc, Color start, Color end, float t) { }

		public static Vector2 Evaluate(EasingFunc efunc, Vector2 start, Vector2 end, float t) { }

		public static Vector3 Evaluate(EasingFunc type, Vector3 start, Vector3 end, float t) { }

		public static float Evaluate(EasingFunc type, float start, float end, float t) { }

	}


	public static int CalcAngleType(int divCount, Vector2 start, Vector2 end, bool isHalfOffset) { }

	public static float CalcDegree(Vector2 start, Vector2 end) { }

	public static float CalcNearDistanceLineToLine(Vector3 line1StartPoint, Vector3 line1EndPoint, Vector3 line2StartPoint, Vector3 line2EndPoint, out float line1NearestTargetRate, out float line2NearestTargetRate) { }

	public static float CalcNearDistancePointToLine(Vector3 point, Vector3 lineStart, Vector3 lineEnd, out float lineNearestTargetRate) { }

	public static float CalcRadian(Vector2 start, Vector2 end) { }

	public static float GetDecimalPart(float v) { }

	public static bool IsInfinity(float v) { }

	public static Vector3 NoClampLerp(Vector3 start, Vector3 end, float t) { }

	public static bool Random100(float rate) { }

	public static int Repeat(int val, int min, int max) { }

	public static float Repeat(float val, float min, float max) { }

	public static Vector2 Repeat(Vector2 val, Vector2 min, Vector2 max) { }

	public static Vector3 Repeat(Vector3 val, Vector3 min, Vector3 max) { }

	public static Color Repeat(Color val, Color min, Color max) { }

}

