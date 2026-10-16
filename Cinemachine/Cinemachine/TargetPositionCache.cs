namespace Cinemachine;

internal class TargetPositionCache
{
	private class CacheCurve
	{
		internal struct Item
		{
			public Vector3 Pos; //Field offset: 0x0
			public Quaternion Rot; //Field offset: 0xC

			public static Item Empty
			{
				 get { } //Length: 75
			}

			public static Item get_Empty() { }

			public static Item Lerp(Item a, Item b, float t) { }

		}

		public float StartTime; //Field offset: 0x8
		public float StepSize; //Field offset: 0xC
		private List<Item> m_Cache; //Field offset: 0x10

		public int Count
		{
			 get { } //Length: 52
		}

		public CacheCurve(float startTime, float endTime, float stepSize) { }

		public void Add(Item item) { }

		public void AddUntil(Item item, float time, bool isCut) { }

		public Item Evaluate(float time) { }

		public int get_Count() { }

	}

	private class CacheEntry
	{
		private struct RecordingItem
		{
			public float Time; //Field offset: 0x0
			public bool IsCut; //Field offset: 0x4
			public Item Item; //Field offset: 0x8

		}

		public CacheCurve Curve; //Field offset: 0x8
		private List<RecordingItem> RawItems; //Field offset: 0xC

		public CacheEntry() { }

		public void AddRawItem(float time, bool isCut, Transform target) { }

		public void CreateCurves() { }

	}

	internal enum Mode
	{
		Disabled = 0,
		Record = 1,
		Playback = 2,
	}

	internal struct TimeRange
	{
		public float Start; //Field offset: 0x0
		public float End; //Field offset: 0x4

		public static TimeRange Empty
		{
			 get { } //Length: 30
		}

		public bool IsEmpty
		{
			 get { } //Length: 19
		}

		public bool Contains(float time) { }

		public static TimeRange get_Empty() { }

		public bool get_IsEmpty() { }

		public void Include(float time) { }

	}

	public static bool UseCache; //Field offset: 0x0
	public const float CacheStepSize = 0.016666668; //Field offset: 0x0
	private const float kWraparoundSlush = 0.1; //Field offset: 0x0
	private static Mode m_CacheMode; //Field offset: 0x4
	public static float CurrentTime; //Field offset: 0x8
	public static int CurrentFrame; //Field offset: 0xC
	public static bool IsCameraCut; //Field offset: 0x10
	private static Dictionary<Transform, CacheEntry> m_Cache; //Field offset: 0x14
	private static TimeRange m_CacheTimeRange; //Field offset: 0x18

	public static Mode CacheMode
	{
		 get { } //Length: 41
		 set { } //Length: 396
	}

	public static TimeRange CacheTimeRange
	{
		 get { } //Length: 73
	}

	public static bool CurrentPlaybackTimeValid
	{
		 get { } //Length: 115
	}

	public static bool HasCurrentTime
	{
		 get { } //Length: 66
	}

	public static bool IsEmpty
	{
		 get { } //Length: 50
	}

	public static bool IsRecording
	{
		 get { } //Length: 54
	}

	public TargetPositionCache() { }

	public static void ClearCache() { }

	private static void CreatePlaybackCurves() { }

	public static Mode get_CacheMode() { }

	public static TimeRange get_CacheTimeRange() { }

	public static bool get_CurrentPlaybackTimeValid() { }

	public static bool get_HasCurrentTime() { }

	public static bool get_IsEmpty() { }

	public static bool get_IsRecording() { }

	public static Vector3 GetTargetPosition(Transform target) { }

	public static Quaternion GetTargetRotation(Transform target) { }

	public static void set_CacheMode(Mode value) { }

}

