namespace XeSys.uGUI;

public class SkinSpriteSwitcher : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass11_0
	{
		public string skinPrefabAsset; //Field offset: 0x8
		public SkinSpriteSwitcher <>4__this; //Field offset: 0xC
		public AssetBundleRequest request; //Field offset: 0x10

		public <>c__DisplayClass11_0() { }

		internal void <UpdateSkinSprites>b__0(AsyncOperation op) { }

	}

	[SerializeField]
	private Image[] m_images; //Field offset: 0x10
	[CompilerGenerated]
	private string <LayoutName>k__BackingField; //Field offset: 0x14
	private Dictionary<Int32, Sprite> m_oringSprite; //Field offset: 0x18

	public bool IsChanged
	{
		 get { } //Length: 69
	}

	public private string LayoutName
	{
		[CompilerGenerated]
		private get { } //Length: 11
		[CompilerGenerated]
		 set { } //Length: 27
	}

	public SkinSpriteSwitcher() { }

	private void Awake() { }

	public bool get_IsChanged() { }

	[CompilerGenerated]
	private string get_LayoutName() { }

	public void RestoreSKinSprite() { }

	[CompilerGenerated]
	public void set_LayoutName(string value) { }

	private void SetSkinSprite(SpriteAtlas spriteAtlas) { }

	public void UpdateSkinSprites(string themeName) { }

}

