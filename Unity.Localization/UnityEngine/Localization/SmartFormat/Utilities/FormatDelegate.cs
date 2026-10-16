namespace UnityEngine.Localization.SmartFormat.Utilities;

public class FormatDelegate : IFormattable
{
	private readonly Func<String, String> getFormat1; //Field offset: 0x8
	private readonly Func<String, IFormatProvider, String> getFormat2; //Field offset: 0xC

	public FormatDelegate(Func<String, String> getFormat) { }

	public FormatDelegate(Func<String, IFormatProvider, String> getFormat) { }

	public override string ToString(string format, IFormatProvider formatProvider) { }

}

