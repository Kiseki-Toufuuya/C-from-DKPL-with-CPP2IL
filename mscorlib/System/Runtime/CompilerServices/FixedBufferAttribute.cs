namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False)]
public sealed class FixedBufferAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Type <ElementType>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly int <Length>k__BackingField; //Field offset: 0xC

	public Type ElementType
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public int Length
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public FixedBufferAttribute(Type elementType, int length) { }

	[CompilerGenerated]
	public Type get_ElementType() { }

	[CompilerGenerated]
	public int get_Length() { }

}

