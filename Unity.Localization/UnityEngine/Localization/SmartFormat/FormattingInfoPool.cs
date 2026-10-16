namespace UnityEngine.Localization.SmartFormat;

internal static class FormattingInfoPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal FormattingInfo <.cctor>b__5_0() { }

		internal void <.cctor>b__5_1(FormattingInfo fi) { }

	}

	internal static readonly ObjectPool<FormattingInfo> s_Pool; //Field offset: 0x0

	private static FormattingInfoPool() { }

	public static FormattingInfo Get(FormatDetails formatDetails, Format format, object currentValue) { }

	public static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Format format, object currentValue) { }

	public static FormattingInfo Get(FormattingInfo parent, FormatDetails formatDetails, Placeholder placeholder, object currentValue) { }

	public static void Release(FormattingInfo toRelease) { }

}

