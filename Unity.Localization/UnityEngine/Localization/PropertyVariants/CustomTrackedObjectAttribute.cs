namespace UnityEngine.Localization.PropertyVariants;

[AttributeUsage(AttributeTargets::Class (4))]
public class CustomTrackedObjectAttribute : Attribute
{
	[CompilerGenerated]
	private readonly Type <ObjectType>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly bool <SupportsInheritedTypes>k__BackingField; //Field offset: 0xC

	internal Type ObjectType
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	internal bool SupportsInheritedTypes
	{
		[CompilerGenerated]
		internal get { } //Length: 11
	}

	public CustomTrackedObjectAttribute(Type type, bool supportsInheritedTypes) { }

	[CompilerGenerated]
	internal Type get_ObjectType() { }

	[CompilerGenerated]
	internal bool get_SupportsInheritedTypes() { }

}

