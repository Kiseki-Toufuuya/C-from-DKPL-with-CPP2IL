namespace UnityEngine.UI;

[AddComponentMenu("UI/Legacy/Dropdown", 102)]
[RequireComponent(typeof(RectTransform))]
public class Dropdown : Selectable, IPointerClickHandler, IEventSystemHandler, ISubmitHandler, ICancelHandler
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass63_0
	{
		public DropdownItem item; //Field offset: 0x8
		public Dropdown <>4__this; //Field offset: 0xC

		public <>c__DisplayClass63_0() { }

		internal void <Show>b__0(bool x) { }

	}

	[CompilerGenerated]
	private sealed class <DelayedDestroyDropdownList>d__75 : IEnumerator<Object>, IEnumerator, IDisposable
	{
		private int <>1__state; //Field offset: 0x8
		private object <>2__current; //Field offset: 0xC
		public float delay; //Field offset: 0x10
		public Dropdown <>4__this; //Field offset: 0x14

		private override object System.Collections.Generic.IEnumerator<System.Object>.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		private override object System.Collections.IEnumerator.Current
		{
			[DebuggerHidden]
			private get { } //Length: 11
		}

		[DebuggerHidden]
		public <DelayedDestroyDropdownList>d__75(int <>1__state) { }

		private override bool MoveNext() { }

		[DebuggerHidden]
		private override object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

		[DebuggerHidden]
		private override object System.Collections.IEnumerator.get_Current() { }

		[DebuggerHidden]
		private override void System.Collections.IEnumerator.Reset() { }

		[DebuggerHidden]
		private override void System.IDisposable.Dispose() { }

	}

	internal class DropdownEvent : UnityEvent<Int32>
	{

		public DropdownEvent() { }

	}

	private class DropdownItem : MonoBehaviour, IPointerEnterHandler, IEventSystemHandler, ICancelHandler
	{
		[SerializeField]
		private Text m_Text; //Field offset: 0x10
		[SerializeField]
		private Image m_Image; //Field offset: 0x14
		[SerializeField]
		private RectTransform m_RectTransform; //Field offset: 0x18
		[SerializeField]
		private Toggle m_Toggle; //Field offset: 0x1C

		public Image image
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public RectTransform rectTransform
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public Text text
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public Toggle toggle
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public DropdownItem() { }

		public Image get_image() { }

		public RectTransform get_rectTransform() { }

		public Text get_text() { }

		public Toggle get_toggle() { }

		public override void OnCancel(BaseEventData eventData) { }

		public override void OnPointerEnter(PointerEventData eventData) { }

		public void set_image(Image value) { }

		public void set_rectTransform(RectTransform value) { }

		public void set_text(Text value) { }

		public void set_toggle(Toggle value) { }

	}

	internal class OptionData
	{
		[SerializeField]
		private string m_Text; //Field offset: 0x8
		[SerializeField]
		private Sprite m_Image; //Field offset: 0xC

		public Sprite image
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public string text
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public OptionData() { }

		public OptionData(string text) { }

		public OptionData(Sprite image) { }

		public OptionData(string text, Sprite image) { }

		public Sprite get_image() { }

		public string get_text() { }

		public void set_image(Sprite value) { }

		public void set_text(string value) { }

	}

	internal class OptionDataList
	{
		[SerializeField]
		private List<OptionData> m_Options; //Field offset: 0x8

		public List<OptionData> options
		{
			 get { } //Length: 11
			 set { } //Length: 27
		}

		public OptionDataList() { }

		public List<OptionData> get_options() { }

		public void set_options(List<OptionData> value) { }

	}

	private const int kHighSortingLayer = 30000; //Field offset: 0x0
	private static OptionData s_NoOptionData; //Field offset: 0x0
	[SerializeField]
	private RectTransform m_Template; //Field offset: 0xB4
	[SerializeField]
	private Text m_CaptionText; //Field offset: 0xB8
	[SerializeField]
	private Image m_CaptionImage; //Field offset: 0xBC
	[SerializeField]
	[Space]
	private Text m_ItemText; //Field offset: 0xC0
	[SerializeField]
	private Image m_ItemImage; //Field offset: 0xC4
	[SerializeField]
	[Space]
	private int m_Value; //Field offset: 0xC8
	[SerializeField]
	[Space]
	private OptionDataList m_Options; //Field offset: 0xCC
	[SerializeField]
	[Space]
	private DropdownEvent m_OnValueChanged; //Field offset: 0xD0
	[SerializeField]
	private float m_AlphaFadeSpeed; //Field offset: 0xD4
	private GameObject m_Dropdown; //Field offset: 0xD8
	private GameObject m_Blocker; //Field offset: 0xDC
	private List<DropdownItem> m_Items; //Field offset: 0xE0
	private TweenRunner<FloatTween> m_AlphaTweenRunner; //Field offset: 0xE4
	private bool validTemplate; //Field offset: 0xE8

	public float alphaFadeSpeed
	{
		 get { } //Length: 14
		 set { } //Length: 21
	}

	public Image captionImage
	{
		 get { } //Length: 14
		 set { } //Length: 43
	}

	public Text captionText
	{
		 get { } //Length: 14
		 set { } //Length: 43
	}

	public Image itemImage
	{
		 get { } //Length: 14
		 set { } //Length: 43
	}

	public Text itemText
	{
		 get { } //Length: 14
		 set { } //Length: 43
	}

	public DropdownEvent onValueChanged
	{
		 get { } //Length: 14
		 set { } //Length: 33
	}

	public List<OptionData> options
	{
		 get { } //Length: 26
		 set { } //Length: 52
	}

	public RectTransform template
	{
		 get { } //Length: 14
		 set { } //Length: 43
	}

	public int value
	{
		 get { } //Length: 14
		 set { } //Length: 23
	}

	private static Dropdown() { }

	protected Dropdown() { }

	private DropdownItem AddItem(OptionData data, bool selected, DropdownItem itemTemplate, List<DropdownItem> items) { }

	public void AddOptions(List<Sprite> options) { }

	public void AddOptions(List<String> options) { }

	public void AddOptions(List<OptionData> options) { }

	private void AlphaFadeList(float duration, float start, float end) { }

	private void AlphaFadeList(float duration, float alpha) { }

	protected virtual void Awake() { }

	public void ClearOptions() { }

	protected override GameObject CreateBlocker(Canvas rootCanvas) { }

	protected override GameObject CreateDropdownList(GameObject template) { }

	protected override DropdownItem CreateItem(DropdownItem itemTemplate) { }

	[IteratorStateMachine(typeof(<DelayedDestroyDropdownList>d__75))]
	private IEnumerator DelayedDestroyDropdownList(float delay) { }

	protected override void DestroyBlocker(GameObject blocker) { }

	protected override void DestroyDropdownList(GameObject dropdownList) { }

	protected override void DestroyItem(DropdownItem item) { }

	public float get_alphaFadeSpeed() { }

	public Image get_captionImage() { }

	public Text get_captionText() { }

	public Image get_itemImage() { }

	public Text get_itemText() { }

	public DropdownEvent get_onValueChanged() { }

	public List<OptionData> get_options() { }

	public RectTransform get_template() { }

	public int get_value() { }

	private static T GetOrAddComponent(GameObject go) { }

	public void Hide() { }

	private void ImmediateDestroyDropdownList() { }

	public override void OnCancel(BaseEventData eventData) { }

	protected virtual void OnDisable() { }

	public override void OnPointerClick(PointerEventData eventData) { }

	private void OnSelectItem(Toggle toggle) { }

	public override void OnSubmit(BaseEventData eventData) { }

	public void RefreshShownValue() { }

	private void Set(int value, bool sendCallback = true) { }

	public void set_alphaFadeSpeed(float value) { }

	public void set_captionImage(Image value) { }

	public void set_captionText(Text value) { }

	public void set_itemImage(Image value) { }

	public void set_itemText(Text value) { }

	public void set_onValueChanged(DropdownEvent value) { }

	public void set_options(List<OptionData> value) { }

	public void set_template(RectTransform value) { }

	public void set_value(int value) { }

	private void SetAlpha(float alpha) { }

	private void SetupTemplate(Canvas rootCanvas) { }

	public void SetValueWithoutNotify(int input) { }

	public void Show() { }

	protected virtual void Start() { }

}

