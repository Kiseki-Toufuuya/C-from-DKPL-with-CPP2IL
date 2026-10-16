namespace UnityEngine.UIElements;

public abstract class AbstractProgressBar : BindableElement, INotifyValueChanged<Single>
{
	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0x48
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0x4C
		private UxmlFloatAttributeDescription m_Value; //Field offset: 0x50
		private UxmlStringAttributeDescription m_Title; //Field offset: 0x54

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId titleProperty; //Field offset: 0x0
	internal static readonly BindingId lowValueProperty; //Field offset: 0x4C
	internal static readonly BindingId highValueProperty; //Field offset: 0x98
	internal static readonly BindingId valueProperty; //Field offset: 0xE4
	public static readonly string ussClassName; //Field offset: 0x130
	public static readonly string containerUssClassName; //Field offset: 0x134
	public static readonly string titleUssClassName; //Field offset: 0x138
	public static readonly string titleContainerUssClassName; //Field offset: 0x13C
	public static readonly string progressUssClassName; //Field offset: 0x140
	public static readonly string backgroundUssClassName; //Field offset: 0x144
	private readonly VisualElement m_Background; //Field offset: 0x370
	private readonly VisualElement m_Progress; //Field offset: 0x374
	private readonly Label m_Title; //Field offset: 0x378
	private float m_LowValue; //Field offset: 0x37C
	private float m_HighValue; //Field offset: 0x380
	private float m_Value; //Field offset: 0x384

	[CreateProperty]
	public float highValue
	{
		 get { } //Length: 14
		 set { } //Length: 255
	}

	[CreateProperty]
	public float lowValue
	{
		 get { } //Length: 14
		 set { } //Length: 253
	}

	[CreateProperty]
	public string title
	{
		 get { } //Length: 43
		 set { } //Length: 197
	}

	[CreateProperty]
	public override float value
	{
		 get { } //Length: 14
		 set { } //Length: 832
	}

	private static AbstractProgressBar() { }

	public AbstractProgressBar() { }

	private float CalculateOppositeProgressWidth(float width) { }

	public float get_highValue() { }

	public float get_lowValue() { }

	public string get_title() { }

	public override float get_value() { }

	private void OnGeometryChanged(GeometryChangedEvent e) { }

	public void set_highValue(float value) { }

	public void set_lowValue(float value) { }

	public void set_title(string value) { }

	public override void set_value(float value) { }

	private void SetProgress(float p) { }

	public override void SetValueWithoutNotify(float newValue) { }

}

