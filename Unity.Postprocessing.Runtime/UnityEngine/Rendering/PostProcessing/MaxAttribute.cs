namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class MaxAttribute : Attribute
{
	public readonly float max; //Field offset: 0x8

	public MaxAttribute(float max) { }

}

