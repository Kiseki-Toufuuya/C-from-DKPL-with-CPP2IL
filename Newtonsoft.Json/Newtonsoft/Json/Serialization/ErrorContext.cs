namespace Newtonsoft.Json.Serialization;

[Nullable(0)]
[NullableContext(1)]
public class ErrorContext
{
	[CompilerGenerated]
	private bool <Traced>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private readonly Exception <Error>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <OriginalObject>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	[Nullable(2)]
	private readonly object <Member>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private readonly string <Path>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private bool <Handled>k__BackingField; //Field offset: 0x1C

	public Exception Error
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	public bool Handled
	{
		[CompilerGenerated]
		 get { } //Length: 11
	}

	internal bool Traced
	{
		[CompilerGenerated]
		internal get { } //Length: 11
		[CompilerGenerated]
		internal set { } //Length: 14
	}

	internal ErrorContext(object originalObject, object member, string path, Exception error) { }

	[CompilerGenerated]
	public Exception get_Error() { }

	[CompilerGenerated]
	public bool get_Handled() { }

	[CompilerGenerated]
	internal bool get_Traced() { }

	[CompilerGenerated]
	internal void set_Traced(bool value) { }

}

