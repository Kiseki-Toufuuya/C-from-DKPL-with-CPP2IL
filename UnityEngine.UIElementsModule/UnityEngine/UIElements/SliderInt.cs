namespace UnityEngine.UIElements;

public class SliderInt : BaseSlider<Int32>
{
	[Obsolete("UxmlFactory is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlFactory : UxmlFactory<SliderInt, UxmlTraits>
	{

		public UxmlFactory() { }

	}

	[Obsolete("UxmlTraits is deprecated and will be removed. Use UxmlElementAttribute instead.", False)]
	internal class UxmlTraits : UxmlTraits<Int32, UxmlIntAttributeDescription>
	{
		private UxmlIntAttributeDescription m_LowValue; //Field offset: 0x50
		private UxmlIntAttributeDescription m_HighValue; //Field offset: 0x54
		private UxmlIntAttributeDescription m_PageSize; //Field offset: 0x58
		private UxmlBoolAttributeDescription m_ShowInputField; //Field offset: 0x5C
		private UxmlEnumAttributeDescription<SliderDirection> m_Direction; //Field offset: 0x60
		private UxmlBoolAttributeDescription m_Inverted; //Field offset: 0x64

		public UxmlTraits() { }

		public virtual void Init(VisualElement ve, IUxmlAttributes bag, CreationContext cc) { }

	}

	public static readonly string ussClassName; //Field offset: 0x0
	public static readonly string labelUssClassName; //Field offset: 0x4
	public static readonly string inputUssClassName; //Field offset: 0x8

	public virtual float pageSize
	{
		 get { } //Length: 51
		 set { } //Length: 150
	}

	private static SliderInt() { }

	public SliderInt() { }

	public SliderInt(string label, int start = 0, int end = 10, SliderDirection direction = 0, float pageSize = 0) { }

	public virtual void ApplyInputDeviceDelta(Vector3 delta, DeltaSpeed speed, int startValue) { }

	internal virtual void ComputeValueAndDirectionFromClick(float sliderLength, float dragElementLength, float dragElementPos, float dragElementLastPos) { }

	internal virtual void ComputeValueFromKey(SliderKey<Int32> sliderKey, bool isShift) { }

	public virtual float get_pageSize() { }

	internal virtual int ParseStringToValue(string previousValue, string newValue) { }

	public virtual void set_pageSize(float value) { }

	internal virtual int SliderLerpUnclamped(int a, int b, float interpolant) { }

	internal virtual float SliderNormalizeValue(int currentValue, int lowerValue, int higherValue) { }

	internal virtual int SliderRange() { }

}

