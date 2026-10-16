namespace System.Linq.Expressions;

internal static class Utils
{
	public static readonly object BoxedFalse; //Field offset: 0x0
	public static readonly object BoxedTrue; //Field offset: 0x4
	public static readonly object BoxedIntM1; //Field offset: 0x8
	public static readonly object BoxedInt0; //Field offset: 0xC
	public static readonly object BoxedInt1; //Field offset: 0x10
	public static readonly object BoxedInt2; //Field offset: 0x14
	public static readonly object BoxedInt3; //Field offset: 0x18
	public static readonly object BoxedDefaultSByte; //Field offset: 0x1C
	public static readonly object BoxedDefaultChar; //Field offset: 0x20
	public static readonly object BoxedDefaultInt16; //Field offset: 0x24
	public static readonly object BoxedDefaultInt64; //Field offset: 0x28
	public static readonly object BoxedDefaultByte; //Field offset: 0x2C
	public static readonly object BoxedDefaultUInt16; //Field offset: 0x30
	public static readonly object BoxedDefaultUInt32; //Field offset: 0x34
	public static readonly object BoxedDefaultUInt64; //Field offset: 0x38
	public static readonly object BoxedDefaultSingle; //Field offset: 0x3C
	public static readonly object BoxedDefaultDouble; //Field offset: 0x40
	public static readonly object BoxedDefaultDecimal; //Field offset: 0x44
	public static readonly object BoxedDefaultDateTime; //Field offset: 0x48
	private static readonly ConstantExpression s_true; //Field offset: 0x4C
	private static readonly ConstantExpression s_false; //Field offset: 0x50
	private static readonly ConstantExpression s_m1; //Field offset: 0x54
	private static readonly ConstantExpression s_0; //Field offset: 0x58
	private static readonly ConstantExpression s_1; //Field offset: 0x5C
	private static readonly ConstantExpression s_2; //Field offset: 0x60
	private static readonly ConstantExpression s_3; //Field offset: 0x64
	public static readonly DefaultExpression Empty; //Field offset: 0x68
	public static readonly ConstantExpression Null; //Field offset: 0x6C

	private static Utils() { }

	public static ConstantExpression Constant(int value) { }

	public static ConstantExpression Constant(bool value) { }

}

