namespace System.Runtime.Serialization.Configuration;

public sealed class DeclaredTypeElement : ConfigurationElement
{

	public TypeElementCollection KnownTypes
	{
		 get { } //Length: 40
	}

	protected virtual ConfigurationPropertyCollection Properties
	{
		 get { } //Length: 40
	}

	public string Type
	{
		 get { } //Length: 40
		 set { } //Length: 40
	}

	public DeclaredTypeElement() { }

	public DeclaredTypeElement(string typeName) { }

	public TypeElementCollection get_KnownTypes() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	public string get_Type() { }

	protected virtual void PostDeserialize() { }

	public void set_Type(string value) { }

}

