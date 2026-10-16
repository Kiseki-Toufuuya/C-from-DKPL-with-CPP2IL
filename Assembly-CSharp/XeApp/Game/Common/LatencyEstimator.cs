namespace XeApp.Game.Common;

public static class LatencyEstimator
{
	[CompilerGenerated]
	private sealed class <CheckLatency>d__4 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public bool force; //Field offset: 0x10

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <CheckLatency>d__4(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	private const int ApproximateNotesLatency = 50; //Field offset: 0x0
	public static int Latency; //Field offset: 0x0
	public static bool IsInit; //Field offset: 0x4
	public static EstimatorInfo EstimatorInfo; //Field offset: 0x8

	private static LatencyEstimator() { }

	[IteratorStateMachine(typeof(<CheckLatency>d__4))]
	public static IEnumerator CheckLatency(bool force) { }

}

