namespace System.Runtime.Serialization.Formatters.Binary;

internal sealed class Converter
{
	private static int primitiveTypeEnumLength; //Field offset: 0x0
	private static Type[] typeA; //Field offset: 0x4
	private static Type[] arrayTypeA; //Field offset: 0x8
	private static String[] valueA; //Field offset: 0xC
	private static TypeCode[] typeCodeA; //Field offset: 0x10
	private static InternalPrimitiveTypeE[] codeA; //Field offset: 0x14
	internal static Type typeofISerializable; //Field offset: 0x18
	internal static Type typeofString; //Field offset: 0x1C
	internal static Type typeofConverter; //Field offset: 0x20
	internal static Type typeofBoolean; //Field offset: 0x24
	internal static Type typeofByte; //Field offset: 0x28
	internal static Type typeofChar; //Field offset: 0x2C
	internal static Type typeofDecimal; //Field offset: 0x30
	internal static Type typeofDouble; //Field offset: 0x34
	internal static Type typeofInt16; //Field offset: 0x38
	internal static Type typeofInt32; //Field offset: 0x3C
	internal static Type typeofInt64; //Field offset: 0x40
	internal static Type typeofSByte; //Field offset: 0x44
	internal static Type typeofSingle; //Field offset: 0x48
	internal static Type typeofTimeSpan; //Field offset: 0x4C
	internal static Type typeofDateTime; //Field offset: 0x50
	internal static Type typeofUInt16; //Field offset: 0x54
	internal static Type typeofUInt32; //Field offset: 0x58
	internal static Type typeofUInt64; //Field offset: 0x5C
	internal static Type typeofObject; //Field offset: 0x60
	internal static Type typeofSystemVoid; //Field offset: 0x64
	internal static Assembly urtAssembly; //Field offset: 0x68
	internal static string urtAssemblyString; //Field offset: 0x6C
	internal static Type typeofTypeArray; //Field offset: 0x70
	internal static Type typeofObjectArray; //Field offset: 0x74
	internal static Type typeofStringArray; //Field offset: 0x78
	internal static Type typeofBooleanArray; //Field offset: 0x7C
	internal static Type typeofByteArray; //Field offset: 0x80
	internal static Type typeofCharArray; //Field offset: 0x84
	internal static Type typeofDecimalArray; //Field offset: 0x88
	internal static Type typeofDoubleArray; //Field offset: 0x8C
	internal static Type typeofInt16Array; //Field offset: 0x90
	internal static Type typeofInt32Array; //Field offset: 0x94
	internal static Type typeofInt64Array; //Field offset: 0x98
	internal static Type typeofSByteArray; //Field offset: 0x9C
	internal static Type typeofSingleArray; //Field offset: 0xA0
	internal static Type typeofTimeSpanArray; //Field offset: 0xA4
	internal static Type typeofDateTimeArray; //Field offset: 0xA8
	internal static Type typeofUInt16Array; //Field offset: 0xAC
	internal static Type typeofUInt32Array; //Field offset: 0xB0
	internal static Type typeofUInt64Array; //Field offset: 0xB4
	internal static Type typeofMarshalByRefObject; //Field offset: 0xB8

	private static Converter() { }

	internal static Array CreatePrimitiveArray(InternalPrimitiveTypeE code, int length) { }

	internal static object FromString(string value, InternalPrimitiveTypeE code) { }

	private static void InitArrayTypeA() { }

	private static void InitCodeA() { }

	private static void InitTypeA() { }

	private static void InitTypeCodeA() { }

	private static void InitValueA() { }

	internal static bool IsPrimitiveArray(Type type, out object typeInformation) { }

	internal static bool IsWriteAsByteArray(InternalPrimitiveTypeE code) { }

	internal static Type ToArrayType(InternalPrimitiveTypeE code) { }

	internal static InternalPrimitiveTypeE ToCode(Type type) { }

	internal static string ToComType(InternalPrimitiveTypeE code) { }

	internal static InternalPrimitiveTypeE ToPrimitiveTypeEnum(TypeCode typeCode) { }

	internal static Type ToType(InternalPrimitiveTypeE code) { }

	internal static TypeCode ToTypeCode(InternalPrimitiveTypeE code) { }

	internal static int TypeLength(InternalPrimitiveTypeE code) { }

}

