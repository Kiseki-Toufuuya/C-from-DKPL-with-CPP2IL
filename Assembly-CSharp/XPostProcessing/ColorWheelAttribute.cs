namespace XPostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class ColorWheelAttribute : Attribute
{
	internal enum Mode
	{
		None = 0,
		Lift = 1,
		Gamma = 2,
		Gain = 3,
		Contrast = 4,
	}

	public readonly Mode mode; //Field offset: 0x8

	public ColorWheelAttribute(Mode mode) { }

}

