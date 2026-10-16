namespace UnityEngine.Localization.SmartFormat.Utilities;

[Extension]
internal static class TimeSpanFormatOptionsConverter
{
	[CompilerGenerated]
	private sealed class <AllFlags>d__3 : IEnumerable<TimeSpanFormatOptions>, IEnumerable, IEnumerator<TimeSpanFormatOptions>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private TimeSpanFormatOptions <>2__current; //Field offset: 0xC
		private int <>l__initialThreadId; //Field offset: 0x10
		private TimeSpanFormatOptions timeSpanFormatOptions; //Field offset: 0x14
		public TimeSpanFormatOptions <>3__timeSpanFormatOptions; //Field offset: 0x18
		private uint <value>5__2; //Field offset: 0x1C

		private override TimeSpanFormatOptions System.Collections.Generic.IEnumerator<UnityEngine.Localization.SmartFormat.Utilities.TimeSpanFormatOptions>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 61
		}

		[DebuggerHidden]
		public <AllFlags>d__3(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override IEnumerator<TimeSpanFormatOptions> System.Collections.Generic.IEnumerable<UnityEngine.Localization.SmartFormat.Utilities.TimeSpanFormatOptions>.GetEnumerator() { }

		[DebuggerHidden]
		private override TimeSpanFormatOptions System.Collections.Generic.IEnumerator<UnityEngine.Localization.SmartFormat.Utilities.TimeSpanFormatOptions>.get_Current() { }

		[DebuggerHidden]
		private override IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private static readonly Regex parser; //Field offset: 0x0

	private static TimeSpanFormatOptionsConverter() { }

	[Extension]
	[IteratorStateMachine(typeof(<AllFlags>d__3))]
	public static IEnumerable<TimeSpanFormatOptions> AllFlags(TimeSpanFormatOptions timeSpanFormatOptions) { }

	[Extension]
	public static TimeSpanFormatOptions Mask(TimeSpanFormatOptions timeSpanFormatOptions, TimeSpanFormatOptions mask) { }

	[Extension]
	public static TimeSpanFormatOptions Merge(TimeSpanFormatOptions left, TimeSpanFormatOptions right) { }

	public static TimeSpanFormatOptions Parse(string formatOptionsString) { }

}

