namespace UnityEngine.UIElements;

public class Toggle : BaseBoolField
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Toggle, UxmlTraits>
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
	[Obsolete]
	public static readonly string noTextVariantUssClassName; //Field offset: 0xC
	public static readonly string checkmarkUssClassName; //Field offset: 0x10
	public static readonly string textUssClassName; //Field offset: 0x14
	public static readonly string mixedValuesUssClassName; //Field offset: 0x18

	private static Toggle() { }

	public Toggle() { }

	public Toggle(string label) { }

	protected virtual void InitLabel() { }

	protected virtual void UpdateMixedValueContent() { }

}

