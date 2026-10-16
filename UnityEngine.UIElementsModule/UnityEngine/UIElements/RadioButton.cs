namespace UnityEngine.UIElements;

public class RadioButton : BaseBoolField, IGroupBoxOption
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<RadioButton, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : BaseFieldTraits<Boolean, UxmlBoolAttributeDescription>
	{
		private UxmlStringAttributeDescription m_Text; //Field offset: 0x50

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x4
	public static readonly string inputUssClassName; //Field offset: 0x8
	public static readonly string checkmarkBackgroundUssClassName; //Field offset: 0xC
	public static readonly string checkmarkUssClassName; //Field offset: 0x10
	public static readonly string textUssClassName; //Field offset: 0x14
	private VisualElement m_CheckmarkBackground; //Field offset: 0x3D0

	public virtual bool value
	{
		 get { } //Length: 51
		 set { } //Length: 156
	}

	private static RadioButton() { }

	public RadioButton() { }

	public RadioButton(string label) { }

	public virtual bool get_value() { }

	protected virtual void InitLabel() { }

	private void OnOptionAttachToPanel(AttachToPanelEvent evt) { }

	private void OnOptionDetachFromPanel(DetachFromPanelEvent evt) { }

	public virtual void set_value(bool value) { }

	public virtual void SetValueWithoutNotify(bool newValue) { }

	protected virtual void ToggleValue() { }

	private override void UnityEngine.UIElements.IGroupBoxOption.SetSelected(bool selected) { }

	private void UpdateCheckmark() { }

	protected virtual void UpdateMixedValueContent() { }

}

