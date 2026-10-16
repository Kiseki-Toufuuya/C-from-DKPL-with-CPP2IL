namespace Sony.PS4.SaveData;

public class RequestBase
{
	internal FunctionTypes functionType; //Field offset: 0x8
	internal int userId; //Field offset: 0xC
	internal bool async; //Field offset: 0x10
	internal bool locked; //Field offset: 0x11
	private bool ignoreCallback; //Field offset: 0x12
	internal uint padding; //Field offset: 0x14

	public bool Async
	{
		 set { } //Length: 85
	}

	public bool IgnoreCallback
	{
		 set { } //Length: 85
	}

	public int UserId
	{
		 set { } //Length: 85
	}

	internal RequestBase(FunctionTypes functionType) { }

	public void set_Async(bool value) { }

	public void set_IgnoreCallback(bool value) { }

	public void set_UserId(int value) { }

	internal void ThrowExceptionIfLocked() { }

}

