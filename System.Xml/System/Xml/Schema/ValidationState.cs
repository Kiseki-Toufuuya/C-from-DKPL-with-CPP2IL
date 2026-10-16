namespace System.Xml.Schema;

internal sealed class ValidationState
{
	public bool IsNill; //Field offset: 0x8
	public bool IsDefault; //Field offset: 0x9
	public bool NeedValidateChildren; //Field offset: 0xA
	public bool CheckRequiredAttribute; //Field offset: 0xB
	public bool ValidationSkipped; //Field offset: 0xC
	public XmlSchemaContentProcessing ProcessContents; //Field offset: 0x10
	public XmlSchemaValidity Validity; //Field offset: 0x14
	public SchemaElementDecl ElementDecl; //Field offset: 0x18
	public SchemaElementDecl ElementDeclBeforeXsi; //Field offset: 0x1C
	public string LocalName; //Field offset: 0x20
	public string Namespace; //Field offset: 0x24
	public ConstraintStruct[] Constr; //Field offset: 0x28
	public StateUnion CurrentState; //Field offset: 0x2C
	public bool HasMatched; //Field offset: 0x30
	public BitSet[] CurPos; //Field offset: 0x34
	public BitSet AllElementsSet; //Field offset: 0x38
	public List<RangePositionInfo> RunningPositions; //Field offset: 0x3C
	public bool TooComplex; //Field offset: 0x40

	public ValidationState() { }

}

