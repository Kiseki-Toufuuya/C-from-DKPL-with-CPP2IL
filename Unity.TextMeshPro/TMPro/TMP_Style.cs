namespace TMPro;

public class TMP_Style
{
	internal static TMP_Style k_NormalStyle; //Field offset: 0x0
	[SerializeField]
	private string m_Name; //Field offset: 0x8
	[SerializeField]
	private int m_HashCode; //Field offset: 0xC
	[SerializeField]
	private string m_OpeningDefinition; //Field offset: 0x10
	[SerializeField]
	private string m_ClosingDefinition; //Field offset: 0x14
	[SerializeField]
	private UInt32[] m_OpeningTagArray; //Field offset: 0x18
	[SerializeField]
	private UInt32[] m_ClosingTagArray; //Field offset: 0x1C

	public int hashCode
	{
		 get { } //Length: 11
		 set { } //Length: 19
	}

	public string name
	{
		 get { } //Length: 11
		 set { } //Length: 49
	}

	public static TMP_Style NormalStyle
	{
		 get { } //Length: 135
	}

	public string styleClosingDefinition
	{
		 get { } //Length: 11
	}

	public UInt32[] styleClosingTagArray
	{
		 get { } //Length: 11
	}

	public string styleOpeningDefinition
	{
		 get { } //Length: 11
	}

	public UInt32[] styleOpeningTagArray
	{
		 get { } //Length: 11
	}

	internal TMP_Style(string styleName, string styleOpeningDefinition, string styleClosingDefinition) { }

	public int get_hashCode() { }

	public string get_name() { }

	public static TMP_Style get_NormalStyle() { }

	public string get_styleClosingDefinition() { }

	public UInt32[] get_styleClosingTagArray() { }

	public string get_styleOpeningDefinition() { }

	public UInt32[] get_styleOpeningTagArray() { }

	public void RefreshStyle() { }

	public void set_hashCode(int value) { }

	public void set_name(string value) { }

}

