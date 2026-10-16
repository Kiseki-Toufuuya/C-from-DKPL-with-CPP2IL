namespace System.Runtime.Serialization;

public sealed class ExtensionDataObject
{
	private IList<ExtensionDataMember> members; //Field offset: 0x8

	internal IList<ExtensionDataMember> Members
	{
		internal get { } //Length: 11
		internal set { } //Length: 27
	}

	internal ExtensionDataObject() { }

	internal IList<ExtensionDataMember> get_Members() { }

	internal void set_Members(IList<ExtensionDataMember> value) { }

}

