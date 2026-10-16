namespace System.Runtime.Serialization;

[AttributeUsage(AttributeTargets::Field (256), Inherited = False, AllowMultiple = False)]
public sealed class EnumMemberAttribute : Attribute
{
	private string value; //Field offset: 0x8
	private bool isValueSetExplicitly; //Field offset: 0xC

	public bool IsValueSetExplicitly
	{
		 get { } //Length: 11
	}

	public string Value
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public EnumMemberAttribute() { }

	public bool get_IsValueSetExplicitly() { }

	public string get_Value() { }

	public void set_Value(string value) { }

}

