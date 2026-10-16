namespace UnityEngine.Localization.SmartFormat;

internal static class StringOutputPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal StringOutput <.cctor>b__4_0() { }

		internal void <.cctor>b__4_1(StringOutput so) { }

	}

	internal static readonly ObjectPool<StringOutput> s_Pool; //Field offset: 0x0

	private static StringOutputPool() { }

	public static StringOutput Get(int capacity) { }

	public static PooledObject<StringOutput> Get(int capacity, out StringOutput value) { }

	public static void Release(StringOutput toRelease) { }

}

