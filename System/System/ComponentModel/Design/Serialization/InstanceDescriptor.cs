namespace System.ComponentModel.Design.Serialization;

public sealed class InstanceDescriptor
{
	[CompilerGenerated]
	private readonly ICollection <Arguments>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly bool <IsComplete>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private readonly MemberInfo <MemberInfo>k__BackingField; //Field offset: 0x10

	public ICollection Arguments
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public MemberInfo MemberInfo
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public InstanceDescriptor(MemberInfo member, ICollection arguments) { }

	public InstanceDescriptor(MemberInfo member, ICollection arguments, bool isComplete) { }

	[CompilerGenerated]
	public ICollection get_Arguments() { }

	[CompilerGenerated]
	public MemberInfo get_MemberInfo() { }

	public object Invoke() { }

}

