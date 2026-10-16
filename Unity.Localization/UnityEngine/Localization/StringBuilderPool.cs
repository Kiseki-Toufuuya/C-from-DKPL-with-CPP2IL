namespace UnityEngine.Localization;

internal static class StringBuilderPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal StringBuilder <.cctor>b__4_0() { }

		internal void <.cctor>b__4_1(StringBuilder sb) { }

	}

	internal static readonly ObjectPool<StringBuilder> s_Pool; //Field offset: 0x0

	private static StringBuilderPool() { }

	public static StringBuilder Get() { }

	public static PooledObject<StringBuilder> Get(out StringBuilder value) { }

	public static void Release(StringBuilder toRelease) { }

}

