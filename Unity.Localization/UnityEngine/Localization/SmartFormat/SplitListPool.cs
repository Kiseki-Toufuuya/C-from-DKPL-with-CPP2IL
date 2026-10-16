namespace UnityEngine.Localization.SmartFormat;

internal static class SplitListPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal SplitList <.cctor>b__3_0() { }

		internal void <.cctor>b__3_1(SplitList sl) { }

	}

	internal static readonly ObjectPool<SplitList> s_Pool; //Field offset: 0x0

	private static SplitListPool() { }

	public static SplitList Get(Format format, List<Int32> splits) { }

	public static void Release(SplitList toRelease) { }

}

