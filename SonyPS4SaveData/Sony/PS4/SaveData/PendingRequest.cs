namespace Sony.PS4.SaveData;

public class PendingRequest
{
	internal int requestId; //Field offset: 0x8
	internal RequestBase request; //Field offset: 0xC
	internal ResponseBase response; //Field offset: 0x10
	internal bool abortPending; //Field offset: 0x14

	public PendingRequest() { }

}

