namespace Google.Protobuf.Reflection;

[AttributeUsage(AttributeTargets::Field (256))]
public class OriginalNameAttribute : Attribute
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <PreferredAlias>k__BackingField; //Field offset: 0xC

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool PreferredAlias
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public OriginalNameAttribute(string name) { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public bool get_PreferredAlias() { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_PreferredAlias(bool value) { }

}

