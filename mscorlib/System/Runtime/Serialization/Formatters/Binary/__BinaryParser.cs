namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class __BinaryParser
{
	private static Encoding encoding; //Field offset: 0x0
	internal static MessageEnd messageEnd; //Field offset: 0x4
	internal ObjectReader objectReader; //Field offset: 0x8
	internal Stream input; //Field offset: 0xC
	internal long topId; //Field offset: 0x10
	internal long headerId; //Field offset: 0x18
	internal SizedArray objectMapIdTable; //Field offset: 0x20
	internal SizedArray assemIdToAssemblyTable; //Field offset: 0x24
	internal SerStack stack; //Field offset: 0x28
	internal BinaryTypeEnum expectedType; //Field offset: 0x2C
	internal object expectedTypeInformation; //Field offset: 0x30
	internal ParseRecord PRS; //Field offset: 0x34
	private BinaryAssemblyInfo systemAssemblyInfo; //Field offset: 0x38
	private BinaryReader dataReader; //Field offset: 0x3C
	private SerStack opPool; //Field offset: 0x40
	private BinaryObject binaryObject; //Field offset: 0x44
	private BinaryObjectWithMap bowm; //Field offset: 0x48
	private BinaryObjectWithMapTyped bowmt; //Field offset: 0x4C
	internal BinaryObjectString objectString; //Field offset: 0x50
	internal BinaryCrossAppDomainString crossAppDomainString; //Field offset: 0x54
	internal MemberPrimitiveTyped memberPrimitiveTyped; //Field offset: 0x58
	private Byte[] byteBuffer; //Field offset: 0x5C
	internal MemberPrimitiveUnTyped memberPrimitiveUnTyped; //Field offset: 0x60
	internal MemberReference memberReference; //Field offset: 0x64
	internal ObjectNull objectNull; //Field offset: 0x68

	internal SizedArray AssemIdToAssemblyTable
	{
		internal get { } //Length: 171
	}

	internal SizedArray ObjectMapIdTable
	{
		internal get { } //Length: 171
	}

	internal ParseRecord prs
	{
		internal get { } //Length: 332
	}

	internal BinaryAssemblyInfo SystemAssemblyInfo
	{
		internal get { } //Length: 145
	}

	private static __BinaryParser() { }

	internal __BinaryParser(Stream stream, ObjectReader objectReader) { }

	internal SizedArray get_AssemIdToAssemblyTable() { }

	internal SizedArray get_ObjectMapIdTable() { }

	internal ParseRecord get_prs() { }

	internal BinaryAssemblyInfo get_SystemAssemblyInfo() { }

	private ObjectProgress GetOp() { }

	private void PutOp(ObjectProgress op) { }

	private void ReadArray(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadArrayAsBytes(ParseRecord pr) { }

	internal void ReadAssembly(BinaryHeaderEnum binaryHeaderEnum) { }

	internal void ReadBegin() { }

	internal bool ReadBoolean() { }

	internal byte ReadByte() { }

	internal void ReadBytes(Byte[] byteA, int offset, int size) { }

	internal Byte[] ReadBytes(int length) { }

	internal char ReadChar() { }

	internal Char[] ReadChars(int length) { }

	internal void ReadCrossAppDomainMap() { }

	internal DateTime ReadDateTime() { }

	internal decimal ReadDecimal() { }

	internal double ReadDouble() { }

	internal void ReadEnd() { }

	internal short ReadInt16() { }

	internal int ReadInt32() { }

	internal long ReadInt64() { }

	private void ReadMemberPrimitiveTyped() { }

	private void ReadMemberPrimitiveUnTyped() { }

	private void ReadMemberReference() { }

	private void ReadMessageEnd() { }

	private void ReadObject() { }

	private void ReadObjectNull(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectString(BinaryHeaderEnum binaryHeaderEnum) { }

	internal void ReadObjectWithMap(BinaryHeaderEnum binaryHeaderEnum) { }

	private void ReadObjectWithMap(BinaryObjectWithMap record) { }

	private void ReadObjectWithMapTyped(BinaryObjectWithMapTyped record) { }

	internal void ReadObjectWithMapTyped(BinaryHeaderEnum binaryHeaderEnum) { }

	internal sbyte ReadSByte() { }

	internal void ReadSerializationHeaderRecord() { }

	internal float ReadSingle() { }

	internal string ReadString() { }

	internal TimeSpan ReadTimeSpan() { }

	internal ushort ReadUInt16() { }

	internal uint ReadUInt32() { }

	internal ulong ReadUInt64() { }

	internal object ReadValue(InternalPrimitiveTypeE code) { }

	internal void Run() { }

}

