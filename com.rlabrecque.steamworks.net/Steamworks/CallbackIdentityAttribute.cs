namespace Steamworks;

[AttributeUsage(AttributeTargets::Struct (8), AllowMultiple = False)]
internal class CallbackIdentityAttribute : Attribute
{
	[CompilerGenerated]
	private int <Identity>k__BackingField; //Field offset: 0x8

	public int Identity
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public CallbackIdentityAttribute(int callbackNum) { }

	[CompilerGenerated]
	public void set_Identity(int value) { }

}

