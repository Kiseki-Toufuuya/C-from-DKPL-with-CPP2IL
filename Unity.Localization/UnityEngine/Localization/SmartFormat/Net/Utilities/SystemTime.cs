namespace UnityEngine.Localization.SmartFormat.Net.Utilities;

internal static class SystemTime
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static Func<DateTime> <>9__4_0; //Field offset: 0x4
		public static Func<DateTimeOffset> <>9__4_1; //Field offset: 0x8

		private static <>c() { }

		public <>c() { }

		internal DateTime <.cctor>b__5_0() { }

		internal DateTimeOffset <.cctor>b__5_1() { }

		internal DateTime <ResetDateTime>b__4_0() { }

		internal DateTimeOffset <ResetDateTime>b__4_1() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public DateTime dateTimeNow; //Field offset: 0x8

		public <>c__DisplayClass1_0() { }

		internal DateTime <SetDateTime>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass3_0
	{
		public DateTimeOffset dateTimeOffset; //Field offset: 0x8

		public <>c__DisplayClass3_0() { }

		internal DateTimeOffset <SetDateTimeOffset>b__0() { }

	}

	public static Func<DateTime> Now; //Field offset: 0x0
	public static Func<DateTimeOffset> OffsetNow; //Field offset: 0x4

	private static SystemTime() { }

	public static void ResetDateTime() { }

	public static void SetDateTime(DateTime dateTimeNow) { }

	public static void SetDateTimeOffset(DateTimeOffset dateTimeOffset) { }

}

