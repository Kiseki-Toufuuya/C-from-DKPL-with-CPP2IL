namespace Newtonsoft.Json.Converters;

[Nullable(0)]
[NullableContext(2)]
internal class XProcessingInstructionWrapper : XObjectWrapper
{

	public virtual string LocalName
	{
		 get { } //Length: 30
	}

	[Nullable(1)]
	private XProcessingInstruction ProcessingInstruction
	{
		[NullableContext(1)]
		private get { } //Length: 101
	}

	public virtual string Value
	{
		 get { } //Length: 30
	}

	[NullableContext(1)]
	public XProcessingInstructionWrapper(XProcessingInstruction processingInstruction) { }

	public virtual string get_LocalName() { }

	[NullableContext(1)]
	private XProcessingInstruction get_ProcessingInstruction() { }

	public virtual string get_Value() { }

}

