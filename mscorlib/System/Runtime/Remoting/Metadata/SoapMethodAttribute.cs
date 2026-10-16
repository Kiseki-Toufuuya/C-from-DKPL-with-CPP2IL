namespace System.Runtime.Remoting.Metadata;

[AttributeUsage(AttributeTargets::Method (64))]
[ComVisible(True)]
public sealed class SoapMethodAttribute : SoapAttribute
{
	private string _responseElement; //Field offset: 0x14
	private string _responseNamespace; //Field offset: 0x18
	private string _returnElement; //Field offset: 0x1C
	private string _soapAction; //Field offset: 0x20
	private bool _useAttribute; //Field offset: 0x24
	private string _namespace; //Field offset: 0x28

	public virtual bool UseAttribute
	{
		 get { } //Length: 11
	}

	public virtual string XmlNamespace
	{
		 get { } //Length: 11
	}

	public SoapMethodAttribute() { }

	public virtual bool get_UseAttribute() { }

	public virtual string get_XmlNamespace() { }

	internal virtual void SetReflectionObject(object reflectionObject) { }

}

