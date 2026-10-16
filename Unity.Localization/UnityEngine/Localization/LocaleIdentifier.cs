namespace UnityEngine.Localization;

public struct LocaleIdentifier : IEquatable<LocaleIdentifier>, IComparable<LocaleIdentifier>
{
	[SerializeField]
	private string m_Code; //Field offset: 0x0
	private CultureInfo m_CultureInfo; //Field offset: 0x4

	public string Code
	{
		 get { } //Length: 10
	}

	public CultureInfo CultureInfo
	{
		 get { } //Length: 242
	}

	public LocaleIdentifier(string code) { }

	public LocaleIdentifier(CultureInfo culture) { }

	public LocaleIdentifier(SystemLanguage systemLanguage) { }

	public override int CompareTo(LocaleIdentifier other) { }

	public virtual bool Equals(object obj) { }

	public override bool Equals(LocaleIdentifier other) { }

	public string get_Code() { }

	public CultureInfo get_CultureInfo() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(LocaleIdentifier l1, LocaleIdentifier l2) { }

	public static LocaleIdentifier op_Implicit(string code) { }

	public static LocaleIdentifier op_Implicit(CultureInfo culture) { }

	public static LocaleIdentifier op_Implicit(SystemLanguage systemLanguage) { }

	public static bool op_Inequality(LocaleIdentifier l1, LocaleIdentifier l2) { }

	public virtual string ToString() { }

}

