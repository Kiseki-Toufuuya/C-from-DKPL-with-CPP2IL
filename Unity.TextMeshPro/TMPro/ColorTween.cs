namespace TMPro;

internal struct ColorTween : ITweenValue
{
	internal class ColorTweenCallback : UnityEvent<Color>
	{

		public ColorTweenCallback() { }

	}

	internal enum ColorTweenMode
	{
		All = 0,
		RGB = 1,
		Alpha = 2,
	}

	private ColorTweenCallback m_Target; //Field offset: 0x0
	private Color m_StartColor; //Field offset: 0x4
	private Color m_TargetColor; //Field offset: 0x14
	private ColorTweenMode m_TweenMode; //Field offset: 0x24
	private float m_Duration; //Field offset: 0x28
	private bool m_IgnoreTimeScale; //Field offset: 0x2C

	public override float duration
	{
		 get { } //Length: 11
		 set { } //Length: 18
	}

	public override bool ignoreTimeScale
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Color startColor
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public Color targetColor
	{
		 get { } //Length: 18
		 set { } //Length: 16
	}

	public ColorTweenMode tweenMode
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public void AddOnChangedCallback(UnityAction<Color> callback) { }

	public override float get_duration() { }

	public override bool get_ignoreTimeScale() { }

	public Color get_startColor() { }

	public Color get_targetColor() { }

	public ColorTweenMode get_tweenMode() { }

	public float GetDuration() { }

	public bool GetIgnoreTimescale() { }

	public void set_duration(float value) { }

	public void set_ignoreTimeScale(bool value) { }

	public void set_startColor(Color value) { }

	public void set_targetColor(Color value) { }

	public void set_tweenMode(ColorTweenMode value) { }

	public override void TweenValue(float floatPercentage) { }

	public override bool ValidTarget() { }

}

