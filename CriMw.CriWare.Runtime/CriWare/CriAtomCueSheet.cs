namespace CriWare;

public class CriAtomCueSheet
{
	public string name; //Field offset: 0x8
	public string acbFile; //Field offset: 0xC
	public string awbFile; //Field offset: 0x10
	public CriAtomExAcb acb; //Field offset: 0x14
	public Status loaderStatus; //Field offset: 0x18

	public bool IsError
	{
		 get { } //Length: 35
	}

	public bool IsLoading
	{
		 get { } //Length: 15
	}

	public CriAtomCueSheet() { }

	public bool get_IsError() { }

	public bool get_IsLoading() { }

}

