namespace Heqet;

public class ImageAssetBundleLoader
{
	protected Dictionary<Int32, ValueTuple`2<T, Action`1<AssetBundleLoadAssetOperation>>> m_requestParamMap; //Field offset: 0x0
	protected List<T> m_loadedParamList; //Field offset: 0x0
	protected T m_lastParam; //Field offset: 0x0
	private Func<T, Action`1<AssetBundleLoadAssetOperation>, AssetBundleLoadAssetOperation> m_loadFunc; //Field offset: 0x0
	private Action<T, Boolean> m_deleteFunc; //Field offset: 0x0

	public bool IsLoading
	{
		 get { } //Length: 46
	}

	public T LastParam
	{
		 get { } //Length: 14
	}

	public ImageAssetBundleLoader`1() { }

	[CompilerGenerated]
	private void <LoadAssetBundle>b__10_0(AssetBundleLoadAssetOperation ope) { }

	public bool get_IsLoading() { }

	public T get_LastParam() { }

	public void LoadAssetBundle(T param, Action<AssetBundleLoadAssetOperation> onLoadFinish) { }

	public void SetFuncs(Func<T, Action`1<AssetBundleLoadAssetOperation>, AssetBundleLoadAssetOperation> loadFunc, Action<T, Boolean> deleteFunc) { }

}

