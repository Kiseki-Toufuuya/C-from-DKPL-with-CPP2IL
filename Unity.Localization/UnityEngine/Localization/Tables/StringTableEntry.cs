namespace UnityEngine.Localization.Tables;

public class StringTableEntry : TableEntry
{
	private FormatCache m_FormatCache; //Field offset: 0x14

	public FormatCache FormatCache
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public bool IsSmart
	{
		 get { } //Length: 112
		 set { } //Length: 159
	}

	public string Value
	{
		 get { } //Length: 23
		 set { } //Length: 130
	}

	internal StringTableEntry() { }

	public FormatCache get_FormatCache() { }

	public bool get_IsSmart() { }

	public string get_Value() { }

	public string GetLocalizedString() { }

	public string GetLocalizedString(Object[] args) { }

	public string GetLocalizedString(IList<Object> args) { }

	public string GetLocalizedString(IFormatProvider formatProvider, IList<Object> args) { }

	public string GetLocalizedString(IFormatProvider formatProvider, IList<Object> args, PseudoLocale pseudoLocale) { }

	internal FormatCache GetOrCreateFormatCache() { }

	public void RemoveFromTable() { }

	public void set_FormatCache(FormatCache value) { }

	public void set_IsSmart(bool value) { }

	public void set_Value(string value) { }

}

