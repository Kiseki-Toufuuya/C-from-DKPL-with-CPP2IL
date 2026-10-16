namespace UnityEngine.Localization.SmartFormat;

internal static class FormatCachePool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal FormatCache <.cctor>b__4_0() { }

		internal void <.cctor>b__4_1(FormatCache fc) { }

	}

	internal static readonly ObjectPool<FormatCache> s_Pool; //Field offset: 0x0

	private static FormatCachePool() { }

	public static FormatCache Get(Format format) { }

	public static PooledObject<FormatCache> Get(Format format, out FormatCache value) { }

	public static void Release(FormatCache toRelease) { }

}

