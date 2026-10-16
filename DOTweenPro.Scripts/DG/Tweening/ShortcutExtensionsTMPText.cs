namespace DG.Tweening;

[Extension]
public static class ShortcutExtensionsTMPText
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass0_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass0_0() { }

		internal Color <DOColor>b__0() { }

		internal void <DOColor>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass1_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass1_0() { }

		internal Color <DOFaceColor>b__0() { }

		internal void <DOFaceColor>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass10_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass10_0() { }

		internal string <DOText>b__0() { }

		internal void <DOText>b__1(string x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass2_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass2_0() { }

		internal Color <DOOutlineColor>b__0() { }

		internal void <DOOutlineColor>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass4_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass4_0() { }

		internal Color <DOFade>b__0() { }

		internal void <DOFade>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass5_0() { }

		internal Color <DOFaceFade>b__0() { }

		internal void <DOFaceFade>b__1(Color x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass6_0
	{
		public Transform trans; //Field offset: 0x8

		public <>c__DisplayClass6_0() { }

		internal Vector3 <DOScale>b__0() { }

		internal void <DOScale>b__1(Vector3 x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass7_0
	{
		public int v; //Field offset: 0x8
		public TMP_Text target; //Field offset: 0xC
		public bool addThousandsSeparator; //Field offset: 0x10
		public CultureInfo cInfo; //Field offset: 0x14

		public <>c__DisplayClass7_0() { }

		internal int <DOCounter>b__0() { }

		internal void <DOCounter>b__1(int x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass8_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass8_0() { }

		internal float <DOFontSize>b__0() { }

		internal void <DOFontSize>b__1(float x) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass9_0
	{
		public TMP_Text target; //Field offset: 0x8

		public <>c__DisplayClass9_0() { }

		internal int <DOMaxVisibleCharacters>b__0() { }

		internal void <DOMaxVisibleCharacters>b__1(int x) { }

	}


	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOColor(TMP_Text target, Color endValue, float duration) { }

	[Extension]
	public static TweenerCore<Int32, Int32, NoOptions> DOCounter(TMP_Text target, int fromValue, int endValue, float duration, bool addThousandsSeparator = true, CultureInfo culture = null) { }

	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOFaceColor(TMP_Text target, Color32 endValue, float duration) { }

	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOFaceFade(TMP_Text target, float endValue, float duration) { }

	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOFade(TMP_Text target, float endValue, float duration) { }

	[Extension]
	public static TweenerCore<Single, Single, FloatOptions> DOFontSize(TMP_Text target, float endValue, float duration) { }

	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOGlowColor(TMP_Text target, Color endValue, float duration, bool useSharedMaterial = false) { }

	[Extension]
	public static TweenerCore<Int32, Int32, NoOptions> DOMaxVisibleCharacters(TMP_Text target, int endValue, float duration) { }

	[Extension]
	public static TweenerCore<Color, Color, ColorOptions> DOOutlineColor(TMP_Text target, Color32 endValue, float duration) { }

	[Extension]
	public static TweenerCore<Vector3, Vector3, VectorOptions> DOScale(TMP_Text target, float endValue, float duration) { }

	[Extension]
	public static TweenerCore<String, String, StringOptions> DOText(TMP_Text target, string endValue, float duration, bool richTextEnabled = true, ScrambleMode scrambleMode = 0, string scrambleChars = null) { }

}

