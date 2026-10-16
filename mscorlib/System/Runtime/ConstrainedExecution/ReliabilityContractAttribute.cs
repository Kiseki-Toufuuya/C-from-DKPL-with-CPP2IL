namespace System.Runtime.ConstrainedExecution;

[AttributeUsage(1133, Inherited = False)]
public sealed class ReliabilityContractAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Consistency <ConsistencyGuarantee>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Cer <Cer>k__BackingField; //Field offset: 0xC

	public ReliabilityContractAttribute(Consistency consistencyGuarantee, Cer cer) { }

}

