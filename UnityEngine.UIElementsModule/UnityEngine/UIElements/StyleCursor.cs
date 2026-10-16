namespace UnityEngine.UIElements;

public struct StyleCursor : IStyleValue<Cursor>, IEquatable<StyleCursor>
{
	private Cursor m_Value; //Field offset: 0x0
	private StyleKeyword m_Keyword; //Field offset: 0x10

	public override StyleKeyword keyword
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public override Cursor value
	{
		 get { } //Length: 34
		 set { } //Length: 35
	}

	public StyleCursor(StyleKeyword keyword) { }

	internal StyleCursor(Cursor v, StyleKeyword keyword) { }

	public override bool Equals(StyleCursor other) { }

	public virtual bool Equals(object obj) { }

	public override StyleKeyword get_keyword() { }

	public override Cursor get_value() { }

	public virtual int GetHashCode() { }

	public static bool op_Equality(StyleCursor lhs, StyleCursor rhs) { }

	public static StyleCursor op_Implicit(StyleKeyword keyword) { }

	public override void set_keyword(StyleKeyword value) { }

	public override void set_value(Cursor value) { }

	public virtual string ToString() { }

}

