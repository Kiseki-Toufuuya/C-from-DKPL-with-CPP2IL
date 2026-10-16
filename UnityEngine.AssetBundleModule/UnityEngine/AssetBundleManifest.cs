namespace UnityEngine;

[NativeHeader("Modules/AssetBundle/Public/AssetBundleManifest.h")]
public class AssetBundleManifest : object
{

	private AssetBundleManifest() { }

	[NativeMethod("GetAllDependencies")]
	public String[] GetAllDependencies(string assetBundleName) { }

	private static String[] GetAllDependencies_Injected(IntPtr _unity_self, ref ManagedSpanWrapper assetBundleName) { }

}

