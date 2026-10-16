namespace UnityEngine.UIElements;

public class TextField : TextInputBaseField<String>
{
	private class TextInput : TextInputBase<String>
	{

		public bool multiline
		{
			 get { } //Length: 87
			 set { } //Length: 501
		}

		private TextField parentTextField
		{
			private get { } //Length: 108
		}

		public TextInput() { }

		public bool get_multiline() { }

		private TextField get_parentTextField() { }

		public void set_multiline(bool value) { }

		protected virtual string StringToValue(string str) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<TextField, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<String>
	{
		private static readonly UxmlStringAttributeDescription k_Value; //Field offset: 0x0
		private UxmlBoolAttributeDescription m_Multiline; //Field offset: 0x90

		private static UxmlTraits() { }

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId multilineProperty; //Field offset: 0x0
	public static readonly string ussClassName; //Field offset: 0x4C
	public static readonly string labelUssClassName; //Field offset: 0x50
	public static readonly string inputUssClassName; //Field offset: 0x54

	[CreateProperty]
	public bool multiline
	{
		 get { } //Length: 106
		 set { } //Length: 136
	}

	private TextInput textInput
	{
		private get { } //Length: 114
	}

	public virtual string value
	{
		 get { } //Length: 51
		 set { } //Length: 142
	}

	private static TextField() { }

	public TextField() { }

	public TextField(string label) { }

	public TextField(string label, int maxLength, bool multiline, bool isPasswordField, char maskChar) { }

	public bool get_multiline() { }

	private TextInput get_textInput() { }

	public virtual string get_value() { }

	[EventInterest(new IL2CPP_TYPE_IL2CPP_TYPE_INDEX[] {typeof(FocusOutEvent)})]
	protected virtual void HandleEventBubbleUp(EventBase evt) { }

	internal virtual void OnViewDataReady() { }

	public void set_multiline(bool value) { }

	public virtual void set_value(string value) { }

	public virtual void SetValueWithoutNotify(string newValue) { }

	protected virtual string StringToValue(string str) { }

	internal virtual void UpdateTextFromValue() { }

	protected virtual string ValueToString(string value) { }

}

