namespace System.Runtime.CompilerServices;

[AttributeUsage(2304, Inherited = False)]
public sealed class DecimalConstantAttribute : Attribute
{
	private decimal _dec; //Field offset: 0x8

	public decimal Value
	{
		 get { } //Length: 18
	}

	[CLSCompliant(False)]
	public DecimalConstantAttribute(byte scale, byte sign, uint hi, uint mid, uint low) { }

	public decimal get_Value() { }

}

