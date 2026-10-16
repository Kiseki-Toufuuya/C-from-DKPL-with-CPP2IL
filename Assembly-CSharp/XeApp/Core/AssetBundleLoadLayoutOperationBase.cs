namespace XeApp.Core;

public abstract class AssetBundleLoadLayoutOperationBase : AssetBundleLoadAssetOperationFull
{

	public AssetBundleLoadLayoutOperationBase(string bundleName, string prefabName, Action<AssetBundleLoadAssetOperation> end_load) { }

	public abstract IEnumerator CreateLayoutCoroutine(LayoutUGUIRuntime runtime, Font font, Action<Layout, TexUVListManager> finish) { }

	public abstract IEnumerator InitializeLayoutCoroutine(Font font, Action<GameObject> finish) { }

}

