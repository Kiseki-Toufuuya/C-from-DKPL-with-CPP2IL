namespace System.Xml.Xsl.Runtime;

[EditorBrowsable(EditorBrowsableState::Never (1))]
public struct StringConcat
{
	private string s1; //Field offset: 0x0
	private string s2; //Field offset: 0x4
	private string s3; //Field offset: 0x8
	private string s4; //Field offset: 0xC
	private string delimiter; //Field offset: 0x10
	private List<String> strList; //Field offset: 0x14
	private int idxStr; //Field offset: 0x18

	internal int Count
	{
		internal get { } //Length: 11
	}

	public void Clear() { }

	internal void ConcatNoDelimiter(string s) { }

	internal int get_Count() { }

	public string GetResult() { }

}

