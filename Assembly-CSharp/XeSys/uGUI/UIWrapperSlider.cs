namespace XeSys.uGUI;

public class UIWrapperSlider : UIWrapperBase
{
	private Slider m_Slider; //Field offset: 0x14
	private Action<Single> m_onValueChanged; //Field offset: 0x18

	public float maxValue
	{
		 get { } //Length: 119
		 set { } //Length: 115
	}

	public float minValue
	{
		 get { } //Length: 119
		 set { } //Length: 115
	}

	public float normalizedValue
	{
		 get { } //Length: 120
		 set { } //Length: 115
	}

	public Slider slider
	{
		 get { } //Length: 11
	}

	public float value
	{
		 get { } //Length: 133
		 set { } //Length: 124
	}

	public bool wholeNumbers
	{
		 get { } //Length: 105
		 set { } //Length: 111
	}

	public UIWrapperSlider() { }

	public static UIWrapperSlider CreateSlider(GameObject root, string sliderName, Action<Single> onValueChanged = null) { }

	public float get_maxValue() { }

	public float get_minValue() { }

	public float get_normalizedValue() { }

	public Slider get_slider() { }

	public float get_value() { }

	public bool get_wholeNumbers() { }

	public void InitSlider(GameObject root, string sliderName, Action<Single> onValueChanged = null) { }

	private void onValueChangedProc(float val) { }

	public void set_maxValue(float value) { }

	public void set_minValue(float value) { }

	public void set_normalizedValue(float value) { }

	public void set_value(float value) { }

	public void set_wholeNumbers(bool value) { }

	public void SetOnValueChanged(Action<Single> onValueChanged) { }

}

