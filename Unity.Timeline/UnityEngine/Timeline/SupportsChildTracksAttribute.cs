namespace UnityEngine.Timeline;

[AttributeUsage(AttributeTargets::Class (4), Inherited = False)]
internal class SupportsChildTracksAttribute : Attribute
{
	public readonly Type childType; //Field offset: 0x8
	public readonly int levels; //Field offset: 0xC

	public SupportsChildTracksAttribute(Type childType = null, int levels = 2147483647) { }

}

