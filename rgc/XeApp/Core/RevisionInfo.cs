namespace XeApp.Core;

public class RevisionInfo
{
	public string BuildNumber; //Field offset: 0x8
	public string BuildId; //Field offset: 0xC
	public string BuildTag; //Field offset: 0x10
	public string JobName; //Field offset: 0x14
	public string SvnRevision; //Field offset: 0x18

	public RevisionInfo() { }

	public void Load() { }

}

