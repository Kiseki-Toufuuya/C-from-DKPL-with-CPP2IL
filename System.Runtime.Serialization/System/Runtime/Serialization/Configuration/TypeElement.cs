namespace System.Runtime.Serialization.Configuration;

public sealed class TypeElement : ConfigurationElement
{

	public int Index
	{
		 get { } //Length: 40
		 set { } //Length: 40
	}

	public ParameterElementCollection Parameters
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

	public TypeElement() { }

	public TypeElement(string typeName) { }

	public int get_Index() { }

	public ParameterElementCollection get_Parameters() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	public string get_Type() { }

	protected virtual void Reset(ConfigurationElement parentElement) { }

	public void set_Index(int value) { }

	public void set_Type(string value) { }

}

