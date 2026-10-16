namespace Coffee.UIEffects;

public class ParameterTexture
{
	[CompilerGenerated]
	private sealed class <>c
	{
		public static readonly <>c <>9; //Field offset: 0x0
		public static WillRenderCanvases <>9__16_0; //Field offset: 0x4

		private static <>c() { }

		public <>c() { }

		internal void <Initialize>b__16_0() { }

	}

	private static List<Action> updates; //Field offset: 0x0
	private Texture2D _texture; //Field offset: 0x8
	private bool _needUpload; //Field offset: 0xC
	private int _propertyId; //Field offset: 0x10
	private readonly string _propertyName; //Field offset: 0x14
	private readonly int _channels; //Field offset: 0x18
	private readonly int _instanceLimit; //Field offset: 0x1C
	private readonly Byte[] _data; //Field offset: 0x20
	private readonly Stack<Int32> _stack; //Field offset: 0x24

	public ParameterTexture(int channels, int instanceLimit, string propertyName) { }

	public float GetNormalizedIndex(IParameterTexture target) { }

	private void Initialize() { }

	public void Register(IParameterTexture target) { }

	public void RegisterMaterial(Material mat) { }

	public void SetData(IParameterTexture target, int channelId, byte value) { }

	public void SetData(IParameterTexture target, int channelId, float value) { }

	public void Unregister(IParameterTexture target) { }

	private void UpdateParameterTexture() { }

}

