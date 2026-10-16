namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
public sealed class RangeAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0xC
	public readonly float max; //Field offset: 0x10

	public RangeAttribute(float min, float max) { }

}

