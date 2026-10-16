namespace UnityEngine.UIElements;

public class Scroller : VisualElement
{
	private class ScrollerSlider : Slider
	{

		public ScrollerSlider(float start, float end, SliderDirection direction, float pageSize) { }

		internal virtual float SliderNormalizeValue(float currentValue, float lowerValue, float higherValue) { }

	}

	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<Scroller, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits
	{
		private UxmlFloatAttributeDescription m_LowValue; //Field offset: 0x44
		private UxmlFloatAttributeDescription m_HighValue; //Field offset: 0x48
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0x4C
		private UxmlFloatAttributeDescription m_Value; //Field offset: 0x50

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	internal static readonly BindingId valueProperty; //Field offset: 0x0
	internal static readonly BindingId lowValueProperty; //Field offset: 0x4C
	internal static readonly BindingId highValueProperty; //Field offset: 0x98
	internal static readonly BindingId directionProperty; //Field offset: 0xE4
	public static readonly string ussClassName; //Field offset: 0x130
	public static readonly string horizontalVariantUssClassName; //Field offset: 0x134
	public static readonly string verticalVariantUssClassName; //Field offset: 0x138
	public static readonly string sliderUssClassName; //Field offset: 0x13C
	public static readonly string lowButtonUssClassName; //Field offset: 0x140
	public static readonly string highButtonUssClassName; //Field offset: 0x144
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private Action<Single> valueChanged; //Field offset: 0x368
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly Slider <slider>k__BackingField; //Field offset: 0x36C
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly RepeatButton <lowButton>k__BackingField; //Field offset: 0x370
	[CompilerGenerated]
	[DebuggerBrowsable(DebuggerBrowsableState::Never (0))]
	private readonly RepeatButton <highButton>k__BackingField; //Field offset: 0x374

	public event Action<Single> valueChanged
	{
		[CompilerGenerated]
		 add { } //Length: 130
		[CompilerGenerated]
		 remove { } //Length: 130
	}

	[CreateProperty]
	public SliderDirection direction
	{
		 get { } //Length: 83
		 set { } //Length: 498
	}

	public RepeatButton highButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[CreateProperty]
	public float highValue
	{
		 get { } //Length: 67
		 set { } //Length: 320
	}

	public RepeatButton lowButton
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[CreateProperty]
	public float lowValue
	{
		 get { } //Length: 67
		 set { } //Length: 318
	}

	public Slider slider
	{
		[CompilerGenerated]
		 get { } //Length: 14
	}

	[CreateProperty]
	public float value
	{
		 get { } //Length: 47
		 set { } //Length: 317
	}

	private static Scroller() { }

	public Scroller(float lowValue, float highValue, Action<Single> valueChanged, SliderDirection direction = 1) { }

	public Scroller() { }

	[CompilerGenerated]
	public void add_valueChanged(Action<Single> value) { }

	public void Adjust(float factor) { }

	public SliderDirection get_direction() { }

	[CompilerGenerated]
	public RepeatButton get_highButton() { }

	public float get_highValue() { }

	[CompilerGenerated]
	public RepeatButton get_lowButton() { }

	public float get_lowValue() { }

	[CompilerGenerated]
	public Slider get_slider() { }

	public float get_value() { }

	private void OnSliderValueChange(ChangeEvent<Single> evt) { }

	[CompilerGenerated]
	public void remove_valueChanged(Action<Single> value) { }

	public void ScrollPageDown() { }

	public void ScrollPageDown(float factor) { }

	public void ScrollPageUp(float factor) { }

	public void ScrollPageUp() { }

	public void set_direction(SliderDirection value) { }

	public void set_highValue(float value) { }

	public void set_lowValue(float value) { }

	public void set_value(float value) { }

}

