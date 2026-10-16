namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
[ComVisible(True)]
public sealed class OptionalFieldAttribute : Attribute
{
	private int versionAdded; //Field offset: 0x8

	public int VersionAdded
	{
		 set { } //Length: 93
	}

	public OptionalFieldAttribute() { }

	public void set_VersionAdded(int value) { }

}

