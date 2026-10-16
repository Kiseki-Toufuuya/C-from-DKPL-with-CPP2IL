namespace LitJson;

internal struct ObjectMetadata
{
	private Type element_type; //Field offset: 0x0
	private bool is_dictionary; //Field offset: 0x4
	private IDictionary<String, PropertyMetadata> properties; //Field offset: 0x8

	public Type ElementType
	{
		 get { } //Length: 123
		 set { } //Length: 23
	}

	public bool IsDictionary
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public IDictionary<String, PropertyMetadata> Properties
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public Type get_ElementType() { }

	public bool get_IsDictionary() { }

	public IDictionary<String, PropertyMetadata> get_Properties() { }

	public void set_ElementType(Type value) { }

	public void set_IsDictionary(bool value) { }

	public void set_Properties(IDictionary<String, PropertyMetadata> value) { }

}

