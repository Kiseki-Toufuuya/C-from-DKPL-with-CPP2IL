namespace System.Runtime.Remoting.Metadata;

[ComVisible(True)]
public class SoapAttribute : Attribute
{
	private bool _useAttribute; //Field offset: 0x8
	protected string ProtXmlNamespace; //Field offset: 0xC
	protected object ReflectInfo; //Field offset: 0x10

	public override bool UseAttribute
	{
		 get { } //Length: 11
	}

	public override string XmlNamespace
	{
		 get { } //Length: 11
	}

	public SoapAttribute() { }

	public override bool get_UseAttribute() { }

	public override string get_XmlNamespace() { }

	internal override void SetReflectionObject(object reflectionObject) { }

}

