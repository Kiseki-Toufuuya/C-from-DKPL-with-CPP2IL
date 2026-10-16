namespace UnityEngine.Localization.SmartFormat.Utilities;

[Extension]
public static class PluralRules
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static PluralRuleDelegate <>9__2_0; //Field offset: 0x4
		public static PluralRuleDelegate <>9__4_0; //Field offset: 0x8
		public static PluralRuleDelegate <>9__6_0; //Field offset: 0xC
		public static PluralRuleDelegate <>9__8_0; //Field offset: 0x10
		public static PluralRuleDelegate <>9__10_0; //Field offset: 0x14
		public static PluralRuleDelegate <>9__12_0; //Field offset: 0x18
		public static PluralRuleDelegate <>9__14_0; //Field offset: 0x1C
		public static PluralRuleDelegate <>9__16_0; //Field offset: 0x20
		public static PluralRuleDelegate <>9__18_0; //Field offset: 0x24
		public static PluralRuleDelegate <>9__20_0; //Field offset: 0x28
		public static PluralRuleDelegate <>9__22_0; //Field offset: 0x2C
		public static PluralRuleDelegate <>9__24_0; //Field offset: 0x30
		public static PluralRuleDelegate <>9__26_0; //Field offset: 0x34
		public static PluralRuleDelegate <>9__28_0; //Field offset: 0x38
		public static PluralRuleDelegate <>9__30_0; //Field offset: 0x3C
		public static PluralRuleDelegate <>9__32_0; //Field offset: 0x40
		public static PluralRuleDelegate <>9__34_0; //Field offset: 0x44
		public static PluralRuleDelegate <>9__36_0; //Field offset: 0x48
		public static PluralRuleDelegate <>9__38_0; //Field offset: 0x4C
		public static PluralRuleDelegate <>9__40_0; //Field offset: 0x50
		public static PluralRuleDelegate <>9__42_0; //Field offset: 0x54
		public static PluralRuleDelegate <>9__44_0; //Field offset: 0x58
		public static PluralRuleDelegate <>9__46_0; //Field offset: 0x5C

		private static <>c() { }

		public <>c() { }

		internal int <get_Arabic>b__14_0(decimal n, int c) { }

		internal int <get_Breton>b__16_0(decimal n, int c) { }

		internal int <get_CentralMoroccoTamazight>b__46_0(decimal n, int c) { }

		internal int <get_Czech>b__18_0(decimal n, int c) { }

		internal int <get_DualFromZeroToTwo>b__8_0(decimal n, int c) { }

		internal int <get_DualOneOther>b__4_0(decimal n, int c) { }

		internal int <get_DualWithZero>b__6_0(decimal n, int c) { }

		internal int <get_Langi>b__24_0(decimal n, int c) { }

		internal int <get_Latvian>b__28_0(decimal n, int c) { }

		internal int <get_Lithuanian>b__26_0(decimal n, int c) { }

		internal int <get_Macedonian>b__30_0(decimal n, int c) { }

		internal int <get_Maltese>b__34_0(decimal n, int c) { }

		internal int <get_Manx>b__22_0(decimal n, int c) { }

		internal int <get_Moldavian>b__32_0(decimal n, int c) { }

		internal int <get_Polish>b__36_0(decimal n, int c) { }

		internal int <get_Romanian>b__38_0(decimal n, int c) { }

		internal int <get_RussianSerboCroatian>b__12_0(decimal n, int c) { }

		internal int <get_Singular>b__2_0(decimal n, int c) { }

		internal int <get_Slovak>b__42_0(decimal n, int c) { }

		internal int <get_Slovenian>b__44_0(decimal n, int c) { }

		internal int <get_Tachelhit>b__40_0(decimal n, int c) { }

		internal int <get_TripleOneTwoOther>b__10_0(decimal n, int c) { }

		internal int <get_Welsh>b__20_0(decimal n, int c) { }

	}

	internal sealed class PluralRuleDelegate : MulticastDelegate
	{

		public PluralRuleDelegate(object object, IntPtr method) { }

		public override IAsyncResult BeginInvoke(decimal value, int pluralCount, AsyncCallback callback, object object) { }

		public override int EndInvoke(IAsyncResult result) { }

		public override int Invoke(decimal value, int pluralCount) { }

	}

	public static readonly Dictionary<String, PluralRuleDelegate> IsoLangToDelegate; //Field offset: 0x0

	private static PluralRuleDelegate Arabic
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Breton
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate CentralMoroccoTamazight
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Czech
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate DualFromZeroToTwo
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate DualOneOther
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate DualWithZero
	{
		private get { } //Length: 292
	}

	private static PluralRuleDelegate Langi
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Latvian
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Lithuanian
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Macedonian
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Maltese
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Manx
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Moldavian
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Polish
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Romanian
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate RussianSerboCroatian
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Singular
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Slovak
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Slovenian
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Tachelhit
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate TripleOneTwoOther
	{
		private get { } //Length: 293
	}

	private static PluralRuleDelegate Welsh
	{
		private get { } //Length: 293
	}

	private static PluralRules() { }

	[Extension]
	private static bool Between(decimal value, decimal min, decimal max) { }

	private static PluralRuleDelegate get_Arabic() { }

	private static PluralRuleDelegate get_Breton() { }

	private static PluralRuleDelegate get_CentralMoroccoTamazight() { }

	private static PluralRuleDelegate get_Czech() { }

	private static PluralRuleDelegate get_DualFromZeroToTwo() { }

	private static PluralRuleDelegate get_DualOneOther() { }

	private static PluralRuleDelegate get_DualWithZero() { }

	private static PluralRuleDelegate get_Langi() { }

	private static PluralRuleDelegate get_Latvian() { }

	private static PluralRuleDelegate get_Lithuanian() { }

	private static PluralRuleDelegate get_Macedonian() { }

	private static PluralRuleDelegate get_Maltese() { }

	private static PluralRuleDelegate get_Manx() { }

	private static PluralRuleDelegate get_Moldavian() { }

	private static PluralRuleDelegate get_Polish() { }

	private static PluralRuleDelegate get_Romanian() { }

	private static PluralRuleDelegate get_RussianSerboCroatian() { }

	private static PluralRuleDelegate get_Singular() { }

	private static PluralRuleDelegate get_Slovak() { }

	private static PluralRuleDelegate get_Slovenian() { }

	private static PluralRuleDelegate get_Tachelhit() { }

	private static PluralRuleDelegate get_TripleOneTwoOther() { }

	private static PluralRuleDelegate get_Welsh() { }

	public static PluralRuleDelegate GetPluralRule(string twoLetterIsoLanguageName) { }

}

