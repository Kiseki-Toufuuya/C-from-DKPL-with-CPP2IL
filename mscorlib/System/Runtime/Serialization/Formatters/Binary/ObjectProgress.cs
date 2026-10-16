namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class ObjectProgress
{
	internal static int opRecordIdCount; //Field offset: 0x0
	internal bool isInitial; //Field offset: 0x8
	internal int count; //Field offset: 0xC
	internal BinaryTypeEnum expectedType; //Field offset: 0x10
	internal object expectedTypeInformation; //Field offset: 0x14
	internal string name; //Field offset: 0x18
	internal InternalObjectTypeE objectTypeEnum; //Field offset: 0x1C
	internal InternalMemberTypeE memberTypeEnum; //Field offset: 0x20
	internal InternalMemberValueE memberValueEnum; //Field offset: 0x24
	internal Type dtType; //Field offset: 0x28
	internal int numItems; //Field offset: 0x2C
	internal BinaryTypeEnum binaryTypeEnum; //Field offset: 0x30
	internal object typeInformation; //Field offset: 0x34
	internal int nullCount; //Field offset: 0x38
	internal int memberLength; //Field offset: 0x3C
	internal BinaryTypeEnum[] binaryTypeEnumA; //Field offset: 0x40
	internal Object[] typeInformationA; //Field offset: 0x44
	internal String[] memberNames; //Field offset: 0x48
	internal Type[] memberTypes; //Field offset: 0x4C
	internal ParseRecord pr; //Field offset: 0x50

	private static ObjectProgress() { }

	internal ObjectProgress() { }

	internal void ArrayCountIncrement(int value) { }

	internal bool GetNext(out BinaryTypeEnum outBinaryTypeEnum, out object outTypeInformation) { }

	internal void Init() { }

}

