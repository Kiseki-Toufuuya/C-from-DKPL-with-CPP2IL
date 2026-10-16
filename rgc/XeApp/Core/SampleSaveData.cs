namespace XeApp.Core;

public class SampleSaveData : ISaveDataContainer
{
	public int bgmVol; //Field offset: 0x8
	public int seVol; //Field offset: 0xC

	public override short FormatVersion
	{
		 get { } //Length: 6
	}

	public override uint Signature
	{
		 get { } //Length: 6
	}

	public SampleSaveData() { }

	public override void CopyTo(object dest) { }

	public override bool DeserializeFromBytes(int verson, Byte[] bytes) { }

	public override short get_FormatVersion() { }

	public override uint get_Signature() { }

	public override bool Match(object dest) { }

	public override void ResetToDefault() { }

	public override Byte[] SerializeToBytes() { }

}

