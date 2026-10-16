namespace System.Security;

[ComVisible(True)]
public sealed class SecurityElement
{
	public class SecurityAttribute
	{
		private string _name; //Field offset: 0x8
		private string _value; //Field offset: 0xC

		public string Name
		{
			 get { } //Length: 11
		}

		public string Value
		{
			 get { } //Length: 11
		}

		public SecurityAttribute(string name, string value) { }

		public string get_Name() { }

		public string get_Value() { }

	}

	private static readonly Char[] invalid_tag_chars; //Field offset: 0x0
	private static readonly Char[] invalid_text_chars; //Field offset: 0x4
	private static readonly Char[] invalid_attr_name_chars; //Field offset: 0x8
	private static readonly Char[] invalid_attr_value_chars; //Field offset: 0xC
	private static readonly Char[] invalid_chars; //Field offset: 0x10
	private string text; //Field offset: 0x8
	private string tag; //Field offset: 0xC
	private ArrayList attributes; //Field offset: 0x10
	private ArrayList children; //Field offset: 0x14

	public ArrayList Children
	{
		 get { } //Length: 11
	}

	internal string m_strText
	{
		internal set { } //Length: 27
	}

	public string Tag
	{
		 get { } //Length: 11
	}

	public string Text
	{
		 set { } //Length: 286
	}

	private static SecurityElement() { }

	public SecurityElement(string tag) { }

	public SecurityElement(string tag, string text) { }

	public void AddAttribute(string name, string value) { }

	public void AddChild(SecurityElement child) { }

	public static string Escape(string str) { }

	public ArrayList get_Children() { }

	public string get_Tag() { }

	internal SecurityAttribute GetAttribute(string name) { }

	public static bool IsValidAttributeName(string name) { }

	public static bool IsValidAttributeValue(string value) { }

	public static bool IsValidTag(string tag) { }

	public static bool IsValidText(string text) { }

	public SecurityElement SearchForChildByTag(string tag) { }

	internal string SearchForTextOfLocalName(string strLocalName) { }

	public string SearchForTextOfTag(string tag) { }

	internal void set_m_strText(string value) { }

	public void set_Text(string value) { }

	public virtual string ToString() { }

	private void ToXml(ref StringBuilder s, int level) { }

	private static string Unescape(string str) { }

}

