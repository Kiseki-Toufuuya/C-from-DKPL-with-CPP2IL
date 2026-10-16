namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ParseRecord
{
	internal static int parseRecordIdCount; //Field offset: 0x0
	internal InternalParseTypeE PRparseTypeEnum; //Field offset: 0x8
	internal InternalObjectTypeE PRobjectTypeEnum; //Field offset: 0xC
	internal InternalArrayTypeE PRarrayTypeEnum; //Field offset: 0x10
	internal InternalMemberTypeE PRmemberTypeEnum; //Field offset: 0x14
	internal InternalMemberValueE PRmemberValueEnum; //Field offset: 0x18
	internal InternalObjectPositionE PRobjectPositionEnum; //Field offset: 0x1C
	internal string PRname; //Field offset: 0x20
	internal string PRvalue; //Field offset: 0x24
	internal object PRvarValue; //Field offset: 0x28
	internal string PRkeyDt; //Field offset: 0x2C
	internal Type PRdtType; //Field offset: 0x30
	internal InternalPrimitiveTypeE PRdtTypeCode; //Field offset: 0x34
	internal bool PRisEnum; //Field offset: 0x38
	internal long PRobjectId; //Field offset: 0x40
	internal long PRidRef; //Field offset: 0x48
	internal string PRarrayElementTypeString; //Field offset: 0x50
	internal Type PRarrayElementType; //Field offset: 0x54
	internal bool PRisArrayVariant; //Field offset: 0x58
	internal InternalPrimitiveTypeE PRarrayElementTypeCode; //Field offset: 0x5C
	internal int PRrank; //Field offset: 0x60
	internal Int32[] PRlengthA; //Field offset: 0x64
	internal Int32[] PRpositionA; //Field offset: 0x68
	internal Int32[] PRlowerBoundA; //Field offset: 0x6C
	internal Int32[] PRupperBoundA; //Field offset: 0x70
	internal Int32[] PRindexMap; //Field offset: 0x74
	internal int PRmemberIndex; //Field offset: 0x78
	internal int PRlinearlength; //Field offset: 0x7C
	internal Int32[] PRrectangularMap; //Field offset: 0x80
	internal bool PRisLowerBound; //Field offset: 0x84
	internal long PRtopId; //Field offset: 0x88
	internal long PRheaderId; //Field offset: 0x90
	internal ReadObjectInfo PRobjectInfo; //Field offset: 0x98
	internal bool PRisValueTypeFixup; //Field offset: 0x9C
	internal object PRnewObj; //Field offset: 0xA0
	internal Object[] PRobjectA; //Field offset: 0xA4
	internal PrimitiveArray PRprimitiveArray; //Field offset: 0xA8
	internal bool PRisRegistered; //Field offset: 0xAC
	internal Object[] PRmemberData; //Field offset: 0xB0
	internal SerializationInfo PRsi; //Field offset: 0xB4
	internal int PRnullCount; //Field offset: 0xB8

	private static ParseRecord() { }

	internal ParseRecord() { }

	internal void Init() { }

}

