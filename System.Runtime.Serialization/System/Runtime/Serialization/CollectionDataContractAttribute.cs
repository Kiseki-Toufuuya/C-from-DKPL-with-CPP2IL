namespace System.Runtime.Serialization;

[AttributeUsage(12, Inherited = False, AllowMultiple = False)]
public sealed class CollectionDataContractAttribute : Attribute
{
	private string name; //Field offset: 0x8
	private string ns; //Field offset: 0xC
	private string itemName; //Field offset: 0x10
	private string keyName; //Field offset: 0x14
	private string valueName; //Field offset: 0x18
	private bool isReference; //Field offset: 0x1C
	private bool isNameSetExplicitly; //Field offset: 0x1D
	private bool isNamespaceSetExplicitly; //Field offset: 0x1E
	private bool isReferenceSetExplicitly; //Field offset: 0x1F
	private bool isItemNameSetExplicitly; //Field offset: 0x20
	private bool isKeyNameSetExplicitly; //Field offset: 0x21
	private bool isValueNameSetExplicitly; //Field offset: 0x22

	public bool IsItemNameSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsKeyNameSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsNameSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsNamespaceSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsReference
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public bool IsReferenceSetExplicitly
	{
		 get { } //Length: 11
	}

	public bool IsValueNameSetExplicitly
	{
		 get { } //Length: 11
	}

	public string ItemName
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public string KeyName
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public string Name
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public string Namespace
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public string ValueName
	{
		 get { } //Length: 11
		 set { } //Length: 33
	}

	public CollectionDataContractAttribute() { }

	public bool get_IsItemNameSetExplicitly() { }

	public bool get_IsKeyNameSetExplicitly() { }

	public bool get_IsNameSetExplicitly() { }

	public bool get_IsNamespaceSetExplicitly() { }

	public bool get_IsReference() { }

	public bool get_IsReferenceSetExplicitly() { }

	public bool get_IsValueNameSetExplicitly() { }

	public string get_ItemName() { }

	public string get_KeyName() { }

	public string get_Name() { }

	public string get_Namespace() { }

	public string get_ValueName() { }

	public void set_IsReference(bool value) { }

	public void set_ItemName(string value) { }

	public void set_KeyName(string value) { }

	public void set_Name(string value) { }

	public void set_Namespace(string value) { }

	public void set_ValueName(string value) { }

}

