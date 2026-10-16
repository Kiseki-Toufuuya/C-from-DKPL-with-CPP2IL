namespace XeApp.Game;

public class GameTouchEffect
{
	private class SlideEffect
	{
		private EffectObjectBase m_effect; //Field offset: 0x8
		private GameObject m_effect_gameobject; //Field offset: 0xC

		public Vector3 Position
		{
			 set { } //Length: 90
		}

		public SlideEffect() { }

		public void Hide() { }

		public void Initialize() { }

		public bool IsPlayingAnime() { }

		public void Play() { }

		public void set_Position(Vector3 value) { }

		public void Stop() { }

	}

	private class TouchEffect
	{
		private EffectObjectBase m_effect; //Field offset: 0x8
		private GameObject m_effect_gameobject; //Field offset: 0xC

		public Vector3 Position
		{
			 set { } //Length: 90
		}

		public TouchEffect() { }

		public void Hide() { }

		public void Initialize() { }

		public bool IsPlayingAnime() { }

		public void Play() { }

		public void set_Position(Vector3 value) { }

	}

	public static GameTouchEffect instance; //Field offset: 0x0
	private const int TOUCH_EFFECT_NUM = 6; //Field offset: 0x0
	private TouchEffect[] touchEffects; //Field offset: 0x8
	private SlideEffect slideEffect; //Field offset: 0xC
	private Camera mainCamera; //Field offset: 0x10
	private bool isDisable; //Field offset: 0x14
	private float EFFECT_OFFSET_Z; //Field offset: 0x18
	private readonly float DELAY_EFFECT_STOP_TIME; //Field offset: 0x1C
	private Vector3 preNativePosition; //Field offset: 0x20
	private float delayEffectStopTimer; //Field offset: 0x2C

	public bool IsDisable
	{
		 get { } //Length: 11
		 set { } //Length: 14
	}

	public Camera MainCamera
	{
		 get { } //Length: 11
		 set { } //Length: 27
	}

	public GameTouchEffect() { }

	public void Create() { }

	public bool get_IsDisable() { }

	public Camera get_MainCamera() { }

	public void Initialize() { }

	public void set_IsDisable(bool value) { }

	public void set_MainCamera(Camera value) { }

	public void Update() { }

}

