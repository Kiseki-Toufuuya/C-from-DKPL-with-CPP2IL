namespace UnityEngine;

[AttributeUsage(384, Inherited = True, AllowMultiple = False)]
public sealed class ColorUsageAttribute : PropertyAttribute
{
	public readonly bool showAlpha; //Field offset: 0xC
	public readonly bool hdr; //Field offset: 0xD
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minBrightness; //Field offset: 0x10
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxBrightness; //Field offset: 0x14
	[Obsolete("This field is no longer used for anything.")]
	public readonly float minExposureValue; //Field offset: 0x18
	[Obsolete("This field is no longer used for anything.")]
	public readonly float maxExposureValue; //Field offset: 0x1C

	public ColorUsageAttribute(bool showAlpha) { }

	public ColorUsageAttribute(bool showAlpha, bool hdr) { }

	[Obsolete("Brightness and exposure parameters are no longer used for anything. Use ColorUsageAttribute(bool showAlpha, bool hdr)")]
	public ColorUsageAttribute(bool showAlpha, bool hdr, float minBrightness, float maxBrightness, float minExposureValue, float maxExposureValue) { }

}

