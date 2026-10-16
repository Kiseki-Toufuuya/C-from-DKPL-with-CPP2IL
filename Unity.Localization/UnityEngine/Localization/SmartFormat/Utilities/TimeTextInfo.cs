namespace UnityEngine.Localization.SmartFormat.Utilities;

public class TimeTextInfo
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static PluralRuleDelegate <>9__15_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal int <.ctor>b__15_0(decimal d, int c) { }

	}

	private readonly String[] d; //Field offset: 0x8
	private readonly String[] day; //Field offset: 0xC
	private readonly String[] h; //Field offset: 0x10
	private readonly String[] hour; //Field offset: 0x14
	private readonly string lessThan; //Field offset: 0x18
	private readonly String[] m; //Field offset: 0x1C
	private readonly String[] millisecond; //Field offset: 0x20
	private readonly String[] minute; //Field offset: 0x24
	private readonly String[] ms; //Field offset: 0x28
	private readonly PluralRuleDelegate PluralRule; //Field offset: 0x2C
	private readonly String[] s; //Field offset: 0x30
	private readonly String[] second; //Field offset: 0x34
	private readonly String[] w; //Field offset: 0x38
	private readonly String[] week; //Field offset: 0x3C

	public TimeTextInfo(PluralRuleDelegate pluralRule, String[] week, String[] day, String[] hour, String[] minute, String[] second, String[] millisecond, String[] w, String[] d, String[] h, String[] m, String[] s, String[] ms, string lessThan) { }

	public TimeTextInfo(string week, string day, string hour, string minute, string second, string millisecond, string lessThan) { }

	public string GetLessThanText(string minimumValue) { }

	public override string GetUnitText(TimeSpanFormatOptions unit, int value, bool abbr) { }

	private static string GetValue(PluralRuleDelegate pluralRule, int value, String[] units) { }

}

