namespace XeApp.Game;

public class TextMarquee : MonoBehaviour
{
	[SerializeField]
	public int m_FontSize; //Field offset: 0x10
	[SerializeField]
	public float m_Speed; //Field offset: 0x14
	[SerializeField]
	public float m_WaitTime; //Field offset: 0x18
	[SerializeField]
	public bool m_LoopWait; //Field offset: 0x1C
	[SerializeField]
	public float m_Margin; //Field offset: 0x20
	private float Time; //Field offset: 0x24
	private Vector3 m_Default_pos; //Field offset: 0x28
	private TextMeshProUGUI TextMesh; //Field offset: 0x34
	private GameObject ParentObj; //Field offset: 0x38
	private GameObject ParentMask; //Field offset: 0x3C
	private Vector3 Pos; //Field offset: 0x40
	private TextAlignmentOptions m_TextAlignment; //Field offset: 0x4C
	private float TextSize; //Field offset: 0x50
	private float OffSet; //Field offset: 0x54
	private float SpaceOffSet; //Field offset: 0x58
	private string BaseText; //Field offset: 0x5C
	private bool Enabled; //Field offset: 0x60
	private Image m_MaskImage; //Field offset: 0x64

	public TextMarquee() { }

	private void Init() { }

	private void Start() { }

	private void Update() { }

}

