namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class TrackballAttribute : Attribute
{
	internal enum Mode
	{
		None = 0,
		Lift = 1,
		Gamma = 2,
		Gain = 3,
	}

	public readonly Mode mode; //Field offset: 0x8

	public TrackballAttribute(Mode mode) { }

}

