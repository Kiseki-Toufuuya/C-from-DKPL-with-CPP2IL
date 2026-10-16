namespace Heqet;

public class JacketAssetData : AssetDataEx
{
	protected AssetBundleLoadAssetOperation m_Operation; //Field offset: 0x10

	public JacketAssetData(int jacketId) { }

	public virtual T GetAsset() { }

	public virtual bool IsDone() { }

	public virtual bool IsError() { }

	public virtual void LoadAsset() { }

	public virtual void UnLoadAsset() { }

}

