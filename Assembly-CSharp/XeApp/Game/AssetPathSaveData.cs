namespace XeApp.Game;

public class AssetPathSaveData : ISaveDataContainer
{
	private readonly short VERSION; //Field offset: 0x8
	private readonly uint SIGNATURE; //Field offset: 0xC
	private Dictionary<String, String> keyValues; //Field offset: 0x10
	private int UpdateHash; //Field offset: 0x14

	public override short FormatVersion
	{
		 get { } //Length: 12
	}

	public override uint Signature
	{
		 get { } //Length: 11
	}

	public AssetPathSaveData() { }

	public override void CopyTo(object dest) { }

	public override bool DeserializeFromBytes(int verson, Byte[] bytes) { }

	public override short get_FormatVersion() { }

	public override uint get_Signature() { }

	public string GetStringValue(string key) { }

	public override bool Match(object dest) { }

	public override void ResetToDefault() { }

	public override Byte[] SerializeToBytes() { }

	public void SetStringValue(string key, string value) { }

	public bool TryGetLongValue(string key, out string v) { }

}

