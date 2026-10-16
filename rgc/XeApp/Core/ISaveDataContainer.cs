namespace XeApp.Core;

public interface ISaveDataContainer
{

	public short FormatVersion
	{
		 get { } //Length: 0
	}

	public uint Signature
	{
		 get { } //Length: 0
	}

	public void CopyTo(object dest) { }

	public bool DeserializeFromBytes(int verson, Byte[] bytes) { }

	public short get_FormatVersion() { }

	public uint get_Signature() { }

	public bool Match(object dest) { }

	public void ResetToDefault() { }

	public Byte[] SerializeToBytes() { }

}

