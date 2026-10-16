namespace XeApp.Game.Menu;

public class SelectValueContentControl : MonoBehaviour
{
	[SerializeField]
	private ScrollContentControl m_ScrollContentControl; //Field offset: 0x10
	private Text m_ValueText; //Field offset: 0x14
	private Button m_SelectButton; //Field offset: 0x18
	private List<String> m_StrList; //Field offset: 0x1C
	private int m_Select; //Field offset: 0x20
	private bool m_IsCheckOutsideArea; //Field offset: 0x24
	private Action m_OnClickSelectStart; //Field offset: 0x28

	public Action OnClickSelectStart
	{
		 set { } //Length: 27
	}

	public SelectValueContentControl() { }

	public void Awake() { }

	public string GetSelectItem() { }

	private void HideSelectContent() { }

	private void OnSelectItem(int index) { }

	private void OnSelectStart() { }

	public void set_OnClickSelectStart(Action value) { }

	public void Setup(Vector2 item_size, Vector2 area_size, List<String> str_list, int default_index) { }

	public void Update() { }

}

