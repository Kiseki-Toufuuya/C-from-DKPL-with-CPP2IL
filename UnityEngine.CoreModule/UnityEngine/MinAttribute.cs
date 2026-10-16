namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
public sealed class MinAttribute : PropertyAttribute
{
	public readonly float min; //Field offset: 0xC

	public MinAttribute(float min) { }

}

