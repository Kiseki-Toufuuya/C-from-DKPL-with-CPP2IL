//Type is in global namespace

public class AppCustomErrorInfo
{
	[CompilerGenerated]
	private string <Title>k__BackingField; //Field offset: 0x8
	[CompilerGenerated]
	private string <Message>k__BackingField; //Field offset: 0xC
	[CompilerGenerated]
	private string <DebugMessage>k__BackingField; //Field offset: 0x10
	[CompilerGenerated]
	private int <LocationID>k__BackingField; //Field offset: 0x14
	[CompilerGenerated]
	private AppErrorID <ErrorID>k__BackingField; //Field offset: 0x18
	[CompilerGenerated]
	private UIResult <UIResultID>k__BackingField; //Field offset: 0x1C

	public string DebugMessage
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public AppErrorID ErrorID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public int LocationID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public string Message
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public string Title
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public UIResult UIResultID
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 14
	}

	public AppCustomErrorInfo(string title, string message, string debugMessage, int locationID, AppErrorID errorID, UIResult uiResult) { }

	public static AppCustomErrorInfo Create(string title, string message, string debugMessage, int locationID, AppErrorID errorID, UIResult uiResult) { }

	public static AppCustomErrorInfo Create(LCXError ex, int locationID, UIResult uiResult) { }

	public static AppCustomErrorInfo Create(AppErrorID errorID, int locationID, string debugMessage, UIResult uiResult) { }

	[CompilerGenerated]
	public string get_DebugMessage() { }

	[CompilerGenerated]
	public AppErrorID get_ErrorID() { }

	[CompilerGenerated]
	public int get_LocationID() { }

	[CompilerGenerated]
	public string get_Message() { }

	[CompilerGenerated]
	public string get_Title() { }

	[CompilerGenerated]
	public UIResult get_UIResultID() { }

	[CompilerGenerated]
	public void set_DebugMessage(string value) { }

	[CompilerGenerated]
	public void set_ErrorID(AppErrorID value) { }

	[CompilerGenerated]
	public void set_LocationID(int value) { }

	[CompilerGenerated]
	public void set_Message(string value) { }

	[CompilerGenerated]
	public void set_Title(string value) { }

	[CompilerGenerated]
	public void set_UIResultID(UIResult value) { }

}

