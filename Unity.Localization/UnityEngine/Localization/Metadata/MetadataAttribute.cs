namespace UnityEngine.Localization.Metadata;

[AttributeUsage(AttributeTargets::Class (4))]
public class MetadataAttribute : Attribute
{
	[CompilerGenerated]
	private string <MenuItem>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private bool <AllowMultiple>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private MetadataType <AllowedTypes>k__BackingField; //Field offset: 0x10

	public MetadataType AllowedTypes
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public bool AllowMultiple
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string MenuItem
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public MetadataAttribute() { }

	[CompilerGenerated]
	public MetadataType get_AllowedTypes() { }

	[CompilerGenerated]
	public bool get_AllowMultiple() { }

	[CompilerGenerated]
	public string get_MenuItem() { }

	[CompilerGenerated]
	public void set_AllowedTypes(MetadataType value) { }

	[CompilerGenerated]
	public void set_AllowMultiple(bool value) { }

	[CompilerGenerated]
	public void set_MenuItem(string value) { }

}

