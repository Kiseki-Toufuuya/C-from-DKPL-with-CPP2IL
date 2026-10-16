namespace System.Security;

[ComVisible(True)]
public sealed class NamedPermissionSet : PermissionSet
{
	private string name; //Field offset: 0x18
	private string description; //Field offset: 0x1C

	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 130
	}

	internal NamedPermissionSet() { }

	public NamedPermissionSet(string name, PermissionState state) { }

	public NamedPermissionSet(string name) { }

	[ComVisible(False)]
	public virtual bool Equals(object obj) { }

	public string get_Name() { }

	[ComVisible(False)]
	public virtual int GetHashCode() { }

	public void set_Name(string value) { }

	public virtual SecurityElement ToXml() { }

}

