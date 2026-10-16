namespace Heqet;

public class CharacterAssetBunleLoader : IDisposable
{
	private ImageAssetBundleLoader<ValueTuple`2<Int32, Int32>> m_loader; //Field offset: 0x8
	private readonly CHARA_ICON_TYPE m_iconType; //Field offset: 0xC

	public CharacterAssetBunleLoader(CHARA_ICON_TYPE iconType) { }

	[CompilerGenerated]
	private AssetBundleLoadAssetOperation <.ctor>b__2_0(ValueTuple<Int32, Int32> param, Action<AssetBundleLoadAssetOperation> loadFunc) { }

	[CompilerGenerated]
	private void <.ctor>b__2_1(ValueTuple<Int32, Int32> param, bool unloadAllLoadedObject) { }

	public override void Dispose() { }

	public void GetCharaIcon(int heroineId, int skinId, Action<AssetBundleLoadAssetOperation> onLoaded) { }

}

