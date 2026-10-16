namespace XeSys.Gfx;

public class LayoutUGUINumber : MonoBehaviour, ILayoutUGUIAfterExport, ILayoutUGUIInitializeFromLayout
{
	[SerializeField]
	private GameObject[] m_digitObj; //Field offset: 0x10
	private AbsoluteLayout m_abs; //Field offset: 0x14
	private ViewBase[] m_viewList; //Field offset: 0x18
	private List<Int32> m_digit; //Field offset: 0x1C
	private int m_number; //Field offset: 0x20

	public int Number
	{
		 get { } //Length: 11
	}

	public LayoutUGUINumber() { }

	public override void AfterExport() { }

	public int get_Number() { }

	public override bool InitializeFromLayout(Layout layout, TexUVListManager[] uvManList) { }

	public void SetNumber(int number) { }

}

