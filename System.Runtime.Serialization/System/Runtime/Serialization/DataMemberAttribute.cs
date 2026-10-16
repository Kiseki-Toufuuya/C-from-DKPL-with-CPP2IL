namespace System.Runtime.Serialization;

[AttributeUsage(384, Inherited = False, AllowMultiple = False)]
public sealed class DataMemberAttribute : Attribute
{
	private string name; //Field offset: 0x8
	private bool isNameSetExplicitly; //Field offset: 0xC
	private int order; //Field offset: 0x10
	private bool isRequired; //Field offset: 0x14
	private bool emitDefaultValue; //Field offset: 0x15

	public bool EmitDefaultValue
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public bool IsNameSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsRequired
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public int Order
	{
		 get { } //Length: 11
		 set { } //Length: 102
	}

	public DataMemberAttribute() { }

	public bool get_EmitDefaultValue() { }

	public bool get_IsNameSetExplicitly() { }

	public bool get_IsRequired() { }

	public string get_Name() { }

	public int get_Order() { }

	public void set_EmitDefaultValue(bool value) { }

	public void set_IsRequired(bool value) { }

	public void set_Name(string value) { }

	public void set_Order(int value) { }

}

