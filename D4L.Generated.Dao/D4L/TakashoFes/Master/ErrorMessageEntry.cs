namespace D4L.TakashoFes.Master;

public sealed class ErrorMessageEntry : IFlatbuffersDaoEntry<Int32>
{
	[CompilerGenerated]
	private int <ID>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <ErrorTitle>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private string <ErrorMessage>k__BackingField; //Field offset: 0x10

	public string ErrorMessage
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string ErrorTitle
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public int ID
	{
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public ErrorMessageEntry() { }

	public static ErrorMessageEntry Create(ErrorMessageRawEntry source) { }

	[CompilerGenerated]
	public string get_ErrorMessage() { }

	[CompilerGenerated]
	public string get_ErrorTitle() { }

	[CompilerGenerated]
	public void set_ErrorMessage(string value) { }

	[CompilerGenerated]
	public void set_ErrorTitle(string value) { }

	[CompilerGenerated]
	public void set_ID(int value) { }

}

