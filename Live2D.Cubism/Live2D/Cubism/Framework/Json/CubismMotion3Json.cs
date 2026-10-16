namespace Live2D.Cubism.Framework.Json;

public sealed class CubismMotion3Json
{
	private sealed class SegmentParser : MulticastDelegate
	{

		public SegmentParser(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(Single[] segments, List<Keyframe> result, ref int position, AsyncCallback callback, object object) { }

		public override void EndInvoke(ref int position, IAsyncResult result) { }

		public override void Invoke(Single[] segments, List<Keyframe> result, ref int position) { }

	}

	internal struct SerializableCurve
	{
		[SerializeField]
		public string Target; //Field offset: 0x0
		[SerializeField]
		public string Id; //Field offset: 0x4
		[SerializeField]
		public Single[] Segments; //Field offset: 0x8
		[SerializeField]
		public float FadeInTime; //Field offset: 0xC
		[SerializeField]
		public float FadeOutTime; //Field offset: 0x10

	}

	internal struct SerializableMeta
	{
		[SerializeField]
		public float Duration; //Field offset: 0x0
		[SerializeField]
		public float Fps; //Field offset: 0x4
		[SerializeField]
		public bool Loop; //Field offset: 0x8
		[SerializeField]
		public int CurveCount; //Field offset: 0xC
		[SerializeField]
		public int TotalSegmentCount; //Field offset: 0x10
		[SerializeField]
		public int TotalPointCount; //Field offset: 0x14
		[SerializeField]
		public bool AreBeziersRestricted; //Field offset: 0x18
		[SerializeField]
		public int UserDataCount; //Field offset: 0x1C
		[SerializeField]
		public int TotalUserDataSize; //Field offset: 0x20
		[SerializeField]
		public float FadeInTime; //Field offset: 0x24
		[SerializeField]
		public float FadeOutTime; //Field offset: 0x28

	}

	internal struct SerializableUserData
	{
		[SerializeField]
		public float Time; //Field offset: 0x0
		[SerializeField]
		public string Value; //Field offset: 0x4

	}

	private const float OffsetGranularity = 0.01; //Field offset: 0x0
	private static Dictionary<Single, SegmentParser> Parsers; //Field offset: 0x0
	[SerializeField]
	public int Version; //Field offset: 0x8
	[SerializeField]
	public SerializableMeta Meta; //Field offset: 0xC
	[SerializeField]
	public SerializableCurve[] Curves; //Field offset: 0x38
	[SerializeField]
	public SerializableUserData[] UserData; //Field offset: 0x3C

	private static CubismMotion3Json() { }

	private CubismMotion3Json() { }

	public static Keyframe[] ConvertCurveSegmentsToKeyframes(Single[] segments) { }

	public static AnimationCurve ConvertSteppedCurveToLinerCurver(SerializableCurve curve, float poseFadeInTime) { }

	public bool HasConsistency() { }

	public static CubismMotion3Json LoadFrom(string motion3Json, bool shouldCheckMotionConsistency = true) { }

	public static CubismMotion3Json LoadFrom(TextAsset motion3JsonAsset, bool shouldCheckMotionConsistency = true) { }

	private static void ParseBezierSegment(Single[] segments, List<Keyframe> result, ref int position) { }

	private static void ParseInverseSteppedSegment(Single[] segments, List<Keyframe> result, ref int position) { }

	private static void ParseLinearSegment(Single[] segments, List<Keyframe> result, ref int position) { }

	private static void ParseSteppedSegment(Single[] segments, List<Keyframe> result, ref int position) { }

	public AnimationClip ToAnimationClip(bool shouldImportAsOriginalWorkflow = false, bool shouldClearAnimationCurves = false, bool isCallFormModelJson = false, CubismPose3Json poseJson = null) { }

	public AnimationClip ToAnimationClip(AnimationClip animationClip, bool shouldImportAsOriginalWorkflow = false, bool shouldClearAnimationCurves = false, bool isCallFormModelJson = false, CubismPose3Json poseJson = null) { }

}

