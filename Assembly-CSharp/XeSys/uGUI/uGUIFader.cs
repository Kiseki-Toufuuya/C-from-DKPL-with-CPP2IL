namespace XeSys.uGUI;

public class uGUIFader : MonoBehaviour
{
	internal interface IImage
	{

		public Color color
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public bool enabled
		{
			 get { } //Length: 0
			 set { } //Length: 0
		}

		public Color get_color() { }

		public bool get_enabled() { }

		public void set_color(Color value) { }

		public void set_enabled(bool value) { }

	}

	private class ImageInner : IImage
	{
		private Image mImage; //Field offset: 0x8

		public override Color color
		{
			 get { } //Length: 58
			 set { } //Length: 52
		}

		public override bool enabled
		{
			 get { } //Length: 34
			 set { } //Length: 34
		}

		public ImageInner(Image image) { }

		public override Color get_color() { }

		public override bool get_enabled() { }

		public override void set_color(Color value) { }

		public override void set_enabled(bool value) { }

	}

	public Color startColor; //Field offset: 0x10
	public Color endColor; //Field offset: 0x20
	public Color currentColor; //Field offset: 0x30
	private float mCurrentTime; //Field offset: 0x40
	private float mTargetTime; //Field offset: 0x44
	private Action mUpdateIdle; //Field offset: 0x48
	private Action mUpdate; //Field offset: 0x4C
	private IImage mImage; //Field offset: 0x50

	public bool isFading
	{
		 get { } //Length: 29
	}

	public bool IsFadOut
	{
		 get { } //Length: 71
	}

	public uGUIFader() { }

	private void Awake() { }

	public void Fade(float time, float targetAlpha) { }

	public void Fade(float time, Color end) { }

	public void Fade(float time, Color start, Color end) { }

	public bool get_isFading() { }

	public bool get_IsFadOut() { }

	protected override IImage GetImageComponent() { }

	private void Update() { }

	private void UpdateFade() { }

	private void UpdateIdle() { }

}

