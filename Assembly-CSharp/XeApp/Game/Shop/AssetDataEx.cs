namespace XeApp.Game.Shop;

public abstract class AssetDataEx
{
	public int m_Prefix; //Field offset: 0x8
	public int m_Id; //Field offset: 0xC

	public AssetDataEx(int prefix, int id) { }

	public abstract T GetAsset() { }

	public abstract bool IsDone() { }

	public abstract bool IsError() { }

	public abstract void LoadAsset() { }

	public abstract void UnLoadAsset() { }

}

