namespace Heqet;

public static class LoadImageAsset
{

	public static void DeleteHeqetBgImage(int bgId, bool unloadAllLoadedObject = true) { }

	public static void DeleteHeqetFolderJacketImage(int _folderid, bool unloadAllLoadedObject = true) { }

	public static void DeleteHeqetJacket2kImage(int _jacketId, bool unloadAllLoadedObject = true) { }

	public static void DeleteHeqetJacketImage(int _jacketId, bool unloadAllLoadedObject = true) { }

	public static AssetBundleLoadAssetOperation GetHeqetBackGroungImage(Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetHeqetBackGroungImage(int _backgroundId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetHeqetFolderJacketImage(int _folderid, string langCode, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static string GetHeqetFolderJacketImagePath(int _folderid, string langCode) { }

	public static AssetBundleLoadAssetOperation GetHeqetJacket2kImage(int _jacketId, Action<AssetBundleLoadAssetOperation> load_end) { }

	public static AssetBundleLoadAssetOperation GetHeqetJacketImage(int _jacketId, Action<AssetBundleLoadAssetOperation> load_end) { }

}

