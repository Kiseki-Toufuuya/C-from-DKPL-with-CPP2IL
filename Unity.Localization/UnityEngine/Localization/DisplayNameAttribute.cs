namespace UnityEngine.Localization;

[AttributeUsage(AttributeTargets::All (32767), AllowMultiple = False)]
public class DisplayNameAttribute : Attribute
{
	[CompilerGenerated]
	private string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <IconPath>k__BackingField; //Field offset: 0xC

	public string IconPath
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string Name
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public DisplayNameAttribute(string name, string iconPath = null) { }

	[CompilerGenerated]
	public string get_IconPath() { }

	[CompilerGenerated]
	public string get_Name() { }

	[CompilerGenerated]
	public void set_IconPath(string value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

}

