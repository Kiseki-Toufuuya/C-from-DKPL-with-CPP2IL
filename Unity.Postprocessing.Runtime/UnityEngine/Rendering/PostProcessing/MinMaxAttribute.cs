namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class MinMaxAttribute : Attribute
{
	public readonly float min; //Field offset: 0x8
	public readonly float max; //Field offset: 0xC

	public MinMaxAttribute(float min, float max) { }

}

