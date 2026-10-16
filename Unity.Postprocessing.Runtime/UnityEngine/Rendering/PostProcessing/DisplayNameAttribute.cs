namespace UnityEngine.Rendering.PostProcessing;

[AttributeUsage(AttributeTargets::Field (256), AllowMultiple = False)]
public sealed class DisplayNameAttribute : Attribute
{
	public readonly string displayName; //Field offset: 0x8

	public DisplayNameAttribute(string displayName) { }

}

