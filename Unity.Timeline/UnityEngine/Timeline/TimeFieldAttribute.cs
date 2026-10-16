namespace UnityEngine.Timeline;

internal class TimeFieldAttribute : PropertyAttribute
{
	internal enum UseEditMode
	{
		None = 0,
		ApplyEditMode = 1,
	}

	[CompilerGenerated]
	private readonly UseEditMode <useEditMode>k__BackingField; //Field offset: 0xC

	public UseEditMode useEditMode
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public TimeFieldAttribute(UseEditMode useEditMode = 1) { }

	[CompilerGenerated]
	public UseEditMode get_useEditMode() { }

}

