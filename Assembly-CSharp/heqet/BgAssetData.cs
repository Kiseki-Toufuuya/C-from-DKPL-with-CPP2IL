namespace Heqet;

public class BgAssetData : AssetDataEx
{
	protected AssetBundleLoadAssetOperation m_Operation; //Field offset: 0x10

	public BgAssetData(int bgId) { }

	public virtual T GetAsset() { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	public virtual void LoadAsset() { }

	public virtual void UnLoadAsset() { }

}

