namespace System.Xml.Schema;

internal class RestrictionFacets
{
	internal int Length; //Field offset: 0x8
	internal int MinLength; //Field offset: 0xC
	internal int MaxLength; //Field offset: 0x10
	internal ArrayList Patterns; //Field offset: 0x14
	internal ArrayList Enumeration; //Field offset: 0x18
	internal XmlSchemaWhiteSpace WhiteSpace; //Field offset: 0x1C
	internal object MaxInclusive; //Field offset: 0x20
	internal object MaxExclusive; //Field offset: 0x24
	internal object MinInclusive; //Field offset: 0x28
	internal object MinExclusive; //Field offset: 0x2C
	internal int TotalDigits; //Field offset: 0x30
	internal int FractionDigits; //Field offset: 0x34
	internal RestrictionFlags Flags; //Field offset: 0x38
	internal RestrictionFlags FixedFlags; //Field offset: 0x3C

	public RestrictionFacets() { }

}

