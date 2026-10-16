namespace UnityEngine.Bindings;

[AttributeUsage(192)]
[VisibleToOtherModules]
internal class NativeThrowsAttribute : Attribute
{
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private bool <ThrowsException>k__BackingField; //Field offset: 0x8

	public override bool ThrowsException
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public NativeThrowsAttribute() { }

	[CompilerGenerated]
	public override void set_ThrowsException(bool value) { }

}

