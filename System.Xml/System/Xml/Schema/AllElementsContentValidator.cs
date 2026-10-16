namespace System.Xml.Schema;

internal sealed class AllElementsContentValidator : ContentValidator
{
	private Hashtable elements; //Field offset: 0x10
	private Object[] particles; //Field offset: 0x14
	private BitSet isRequired; //Field offset: 0x18
	private int countRequired; //Field offset: 0x1C

	public virtual bool IsEmptiable
	{
		 get { } //Length: 25
	}

	public AllElementsContentValidator(XmlSchemaContentType contentType, int size, bool isEmptiable) { }

	public bool AddElement(XmlQualifiedName name, object particle, bool isEmptiable) { }

	public virtual bool CompleteValidation(ValidationState context) { }

	public virtual ArrayList ExpectedElements(ValidationState context, bool isRequiredOnly) { }

	public virtual ArrayList ExpectedParticles(ValidationState context, bool isRequiredOnly, XmlSchemaSet schemaSet) { }

	public virtual bool get_IsEmptiable() { }

	public virtual void InitValidation(ValidationState context) { }

	public virtual object ValidateElement(XmlQualifiedName name, ValidationState context, out int errorCode) { }

}

