namespace System.Runtime.Serialization.Configuration;

public sealed class ParameterElement : ConfigurationElement
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

	public ParameterElement() { }

	public ParameterElement(int index) { }

	public ParameterElement(string typeName) { }

	public int get_Index() { }

	public ParameterElementCollection get_Parameters() { }

	protected virtual ConfigurationPropertyCollection get_Properties() { }

	public string get_Type() { }

	protected virtual void PostDeserialize() { }

	protected virtual void PreSerialize(XmlWriter writer) { }

	public void set_Index(int value) { }

	public void set_Type(string value) { }

}

