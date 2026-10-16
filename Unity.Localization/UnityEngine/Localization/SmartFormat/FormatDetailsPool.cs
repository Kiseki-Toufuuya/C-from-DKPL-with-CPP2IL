namespace UnityEngine.Localization.SmartFormat;

internal static class FormatDetailsPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal FormatDetails <.cctor>b__4_0() { }

		internal void <.cctor>b__4_1(FormatDetails fd) { }

	}

	internal static readonly ObjectPool<FormatDetails> s_Pool; //Field offset: 0x0

	private static FormatDetailsPool() { }

	public static FormatDetails Get(SmartFormatter formatter, Format originalFormat, IList<Object> originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output) { }

	public static PooledObject<FormatDetails> Get(SmartFormatter formatter, Format originalFormat, Object[] originalArgs, FormatCache formatCache, IFormatProvider provider, IOutput output, out FormatDetails value) { }

	public static void Release(FormatDetails toRelease) { }

}

