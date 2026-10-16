//Type is in global namespace

public class TakashoUINode : MonoBehaviour
{
	[CompilerGenerated]
	private sealed class <>c__DisplayClass13_0
	{
		public Action<Int32> onTap; //Field offset: 0x8
		public int id; //Field offset: 0xC

		public <>c__DisplayClass13_0() { }

		internal void <InitButton>b__0() { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass14_0
	{
		public Action<Int32, Boolean> onChangeValue; //Field offset: 0x8
		public int id; //Field offset: 0xC

		public <>c__DisplayClass14_0() { }

		internal void <InitToggle>b__0(bool _) { }

	}

	[CompilerGenerated]
	private sealed class <>c__DisplayClass18_0
	{
		public Action<Int32, String> onChangeString; //Field offset: 0x8
		public int id; //Field offset: 0xC

		public <>c__DisplayClass18_0() { }

		internal void <InitInputField>b__0(string _) { }

	}

	[SerializeField]
	private Button Button; //Field offset: 0x10
	[SerializeField]
	private Text ButtonText; //Field offset: 0x14
	[SerializeField]
	private Toggle Toggle; //Field offset: 0x18
	[SerializeField]
	private Text ToggleText; //Field offset: 0x1C
	[SerializeField]
	private InputField InputField; //Field offset: 0x20
	[SerializeField]
	private Text InputFieldTitle; //Field offset: 0x24
	[SerializeField]
	private Image LabelImage; //Field offset: 0x28
	[SerializeField]
	private Text LabelText; //Field offset: 0x2C
	[SerializeField]
	private Image SpinImage; //Field offset: 0x30
	[SerializeField]
	private Button SpinButtonUp; //Field offset: 0x34
	[SerializeField]
	private Button SpinButtonDn; //Field offset: 0x38
	[SerializeField]
	private Text SpinTextTitle; //Field offset: 0x3C
	[SerializeField]
	private Text SpinTextValue; //Field offset: 0x40

	public bool IsToggleOn
	{
		 get { } //Length: 26
		 set { } //Length: 34
	}

	public TakashoUINode() { }

	public bool get_IsToggleOn() { }

	public void InitButton(string text, Action<Int32> onTap, int id) { }

	public void InitInputField(string text, Action<Int32, String> onChangeString, Func<Int32, String> onGetString, int id) { }

	public void InitLabel(string text) { }

	public void InitToggle(string text, Action<Int32, Boolean> onChangeValue, Func<Int32, Boolean> onGetBool, int id) { }

	public void set_IsToggleOn(bool value) { }

}

