namespace Sony.PS4.SaveData;

public abstract class ResponseBase
{
	internal int returnCode; //Field offset: 0x8
	internal bool locked; //Field offset: 0xC
	internal Exception exception; //Field offset: 0x10

	public bool IsErrorCode
	{
		 get { } //Length: 85
	}

	public bool Locked
	{
		 get { } //Length: 11
	}

	public ReturnCodes ReturnCode
	{
		 get { } //Length: 82
	}

	public int ReturnCodeValue
	{
		 get { } //Length: 82
	}

	internal ResponseBase() { }

	public bool get_IsErrorCode() { }

	public bool get_Locked() { }

	public ReturnCodes get_ReturnCode() { }

	public int get_ReturnCodeValue() { }

	internal void ThrowExceptionIfLocked() { }

}

