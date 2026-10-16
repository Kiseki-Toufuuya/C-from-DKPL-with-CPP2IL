namespace System.ComponentModel;

[AttributeUsage(AttributeTargets::All (32767))]
public class ToolboxItemAttribute : Attribute
{
	public static readonly ToolboxItemAttribute Default; //Field offset: 0x0
	public static readonly ToolboxItemAttribute None; //Field offset: 0x4
	private string _toolboxItemTypeName; //Field offset: 0x8

	public string ToolboxItemTypeName
	{
		 get { } //Length: 29
	}

	private static ToolboxItemAttribute() { }

	public ToolboxItemAttribute(bool defaultType) { }

	public ToolboxItemAttribute(string toolboxItemTypeName) { }

	public virtual bool Equals(object obj) { }

	public string get_ToolboxItemTypeName() { }

	public virtual int GetHashCode() { }

	public virtual bool IsDefaultAttribute() { }

}

