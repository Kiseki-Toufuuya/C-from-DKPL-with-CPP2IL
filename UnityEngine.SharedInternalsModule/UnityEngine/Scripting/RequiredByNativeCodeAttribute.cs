namespace UnityEngine.Scripting;

[AttributeUsage(1532, Inherited = False)]
[VisibleToOtherModules]
internal class RequiredByNativeCodeAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private string <Name>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <Optional>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <GenerateProxy>k__BackingField; //Field offset: 0xD

	public bool GenerateProxy
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string Name
	{
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public bool Optional
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public RequiredByNativeCodeAttribute() { }

	public RequiredByNativeCodeAttribute(string name) { }

	public RequiredByNativeCodeAttribute(bool optional) { }

	[CompilerGenerated]
	public void set_GenerateProxy(bool value) { }

	[CompilerGenerated]
	public void set_Name(string value) { }

	[CompilerGenerated]
	public void set_Optional(bool value) { }

}

