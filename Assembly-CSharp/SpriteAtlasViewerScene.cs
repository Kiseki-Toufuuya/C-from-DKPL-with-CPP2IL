//Type is in global namespace

public class SpriteAtlasViewerScene : MonoBehaviour
{
	[SerializeField]
	private Dropdown DropdownBundle; //Field offset: 0x10
	[SerializeField]
	private Dropdown DropdownSprite; //Field offset: 0x14
	[SerializeField]
	private Image SelectImage; //Field offset: 0x18
	private SpriteAtlas CurrentAtlas; //Field offset: 0x1C
	private Sprite[] Sprites; //Field offset: 0x20

	public SpriteAtlasViewerScene() { }

	[CompilerGenerated]
	private void <OpenSpriteAtlas>b__9_0(AssetBundleLoadAssetOperation lbo) { }

	private void LoadBundleNames() { }

	private string MakeAtlasName(int value) { }

	private void OnChangeSprite(int v) { }

	public void OpenSpriteAtlas(int v) { }

	private void Start() { }

	private void Update() { }

}

