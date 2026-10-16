namespace XeApp.Game.Menu;

public class ScrollContentControl : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_0
	{
		public Action<Int32> onSelectItem; //Field offset: 0x8

		public <>c__DisplayClass5_0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass5_1
	{
		public int index; //Field offset: 0x8
		public <>c__DisplayClass5_0 CS$<>8__locals1; //Field offset: 0xC

		public <>c__DisplayClass5_1() { }

		internal void <Setup>b__0() { }

	}

	[SerializeField]
	private GameObject m_Content; //Field offset: 0x10
	[SerializeField]
	private GameObject m_ItemObject; //Field offset: 0x14
	private Vector2 m_AreaSize; //Field offset: 0x18
	private Vector2 m_ItemSize; //Field offset: 0x20

	public ScrollContentControl() { }

	public void Awake() { }

	public void Hide() { }

	public void Setup(Vector2 area_size, Vector2 item_size, List<String> str_list, Action<Int32> onSelectItem) { }

	public void Show(int index) { }

}

