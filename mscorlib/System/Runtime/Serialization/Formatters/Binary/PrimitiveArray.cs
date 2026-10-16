namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class PrimitiveArray
{
	private InternalPrimitiveTypeE code; //Field offset: 0x8
	private Boolean[] booleanA; //Field offset: 0xC
	private Char[] charA; //Field offset: 0x10
	private Double[] doubleA; //Field offset: 0x14
	private Int16[] int16A; //Field offset: 0x18
	private Int32[] int32A; //Field offset: 0x1C
	private Int64[] int64A; //Field offset: 0x20
	private SByte[] sbyteA; //Field offset: 0x24
	private Single[] singleA; //Field offset: 0x28
	private UInt16[] uint16A; //Field offset: 0x2C
	private UInt32[] uint32A; //Field offset: 0x30
	private UInt64[] uint64A; //Field offset: 0x34

	internal PrimitiveArray(InternalPrimitiveTypeE code, Array array) { }

	internal void Init(InternalPrimitiveTypeE code, Array array) { }

	internal void SetValue(string value, int index) { }

}

