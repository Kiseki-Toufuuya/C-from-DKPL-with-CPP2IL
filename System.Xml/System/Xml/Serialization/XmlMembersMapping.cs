namespace System.Xml.Serialization;

[DefaultMember("Item")]
public class XmlMembersMapping : XmlMapping
{
	private bool _hasWrapperElement; //Field offset: 0x24
	private XmlMemberMapping[] _mapping; //Field offset: 0x28

	public int Count
	{
		 get { } //Length: 23
	}

	internal bool HasWrapperElement
	{
		internal get { } //Length: 11
	}

	public int get_Count() { }

	internal bool get_HasWrapperElement() { }

}

