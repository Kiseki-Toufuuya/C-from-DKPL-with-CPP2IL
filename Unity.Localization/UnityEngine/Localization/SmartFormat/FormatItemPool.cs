namespace UnityEngine.Localization.SmartFormat;

internal static class FormatItemPool
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0

		private static <>c() { }

		public <>c() { }

		internal LiteralText <.cctor>b__19_0() { }

		internal void <.cctor>b__19_1(LiteralText lt) { }

		internal Format <.cctor>b__19_2() { }

		internal void <.cctor>b__19_3(Format f) { }

		internal Placeholder <.cctor>b__19_4() { }

		internal void <.cctor>b__19_5(Placeholder p) { }

		internal Selector <.cctor>b__19_6() { }

		internal void <.cctor>b__19_7(Selector s) { }

	}

	internal static readonly ObjectPool<LiteralText> s_LiteralTextPool; //Field offset: 0x0
	internal static readonly ObjectPool<Format> s_FormatPool; //Field offset: 0x4
	internal static readonly ObjectPool<Placeholder> s_PlaceholderPool; //Field offset: 0x8
	internal static readonly ObjectPool<Selector> s_SelectorPool; //Field offset: 0xC

	private static FormatItemPool() { }

	public static Format GetFormat(SmartSettings smartSettings, string baseString) { }

	public static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex) { }

	public static Format GetFormat(SmartSettings smartSettings, string baseString, int startIndex, int endIndex, bool nested) { }

	public static Format GetFormat(SmartSettings smartSettings, Placeholder parent, int startIndex) { }

	public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex) { }

	public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, int startIndex, int endIndex) { }

	public static LiteralText GetLiteralText(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex) { }

	public static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth) { }

	public static Placeholder GetPlaceholder(SmartSettings smartSettings, Format parent, int startIndex, int nestedDepth, Format itemFormat, int endIndex) { }

	public static Selector GetSelector(SmartSettings smartSettings, FormatItem parent, string baseString, int startIndex, int endIndex, int operatorStart, int selectorIndex) { }

	public static void Release(FormatItem format) { }

	public static void ReleaseFormat(Format format) { }

	public static void ReleaseLiteralText(LiteralText literal) { }

	public static void ReleasePlaceholder(Placeholder placeholder) { }

	public static void ReleaseSelector(Selector selector) { }

}

