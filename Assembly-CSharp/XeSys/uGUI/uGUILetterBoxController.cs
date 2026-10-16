namespace XeSys.uGUI;

public class uGUILetterBoxController : MonoBehaviour
{
	private enum eType
	{
		None = 0,
		TopBottom = 1,
		LeftRight = 2,
	}

	internal enum Mode
	{
		Colored = 0,
		Tiled = 1,
	}

	[SerializeField]
	private RectTransform[] m_modeRoots; //Field offset: 0x10
	[SerializeField]
	private Image m_image1; //Field offset: 0x14
	[SerializeField]
	private Image m_image2; //Field offset: 0x18
	[SerializeField]
	private Sprite m_tilingSprite; //Field offset: 0x1C
	[CompilerGenerated]
	private Mode <mode>k__BackingField; //Field offset: 0x20
	[CompilerGenerated]
	private bool <visible>k__BackingField; //Field offset: 0x24
	private bool m_need; //Field offset: 0x25
	private Vector2 mAnchorLC; //Field offset: 0x28
	private Vector2 mAnchorRC; //Field offset: 0x30
	private Vector2 mAnchorCT; //Field offset: 0x38
	private Vector2 mAnchorCB; //Field offset: 0x40
	private Vector2 mPivotLeft; //Field offset: 0x48
	private Vector2 mPivotRight; //Field offset: 0x50
	private Vector2 mPivotTop; //Field offset: 0x58
	private Vector2 mPivotBottom; //Field offset: 0x60
	private List<Image> mTilingImages1; //Field offset: 0x68
	private List<Image> mTilingImages2; //Field offset: 0x6C

	public private Mode mode
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public private bool visible
	{
		[CompilerGenerated]
		 get { } //Length: 11
		[CompilerGenerated]
		private set { } //Length: 14
	}

	public uGUILetterBoxController() { }

	private void Awake() { }

	public void ChangeSettings(uGUILetterBoxController newSettings) { }

	private void DestroyTiledObjects() { }

	[CompilerGenerated]
	public Mode get_mode() { }

	[CompilerGenerated]
	public bool get_visible() { }

	private void InitializeTiled() { }

	[CompilerGenerated]
	private void set_mode(Mode value) { }

	[CompilerGenerated]
	private void set_visible(bool value) { }

	public void SetColor(Color color) { }

	public void SetMode(Mode mode_, bool visible_ = true) { }

	public void SetVisible(bool visible_) { }

	private void Start() { }

	private void Update() { }

	private void UpdateColored(Vector2 anchor1, Vector2 pivot1, Vector2 anchor2, Vector2 pivot2, float w, float h) { }

	private void UpdateLetterbox() { }

	private void UpdateTiled(Vector2 anchor1, Vector2 pivot1, Vector2 anchor2, Vector2 pivot2, bool isTB) { }

}

