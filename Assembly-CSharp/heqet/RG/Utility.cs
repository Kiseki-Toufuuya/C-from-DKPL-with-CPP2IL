namespace Heqet.RG;

public static class Utility
{
	[CompilerGenerated]
	private sealed class <DelayMethod>d__6 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float waitTime; //Field offset: 0x10
		public Action action; //Field offset: 0x14

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
		public <DelayMethod>d__6(int <>1__state) { }

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


	public static void CreateDirectory(string path) { }

	[IteratorStateMachine(typeof(<DelayMethod>d__6))]
	private static IEnumerator DelayMethod(float waitTime, Action action) { }

	public static void DeleteDirectory(string path) { }

	public static void DirectoryCopy(string sourceDirName, string destDirName, bool overwrite) { }

	public static string GetGameObjectPath(GameObject obj, bool includeSceneName = true) { }

	public static string GetPathNormalization(string path) { }

	public static string GetPathWithoutExtension(string path) { }

	public static MusicScoreDefine ToKaguraMusicScoreDefine(int musicDifficulty, LaneMode laneMode) { }

	public static LaneMode ToLaneMode(MusicScoreDefine musicScoreDefine) { }

	public static MusicDifficulty ToMusicDifficulty(MusicScoreDefine musicScoreDefine) { }

}

