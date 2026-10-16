namespace UnityEngine.Localization.SmartFormat;

internal static class ParsingErrorsPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal ParsingErrors <.cctor>b__3_0() { }

		internal void <.cctor>b__3_1(ParsingErrors pe) { }

	}

	internal static readonly ObjectPool<ParsingErrors> s_Pool; //Field offset: 0x0

	private static ParsingErrorsPool() { }

	public static ParsingErrors Get(Format format) { }

	public static void Release(ParsingErrors toRelease) { }

}

